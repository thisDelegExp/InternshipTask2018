using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternshipTask.Models
{
    public class Order
    {
        public List<OrderItem> Items { get; set; }
        public double TipsAmount { get; set; }
        public double TotalPrice { get; set; }
        public State OrderState { get; set; }
        public PlaceType OrderPlaceType { get; set; }
        public DateTime OpenedDate { get; set; }
        public DateTime ClosedDate { get; set; }
        public PaymentType Payment { get; set; }
    }

    public enum PlaceType
    {
        Table,
        Seat
    }

    public enum PaymentType
    {
        Card,
        Cash
    }
}
