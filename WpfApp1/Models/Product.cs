using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    public class Product
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public long Price { get; set; }
        public int Availability { get; set; }
        public int BuyerId { get; set; }
        public string Path { get; set; }
        public bool Visibly { get; set; }

    }
}
