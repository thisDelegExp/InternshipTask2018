using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using InternshipTask.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InternshipTask.Controllers
{
    public class AnalyticsController : Controller
    {
        private OrderContext context;

        public AnalyticsController()
        {
            context = new OrderContext{Items=new List<OrderItem>(),Orders = new List<Order>()};
            SampleData.Initialize(context);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Main()
        {
            double avrgPaidOrder =
                (from order in context.Orders
                    where order.OrderState == State.Paid
                    select order.TotalPrice).Average();
            double totalRevenue = (from order in context.Orders
                where order.OrderState == State.Paid
                select order.TotalPrice).Sum();
            int totalOrders = context.Orders.Count();
            
            int totalOrderedItems = (from order in context.Orders select order.Items.Count).Sum();


            ViewBag.AvrgPaidOrder = avrgPaidOrder;
            ViewBag.TotalRevenue = totalRevenue;
            ViewBag.TotalOrders = totalOrders;
            ViewBag.TotalOrderedItems = totalOrderedItems;
            ViewData["Title"] = "Main";
            return View();
        }

        [HttpGet]
        [Authorize]
        public IActionResult Menu()
        {

            var items = from item in (from order in context.Orders select order.Items).SelectMany(item => item)
                    
                select item;
            var itemOccurrences = items.GroupBy(i => i).ToDictionary(group => group.Key, group => group.Count());
            var itemsSorted = from item in itemOccurrences orderby item.Value descending select item;
            var top10 = itemsSorted.Take(10);
            var last10 = itemsSorted.TakeLast(10);

            ViewBag.Top10 = top10;
            ViewBag.Last10 = last10;
            ViewData["Title"] = "Menu";
            return View();
        }

        [HttpGet]
        [Authorize]
        public IActionResult Payment()
        {
            int payByCard = (from order in context.Orders where order.Payment == PaymentType.Card select order).Count();
            int payByCash = (from order in context.Orders where order.Payment == PaymentType.Cash select order).Count();
            double cardRevenue =
                (from order in context.Orders where order.Payment == PaymentType.Card select order.TotalPrice).Sum();
            double cashRevenue =
                (from order in context.Orders where order.Payment == PaymentType.Cash select order.TotalPrice).Sum();

            var tips = from order in context.Orders select order.TipsAmount;
            double avrgTips = tips.Average();
            int tipsCount = tips.Count();
            double tipsSum = tips.Sum();

            ViewBag.PayByCard = payByCard;
            ViewBag.PayByCash = payByCash;
            ViewBag.CardRevenue = cardRevenue;
            ViewBag.CashRevenue = cashRevenue;
            ViewBag.AvrgTips = avrgTips;
            ViewBag.TipsCount = tipsCount;
            ViewBag.TipsSum = tipsSum;
            ViewData["Title"] = "Payments";
            return View();
        }

    }
}