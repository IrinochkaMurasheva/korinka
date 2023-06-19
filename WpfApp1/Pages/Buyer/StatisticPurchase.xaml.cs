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
using WpfApp1.Pages.Admin;

namespace WpfApp1.Pages.Buyer
{
    /// <summary>
    /// Логика взаимодействия для StatisticPurchase.xaml
    /// </summary>
    public partial class StatisticPurchase : Page
    {
        readonly Models.Buyer buyer;
        readonly DBSession _dBSession;
        public StatisticPurchase(DBSession dBSession, Models.Buyer buyer)
        {
            _dBSession = dBSession;
            InitializeComponent();
            this.buyer = buyer;
        }
        //возврат
        private void Return_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SelectionPageBuyer(_dBSession,buyer));
        }
        //загрузка статистики
        public void StatisticLoad()
        {
            AllOrders.Content = buyer.orders.Count();
            OrdersComplited.Content= buyer.orders.Where(p=>p.status.Name=="Выполнен").Count();
            OrderCanceled.Content= buyer.orders.Where(p => p.status.Name == "Отмена").Count();
            ToWork.Content= buyer.orders.Where(p => p.status.Name == "В работе").Count();
            var allPositions = buyer.orders.ToList();
            int positionsCount=0;
            foreach (var order in allPositions)
            {
                foreach (var position in order.products)
                {
                    positionsCount++;
                }
            }
            AllPositions.Content = positionsCount;
            int servicesCount = 0;
            foreach (var order in allPositions)
            {
                foreach (var position in order.services)
                {
                    servicesCount++;
                }
            }
            ServicesCount.Content= servicesCount;
            long AllSum = 0;
            foreach (var order in allPositions)
            {
                AllSum += order.Sum;
            }
            ALLSum.Content = AllSum;
        }
    }
}
