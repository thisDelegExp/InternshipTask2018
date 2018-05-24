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
                            Name = "Latte",
                            Price = 3,
                            Media = "Restaurant App"
                        },
                        new OrderItem
                        {
                            Name = "Muffin",
                            Price = 5,
                            Media = "Restaurant App"
                        },
                        new OrderItem
                        {
                            Name = "Deadpool 2",
                            Price = 6,
                            Media = "Cinema App"
                        },
                        new OrderItem
                        {
                            Name = "Incredible Hulk",
                            Price = 5,
                            Media = "Cinema App"
                        },
                        new OrderItem
                        {
                            Name = "Flat White",
                            Price = 3.5,
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
                            Name = "Sandwich",
                            Price = 3.5,
                            Media = "Restaurant App"
                        },
                        new OrderItem
                        {
                            Name = "Green Tea",
                            Price = 1,
                            Media = "Restaurant App"
                        },
                        new OrderItem
                        {
                            Name = "Iron Man",
                            Price = 5,
                            Media = "Cinema App"
                        },
                        new OrderItem
                        {
                            Name = "IT",
                            Price = 6,
                            Media = "Cinema App"
                        },
                        new OrderItem
                        {
                            Name = "Cream Soup",
                            Price = 2,
                            Media = "Restaurant App"
                        },
                        new OrderItem
                        {
                            Name = "Avengers",
                            Price = 6,
                            Media = "Cinema App"
                        },
                        new OrderItem
                        {
                            Name = "Fruit Smuzzi",
                            Price = 3,
                            Media = "Restaurant App"
                        },
                        new OrderItem
                        {
                            Name = "Cheese Crisps",
                            Price = 2,
                            Media = "Restaurant App"
                        },
                        new OrderItem
                        {
                            Name = "Star Wars Ep.6 Return of The Jedi",
                            Price = 4,
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
                            Items = new List<OrderItem>{context.Items[18]},
                            OrderPlaceType = PlaceType.Seat,
                            OrderState = State.Paid,
                            ClosedDate = new DateTime(2018,6,26,12,23,45),
                            OpenedDate = new DateTime(2018,6,26,12,40,34),
                            TipsAmount = 1.2,
                            TotalPrice = 5.2,
                            Payment = PaymentType.Card


                        },
                        new Order
                        {
                            Items = new List<OrderItem>{context.Items[18],context.Items[19]},
                            OrderPlaceType = PlaceType.Seat,
                            OrderState = State.Paid,
                            ClosedDate = new DateTime(2018,6,23,12,23,45),
                            OpenedDate = new DateTime(2018,6,23,12,40,34),
                            TipsAmount = 1.2,
                            TotalPrice = 9.2,
                            Payment = PaymentType.Card


                        },
                        new Order
                        {
                            Items = new List<OrderItem>{context.Items[18],context.Items[17]},
                            OrderPlaceType = PlaceType.Seat,
                            OrderState = State.Paid,
                            ClosedDate = new DateTime(2018,6,26,12,23,45),
                            OpenedDate = new DateTime(2018,6,26,12,40,34),
                            TipsAmount = 1.2,
                            TotalPrice = 7.2,
                            Payment = PaymentType.Cash


                        },
                        new Order
                        {
                            Items = new List<OrderItem>{context.Items[18],context.Items[1]},
                            OrderPlaceType = PlaceType.Table,
                            OrderState = State.Paid,
                            ClosedDate = new DateTime(2018,6,28,12,23,45),
                            OpenedDate = new DateTime(2018,6,28,12,40,34),
                            TipsAmount = 1.8,
                            TotalPrice = 8.8,
                            Payment = PaymentType.Cash


                        },
                        new Order
                        {
                            Items = new List<OrderItem>{context.Items[18],context.Items[1]},
                            OrderPlaceType = PlaceType.Seat,
                            OrderState = State.Paid,
                            ClosedDate = new DateTime(2018,7,1,12,23,45),
                            OpenedDate = new DateTime(2018,7,1,12,40,34),
                            TipsAmount = 1.8,
                            TotalPrice = 8.8,
                            Payment = PaymentType.Card


                        },
                        new Order
                        {
                            Items = new List<OrderItem>{context.Items[18],context.Items[1]},
                            OrderPlaceType = PlaceType.Seat,
                            OrderState = State.Paid,
                            ClosedDate = new DateTime(2018,7,1,12,23,45),
                            OpenedDate = new DateTime(2018,7,1,12,40,34),
                            TipsAmount = 1.8,
                            TotalPrice = 8.8,
                            Payment = PaymentType.Card


                        },
                        new Order
                        {
                            Items = new List<OrderItem>{context.Items[4],context.Items[5],context.Items[6]},
                            OrderPlaceType = PlaceType.Seat,
                            OrderState = State.Paid,
                            ClosedDate = new DateTime(2018,3,22,11,21,45),
                            OpenedDate = new DateTime(2018,3,22,11,29,34),
                            TipsAmount = 2,
                            TotalPrice = 16.5,
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


                        },
                        new Order
                        {
                            Items = new List<OrderItem>{context.Items[7],context.Items[8]},
                            OrderPlaceType = PlaceType.Seat,
                            OrderState = State.Paid,
                            ClosedDate = new DateTime(2018,2,5,11,21,45),
                            OpenedDate = new DateTime(2018,2,5,11,29,34),
                            TipsAmount = 1,
                            TotalPrice = 14.7,
                            Payment = PaymentType.Cash


                        },
                        new Order
                        {
                            Items = new List<OrderItem>{context.Items[7],context.Items[8],context.Items[10],context.Items[11],context.Items[12],context.Items[13]},
                            OrderPlaceType = PlaceType.Seat,
                            OrderState = State.Paid,
                            ClosedDate = new DateTime(2018,2,13,11,21,45),
                            OpenedDate = new DateTime(2018,2,13,11,29,34),
                            TipsAmount = 1,
                            TotalPrice = 30.2,
                            Payment = PaymentType.Cash


                        },
                        new Order
                        {
                            Items = new List<OrderItem>{ //mega-order)
                                context.Items[0],
                                context.Items[1],
                                context.Items[2],
                                context.Items[3],
                                context.Items[4],
                                context.Items[5],
                                context.Items[6],
                                context.Items[7],
                                context.Items[8],
                                context.Items[9],
                                context.Items[10],
                                context.Items[11],
                                context.Items[12],
                                context.Items[13],
                                context.Items[14],
                                context.Items[15],
                                context.Items[16],
                                context.Items[17],
                                context.Items[18],
                                context.Items[19]
                                },
                            OrderPlaceType = PlaceType.Table,
                            OrderState = State.Paid,
                            ClosedDate = new DateTime(2018,3,5,11,21,45),
                            OpenedDate = new DateTime(2018,3,5,11,29,34),
                            TipsAmount = 1,
                            TotalPrice = 83.9,
                            Payment = PaymentType.Cash


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
