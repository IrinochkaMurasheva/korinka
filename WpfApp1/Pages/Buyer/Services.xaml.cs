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
using WpfApp1.Pages.Seller;

namespace WpfApp1.Pages.Buyer
{
    /// <summary>
    /// Логика взаимодействия для Service.xaml
    /// </summary>
    public partial class Services : Page
    {
        public DBSession _dBSession;
        public Models.Buyer _Buyer;
        public Services(DBSession dBSession,Models.Buyer buyer)
        {
            _dBSession = dBSession;
            _Buyer = buyer;
            InitializeComponent();
        }
        //возврат
        private void Return_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SelectionPageBuyer(_dBSession,_Buyer));

        }
        //добавление услуги
        private void EditCategory(object sender, RoutedEventArgs e)
        {
            var serviceSelect = (Models.Service)((Button)sender).DataContext;
            var serviceDB=_dBSession.services.SingleOrDefault(p=>p.Name == serviceSelect.Name);
            var basket = _dBSession.baskets.SingleOrDefault(p => p.BuerId == _Buyer.Id);
            basket.services.Add(serviceDB);
            _dBSession.SaveChanges();
            NavigationService.Navigate(new Services(_dBSession, _Buyer));
        }
        //загрузка
        public void ListAddInfo()
        {
            var service = _dBSession.services.ToList();
            foreach (var s in service)
            {
                listUsers.Items.Add(s);
            }

        }
    }
}
