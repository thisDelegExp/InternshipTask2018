using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace InternshipTask.Models
{
    public class OrderContext
    {
        public List<OrderItem> Items { get; set; }
        public List<Order> Orders { get; set; }

       
    }
}
