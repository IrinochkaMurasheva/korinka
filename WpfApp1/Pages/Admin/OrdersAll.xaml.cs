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
    /// вывод всех заказов
    /// </summary>
    public partial class OrdersAll : Page
    {
        DBSession _dBSession;

        public OrdersAll(DBSession dBSession)
        {
            _dBSession = dBSession;
            InitializeComponent();
            ListAddInfo();
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminSelectionPage(_dBSession));
        }
        //изменение статуса заказа на "Отменен"
        private void EditCategory(object sender, RoutedEventArgs e)
        {
            var categoryListView = (Models.Order)((Button)sender).DataContext;
            var order = _dBSession.orders.SingleOrDefault(p => p.name == categoryListView.name);
            var status = _dBSession.status.SingleOrDefault(p => p.Name == "Отмена");
            order.status = status;
            _dBSession.SaveChanges();
            ListAddInfo();
        }
        //загрузка всех заказов из БД
        public void ListAddInfo()
        {

            if (_dBSession != null)
            {
                var orders = _dBSession.orders.ToList();
                foreach (var order in orders)
                {
                    listUsers.Items.Add(order);
                }
            }
        }
    }
}
