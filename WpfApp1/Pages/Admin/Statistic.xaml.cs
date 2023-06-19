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
    /// Статистика администратора по клиентам и заказам и продавцам
    /// </summary>
    public partial class Statistic : Page
    {
        DBSession _dBSession;

        public Statistic(DBSession dBSession)
        {
            _dBSession = dBSession;
            InitializeComponent();
            ListAddInfo();
        }
        //возврат на предыдущую страницу
        private void Return_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminSelectionPage(_dBSession));

        }
        //загрузка данных из бд в UI
        public void ListAddInfo()
        {
            var ordersSum = _dBSession.orders.Where(p => p.status.Name == "Отмена").ToList();
            int sum = new int();
            foreach (var order in ordersSum)
            {
                if (order.Sum != null)
                { sum += order.Sum; }
            }
            AllOrders.Content = _dBSession.orders.Count();
            CanceledOrders.Content = _dBSession.orders.Where(p => p.status.Name == "Отмена").Count();
            ComplitedOrders.Content = _dBSession.orders.Where(p => p.status.Name == "Выполнен").Count();
            AllSum.Content = sum;
            PosInMod.Content =_dBSession.products.Where(p=>p.Moderation==false).Count()+ _dBSession.services.Where(p => p.Moderation == false).Count();
            CountSeller.Content=_dBSession.sellers.Count();
            CountBuyer.Content=_dBSession.buyers.Count();
            AllPositions.Content= _dBSession.products.Count() + _dBSession.services.Count();
        }
    }
}