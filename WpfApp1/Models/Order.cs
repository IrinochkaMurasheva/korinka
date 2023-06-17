using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    public class Order
    {
        public int id { get; set; }
        public string name { get; set; }
        public string? description { get; set; }
        public string address { get; set; }
        public DateTime createdOrdersDate { get; set; }
        public DateTime? dileveryDate { get; set; }
        public Status status { get; set; }
    }
}
