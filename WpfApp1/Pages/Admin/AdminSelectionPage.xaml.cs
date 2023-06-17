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

namespace WpfApp1.Pages.Admin
{
    /// <summary>
    /// Логика взаимодействия для AdminSelectionPage.xaml
    /// </summary>
    public partial class AdminSelectionPage : Page
    {
        DBSession _dBSession;
        public AdminSelectionPage(DBSession dBSession)
        {
            _dBSession = dBSession;

            InitializeComponent();
        }

        private void Produc_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProductsAll(_dBSession));
        }

        private void Services_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ServicesAll(_dBSession));
        }

        private void Orders_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OrdersAll(_dBSession));
        }

        private void Basket_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PositionsMod(_dBSession));
        }

        private void StatisticPurchase_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Statistic(_dBSession));
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Login(_dBSession));
        }

        private void Category_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Category(_dBSession));
        }
       
    }
}
