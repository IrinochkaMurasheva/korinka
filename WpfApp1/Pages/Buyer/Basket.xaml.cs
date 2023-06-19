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

namespace WpfApp1.Pages.Buyer
{
    /// <summary>
    /// Логика взаимодействия для Basket.xaml
    /// </summary>
    public partial class Basket : Page
    {
        readonly DBSession _dBSession;
        public Models.Buyer _buyer;
        public Basket(DBSession dBSession, Models.Buyer buyer)
        {
            InitializeComponent();
            ListAddInfo();
            _buyer = buyer;
        }
        //сформировать заказ
        private void placeOrder_Click(object sender, RoutedEventArgs e)
        {
            var status = _dBSession.status.Where(p => p.Name == "Новый");
            Models.Order order = new Models.Order()
            {
                name = _dBSession.orders.Count() + "Order",
                description = "",
                address = "",
                createdOrdersDate = DateTime.Now,
                dileveryDate = DateTime.Parse(""),
                Sum = 0
            };
            order.status= _dBSession.status.SingleOrDefault(p => p.Name == "Новый");
            _dBSession.orders.Add(order);
            _dBSession.SaveChanges();

        }
        //возврат
        private void Return_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SelectionPageBuyer(_dBSession));
        }
        //загрузка корзины
        public void ListAddInfo()
        {
            var basket = _dBSession.baskets.Where(p => p.BuerId == _buyer.Id).ToList();
            foreach (var b in basket)
            {
                listUsers.Items.Add(b);
            }

        }
    }
}
