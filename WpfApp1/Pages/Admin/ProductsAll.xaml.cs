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
    /// Логика взаимодействия для ProductsAll.xaml
    /// </summary>
    public partial class ProductsAll : Page
    {
        DBSession _dBSession;

        public ProductsAll(DBSession dBSession)
        {
            _dBSession = dBSession;
            InitializeComponent();
        }

        private void listUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminSelectionPage(_dBSession));
        }
    }
}
