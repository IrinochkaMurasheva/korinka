using Microsoft.Identity.Client;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using WpfApp1.Models;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Page
    {
        public DBSession _dBSession;
        public Models.Seller _Seller;
        public AddProduct(DBSession dBSession, Models.Seller seller)
        {
            _dBSession = dBSession;
            InitializeComponent();
            addCategoryBox();
            _Seller = seller;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {

            Product product = new Product()
            {
                Name = ProductName.Text,
                Availability = int.Parse(CountProduct.Text),
                Price = int.Parse(ProductPrice.Text),
                Description = DescriptionProduct.Text,
                Path = ProductPath.Text,
                Moderation = false,
                Visibly = false
            };
            var categoru=_dBSession.categories.SingleOrDefault(p => p.Name == CategoryBox.Text);
            product.Category = categoru;
            _dBSession.products.Add(product);
            _dBSession.SaveChanges();
            MessageBox.Show("Добавлен товар.");
            NavigationService.Navigate(new SelectionPageSeller(_dBSession, _Seller));
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SelectionPageSeller(_dBSession,_Seller));
        }
        
        public void addCategoryBox()
        {
            var categories = _dBSession.categories.ToList();
            foreach (var category in categories) 
            {
                CategoryBox.Items.Add(category.Name);
            }
        }
    }
}
