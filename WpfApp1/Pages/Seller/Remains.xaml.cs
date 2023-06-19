using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Models;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Просмотр остатков
    /// </summary>
    public partial class Remains : Page
    {
        readonly DBSession _dBSession;
        readonly Models.Seller _seller;

        public Remains(DBSession dBSession, Models.Seller seller)
        {
            _dBSession = dBSession;
            InitializeComponent();
            _seller = seller;
        }
        //загрузка остатков
        public void ListAddInfo()
        {

            if (_dBSession != null)
            {
                

                var services = _dBSession.services.Where(p => p.SellerId == _seller.Id).ToList();
                
                var positions = _dBSession.products.Where(p => p.SellerId == _seller.Id).ToList();
                
                foreach (var service in services)
                {
                    listUsers.Items.Add(service);
                }
                foreach (var position in positions)
                {
                    listUsers.Items.Add(position);
                }
            }
        }
    }
}
