using Microsoft.EntityFrameworkCore;
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
    /// Логика взаимодействия для Orders.xaml
    /// </summary>
    public partial class Orders : Page
    {
        public Models.Buyer Buyer;
        public DBSession _dBSession;
        public Orders(DBSession dBSession, Models.Buyer buyer)
        {
            _dBSession = dBSession;
            InitializeComponent();
            Buyer = buyer;
        }
        //возврат
        private void Return_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SelectionPageBuyer(_dBSession,Buyer));

        }
        //изменение статуса заказа
        private void EditCategory(object sender, RoutedEventArgs e)
        {
            var orderSelect = (Models.Order)((Button)sender).DataContext;
            var orders=_dBSession.orders.SingleOrDefault(p=>p.id== orderSelect.id);
            var status = _dBSession.status.SingleOrDefault(p => p.Name == "Отмена");
            orders.status = status;
            _dBSession.SaveChanges();
            NavigationService.Navigate(new Orders(_dBSession, Buyer));
        }
        //загрузка заказов
        public void ListAddInfo()
        {
            var buyers = _dBSession.buyers.SingleOrDefault(p=>p.Id==Buyer.Id);
            foreach (var order in buyers.orders)
            {

                listUsers.Items.Add(order);
            }

        }
    }
}
