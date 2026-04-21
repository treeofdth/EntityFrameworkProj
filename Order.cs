using System;
using System.Collections.Generic;
using System.Text;

namespace SmthProj.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
