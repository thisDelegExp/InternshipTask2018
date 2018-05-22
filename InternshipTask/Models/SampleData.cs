using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Internal;

namespace InternshipTask.Models
{
    public static  class SampleData
    {
        public static void Initialize(OrderContext context)
        {
            if (!context.Items.Any())
            {
                context.Items.AddRange(new List<OrderItem>
                    { 
                        new OrderItem
                        {
                            Name = "Star Wars The Last Jedi",
                            Price = 6.5,
                            Media = "Cinema App"

                        },
                        new OrderItem
                        {
                            Name = "Irish Latte",
                            Price = 3,
                            Media = "Restaurant App"
                        },
                        new OrderItem
                        {
                            Name = "Twinkies",
                            Price = 3.70,
                            Media = "Restaurant App"

                        },
                        new OrderItem
                        {
                            Name = "Havanna Pizza",
                            Price = 10,
                            Media = "Restaurant App"
                        },
                        new OrderItem
                        {
                            Name = "Avengers: Infinity War",
                            Price = 6.7,
                            Media = "Cinema App"

                        },
                        new OrderItem
                        {
                            Name = "Cheesecake",
                            Price = 4,
                            Media = "Restaurant App"

                        }
                      }
                    );
                
            }

            if (!context.Orders.Any())
            {
                context.Orders.AddRange(new List<Order>
                    {
                        new Order
                        {
                            Items = new List<OrderItem>{context.Items[3]},
                            OrderPlaceType = PlaceType.Seat,
                            OrderState = State.Paid,
                            ClosedDate = new DateTime(2018,5,26,12,23,45),
                            OpenedDate = new DateTime(2018,5,26,12,40,34),
                            TipsAmount = 1,
                            TotalPrice = 11,
                            Payment = PaymentType.Card
                            

                        },
                        new Order
                        {
                            Items = new List<OrderItem>{context.Items[4],context.Items[4]},
                            OrderPlaceType = PlaceType.Seat,
                            OrderState = State.Paid,
                            ClosedDate = new DateTime(2018,6,22,11,21,45),
                            OpenedDate = new DateTime(2018,6,22,11,29,34),
                            TipsAmount = 1.5,
                            TotalPrice = 8.2,
                            Payment = PaymentType.Cash


                        },
                        new Order
                        {
                            Items = new List<OrderItem>{context.Items[5]},
                            OrderPlaceType = PlaceType.Table,
                            OrderState = State.Paid,
                            ClosedDate = new DateTime(2018,6,23,11,21,45),
                            OpenedDate = new DateTime(2018,6,23,11,29,34),
                            TipsAmount = 2,
                            TotalPrice = 6,
                            Payment = PaymentType.Card


                        }
                    }
                );

            }
        }

        public static void InitializeAccount(UserContext context)
        {
            if (!context.Users.Any())
            {
                context.Users.Add(new User
                {
                    Email = "sample@gmail.com",
                    Id = 1,
                    Password = "qwertyuiop"
                });
            }
        }
    }
}
