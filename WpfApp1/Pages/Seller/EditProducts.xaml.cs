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

namespace WpfApp1.Pages.Seller
{
    /// <summary>
    /// Логика взаимодействия для EditProducts.xaml
    /// </summary>
    public partial class EditProducts : Page
    {
        readonly DBSession _dBSession;
        readonly Models.Seller _seller;

        public EditProducts(DBSession dBSession, Models.Seller seller)
        {
            _dBSession = dBSession;
            InitializeComponent();
            _seller = seller;
            ListAddInfo();
        }
        //редактирование продукта
        private void EditCategory(object sender, RoutedEventArgs e)
        {
            var product = (Models.Product)((Button)sender).DataContext;
            NavigationService.Navigate(new EditProduct(_dBSession,_seller,product));
        }
        public void ListAddInfo()
        {

            if (_dBSession != null)
            {
                var products = _dBSession.products.Where(p=>p.SellerId==_seller.Id).ToList();
                foreach (var product in products)
                {
                    listUsers.Items.Add(product);
                }
            }
        }
    }
}
