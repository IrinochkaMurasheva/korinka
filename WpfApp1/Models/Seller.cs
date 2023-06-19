using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    //Клас создания продавца
    public class Seller : Counterparti
    {
        public string? INN { get; set; }
        public string? OGRN { get; set; }
        public List<Product>? Products { get; set; }
        public List<Service>? Services { get; set; }
    }
}
