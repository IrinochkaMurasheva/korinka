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
    /// Логика взаимодействия для ServicesAll.xaml
    /// </summary>
    public partial class ServicesAll : Page
    {
        DBSession _dBSession;

        public ServicesAll(DBSession dBSession)
        {
            _dBSession = dBSession;
            InitializeComponent();
            ListAddInfo();
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminSelectionPage(_dBSession));

        }
        private void listUsers_SelectionChanged(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminSelectionPage(_dBSession));

        }

        private void EditCategory(object sender, RoutedEventArgs e)
        {
            if (((Button)sender).DataContext is Models.Service produst)
            {
                var productListView = (Models.Service)((Button)sender).DataContext;
                var servicedb = _dBSession.services.SingleOrDefault(p => p.Name == productListView.Name);
                if (servicedb.Visibly = true)
                { servicedb.Visibly = false; }
                else { servicedb.Visibly = false; }
                _dBSession.SaveChanges();
                ListAddInfo();
            }
        }
        public void ListAddInfo()
        {

            if (_dBSession != null)
            {
                var services = _dBSession.services.ToList();
                foreach (var service in services)
                {
                    listUsers.Items.Add(service);
                }
            }
        }
    }
}
