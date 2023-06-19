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
using WpfApp1.Pages.Buyer;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для Products.xaml
    /// </summary>
    public partial class Products : Page
    {
        public Models.Buyer _buyer;
        public DBSession _dBSession;
        public Products(DBSession dBSession, Models.Buyer buyer)
        {
            _dBSession = dBSession;
            InitializeComponent();
            _buyer = buyer;
        }
        public void AddToBasket(object sender, RoutedEventArgs e)
        {
            var productService = (Models.Product)((Button)sender).DataContext;
            var productDB = _dBSession.products.SingleOrDefault(p => p.Name == productService.Name);
            var basket = _dBSession.baskets.SingleOrDefault(p => p.BuerId == _buyer.Id);
            basket.products.Add(productDB);
            _dBSession.SaveChanges();
            NavigationService.Navigate(new Services(_dBSession, _buyer));
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SelectionPageBuyer(_dBSession,  _buyer));

        }
        public void ListAddInfo()
        {
            var products = _dBSession.products.ToList();
            foreach (var product in products)
            {
                listUsers.Items.Add(product);
            }

        }
    }
}
