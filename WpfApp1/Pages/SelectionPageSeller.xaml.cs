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

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для SelectionPageSeller.xaml
    /// </summary>
    public partial class SelectionPageSeller : Page
    {
        readonly DBSession _dBSession;
        public SelectionPageSeller(DBSession dBSession)
        {
            _dBSession = dBSession;
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Login(_dBSession));
        }

        private void Organization_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new OrganizationCard(_dBSession));
        }

        private void EditProduct_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddProduct(_dBSession));
        }

        private void AddServices_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
