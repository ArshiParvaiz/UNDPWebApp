using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemo.Models
{
    public class Product
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public double BasePrice {get; set;}
        public string description{ get; set; }
    }
}
