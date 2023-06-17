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
    /// </summary>
    public partial class SelectionPageBuyer : Page
    {
        readonly DBSession _dBSession;
        public SelectionPageBuyer(DBSession dBSession)
        {
            _dBSession=dBSession;
            InitializeComponent();
        }

        private void Services_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Services(_dBSession));
        }

        private void Basket_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Basket(_dBSession));
        }

        private void Orders_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Orders(_dBSession));
        }

        private void Produc_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Products(_dBSession));
        }

        private void StatisticPurchase_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StatisticPurchase(_dBSession));
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Login(_dBSession));
        }
    }
}
