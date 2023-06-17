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
    /// Логика взаимодействия для Registered.xaml
    /// </summary>
    public partial class Registered : Page
    {
        DBSession _dBSession;
        public Registered(DBSession dBSession)
        {
            _dBSession = dBSession;
            InitializeComponent();
        }

        private void Buyer_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegisteredBuyer(_dBSession));
        }

        private void Seller_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegisteredSeller(_dBSession));
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Login(_dBSession));
        }
    }
}
