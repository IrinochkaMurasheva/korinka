using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    public class Basket
    {
        public int Id { get; set; }
        public List<Product> products { get; set; }
        public List<Service> services { get; set; }
        public int BuerId { get; set; }
    }
}
