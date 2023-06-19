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
    /// Логика взаимодействия для EditProduct.xaml
    /// </summary>
    public partial class EditProduct : Page
    {
        public DBSession _dBSession;
        readonly Models.Seller _seller;
        public Models.Product Product;
        public EditProduct(DBSession dBSession,Models.Seller seller, Models.Product product)
        {
            _dBSession = dBSession;
            _seller = seller;
            Product = product;
            InitializeComponent();
        }
        //изменение выбранной позиции
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Product.Name = ProductName.Text;
            Product.Availability = int.Parse(CountProduct.Text);
            Product.Price = int.Parse(ProductPrice.Text);
            Product.Description = DescriptionProduct.Text;
            Product.Path = ProductPath.Text;
            Product.Moderation = false;
            Product.Visibly = false;
            _dBSession.SaveChanges();
            MessageBox.Show("товар изменен.");
            NavigationService.Navigate(new EditProducts(_dBSession, _seller));
        }
        //возврат на страницу с товарами
        private void Return_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditProducts(_dBSession, _seller));
        }
    }
}
