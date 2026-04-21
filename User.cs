using System;
using System.Collections.Generic;
using System.Text;

namespace SmthProj.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now  ;
        public List<Order> orders { get; set; } = new();
    }
}
