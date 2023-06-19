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
    /// Логика взаимодействия для OrdersSeller.xaml
    /// </summary>
    public partial class OrdersSeller : Page
    {
        readonly DBSession _dBSession;
        readonly Models.Seller _seller;

        public OrdersSeller(DBSession dBSession, Models.Seller seller)
        {
            _dBSession = dBSession;
            InitializeComponent();
            _seller = seller;
            ListAddInfo();
        }
        //возврат в меню
        private void Return_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SelectionPageSeller(_dBSession,_seller));

        }
        //загрузка заказов
        public void ListAddInfo()
        {

            if (_dBSession != null)
            {
                List<int> productId=new List<int>();
                List<Order> orders = new List<Order>();
                var ordersDB = _dBSession.orders.ToList();
                
                var services = _dBSession.services.Where(p => p.SellerId == _seller.Id).ToList();
                foreach(var s in services)
                {
                    productId.Add(s.Id);
                }
                var positions=_dBSession.products.Where(p=>p.SellerId==_seller.Id).ToList();
                foreach (var p in positions)
                {
                    productId.Add(p.Id);
                }
                foreach (Order order in ordersDB)
                {
                    foreach (var position in order.products)
                    {
                        if(productId.Contains(position.Id))
                        {
                            orders.Add(order);
                        }
                    }
                }
                foreach (var order in orders)
                {
                    listUsers.Items.Add(order);
                }
            }
        }
    }
}
