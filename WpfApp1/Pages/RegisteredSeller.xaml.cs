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
    /// Логика взаимодействия для RegisteredSeller.xaml
    /// </summary>
    public partial class RegisteredSeller : Page
    {
        DBSession _dBSession;
        public RegisteredSeller( DBSession dBSession)
        {
            _dBSession = dBSession;
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Models.Seller seller = new Models.Seller()
            {
                INN = OrganizationINN.Text,
                OGRN = OrganizationOGRN.Text,
                Name = OrganizationName.Text,
                Phone=Phone.Text,
                Password=OrganizationPassword.Text
            };
            _dBSession.sellers.Add(seller);
            _dBSession.SaveChanges();
            NavigationService.Navigate(new Login(_dBSession));
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Login(_dBSession));
        }
    }
}
