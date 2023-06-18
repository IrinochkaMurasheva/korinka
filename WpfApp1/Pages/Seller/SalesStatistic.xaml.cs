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

namespace WpfApp1.Pages.Seller
{
    /// <summary>
    /// Логика взаимодействия для SalesStatistic.xaml
    /// </summary>
    public partial class SalesStatistic : Page
    {
        readonly DBSession _dBSession;
        readonly Models.Seller _seller;

        public SalesStatistic(DBSession dBSession, Models.Seller seller)
        {
            _dBSession = dBSession;
            InitializeComponent();
            _seller = seller;
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SelectionPageSeller(_dBSession, _seller));
        }
        public void StatisticLoad()
        {
            var services = _seller.Services.ToList();
            var products = _seller.Products.ToList();
            var OrdersDBAll= _dBSession.orders.Include(p => p.products).ToList();
            var ServicesDBAll = _dBSession.orders.Include(p => p.services).ToList();
            List<Order> orders = new List<Order>(); 
            foreach(var ordersDB in OrdersDBAll)
            {
                foreach (var product in products)
                {
                    if (ordersDB.products.Contains(product))
                    {
                        if(!orders.Contains(ordersDB))
                        {
                            orders.Add(ordersDB);
                        }
                    }
                }
            }
            foreach (var servicesDB in ServicesDBAll)
            {
                foreach (var service in services)
                {
                    if (servicesDB.services.Contains(service))
                    {
                        if (!orders.Contains(servicesDB))
                        {
                            orders.Add(servicesDB);
                        }
                    }
                }
            }
            AllOrders.Content = orders.Count();
            Complited.Content = orders.Where(p => p.status.Name == "Выполнен").Count();
            Canceled.Content = orders.Where(p => p.status.Name == "Отмена").Count();
            ToWork.Content = orders.Where(p => p.status.Name == "В работе").Count(); ;
            PositionsAll.Content = _seller.Products.Count();
            ServicesAll.Content = _seller.Services.Count();
            PositionsModern.Content = _seller.Products.Where(p=>p.Moderation==false);
            ServicesModern.Content = _seller.Services.Where(p => p.Moderation == false);
        }
    }
}
