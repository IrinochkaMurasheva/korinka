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
    /// Логика взаимодействия для Products.xaml
    /// </summary>
    public partial class Products : Page
    {
        readonly DBSession _dBSession;
        public Products(DBSession dBSession)
        {
            _dBSession = dBSession;
            InitializeComponent();
        }
        public void AddToBasket(object sender, RoutedEventArgs e)
        {

        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SelectionPageBuyer(_dBSession));

        }
        public void EditCategory(object sender, RoutedEventArgs e)
        {

        }
    }
}
