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
    /// Страница модераций для товаров
    /// </summary>
    public partial class PositionsMod : Page
    {
        DBSession _dBSession;

        public PositionsMod(DBSession dBSession)
        {
            _dBSession = dBSession;
            InitializeComponent();
            ListAddInfo();
        }
        //возврат на предыдущую позицыю
        private void Return_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminSelectionPage(_dBSession));

        }
        private void listUsers_SelectionChanged(object sender, RoutedEventArgs e)
        {
            

        }
        //Подтверждение позицыы
        private void EditCategory(object sender, RoutedEventArgs e)
        {
            if (((Button)sender).DataContext is Models.Product produst)
            {
                var productListView = (Models.Product)((Button)sender).DataContext;
                var productDB = _dBSession.products.SingleOrDefault(p => p.Name == productListView.Name);
                productDB.Moderation = true;
                _dBSession.SaveChanges();
                NavigationService.Navigate(new PositionsMod(_dBSession));
            }
            else if(((Button)sender).DataContext is Models.Service services)
            {
                var productListView = (Models.Service)((Button)sender).DataContext;
                var productDB = _dBSession.services.SingleOrDefault(p => p.Name == productListView.Name);
                productDB.Moderation = true;
                _dBSession.SaveChanges();
                NavigationService.Navigate(new PositionsMod(_dBSession));
            }

        }
        //Подгрузка данных из бд
        public void ListAddInfo()
        {

            if (_dBSession != null)
            {

                var products = _dBSession.products.Where(p=>p.Moderation==false).ToList();
                foreach (var product in products)
                {
                    listUsers.Items.Add(product);
                }
                var services = _dBSession.services.Where(p => p.Moderation == false).ToList();
                foreach (var service in services)
                {
                    listUsers.Items.Add(service);
                }
            }
        }

    }
}
