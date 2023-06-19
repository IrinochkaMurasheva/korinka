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

namespace WpfApp1.Pages.Admin
{
    /// <summary>
    /// Вывод всех позицый
    /// </summary>
    public partial class ProductsAll : Page
    {
        DBSession _dBSession;

        public ProductsAll(DBSession dBSession)
        {
            _dBSession = dBSession;
            InitializeComponent();
            ListAddInfo();
        }

        private void listUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        //возврат на предыдущую страницу
        private void Return_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminSelectionPage(_dBSession));
        }
        //Сделать позицыю видимой для покупателей или нет
        private void EditCategory(object sender, RoutedEventArgs e)
        {
            if (((Button)sender).DataContext is Models.Product produst)
            {
                var productListView = (Models.Product)((Button)sender).DataContext;
                var productsDb = _dBSession.products.SingleOrDefault(p => p.Name == productListView.Name);
                if (productsDb.Visibly = true)
                { productsDb.Visibly = false; }
                else { productsDb.Visibly = false; }
                _dBSession.SaveChanges();
                ListAddInfo();
            }
        }
        //загрузка данных из БД
        public void ListAddInfo()
        {

            if (_dBSession != null)
            {
                var products = _dBSession.products.ToList();
                foreach (var product in products)
                {
                    listUsers.Items.Add(product);
                }
            }
        }
    }
}
