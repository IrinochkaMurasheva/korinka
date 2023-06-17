using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    public class Buyer : Counterparti
    {
        public string? Surname { get; set; }
        public string? Patronymic { get; set; }
        public List<Order>? orders { get; set; }
    }
}
