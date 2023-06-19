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
using WpfApp1.Pages.Buyer;

namespace WpfApp1.Pages.Admin
{
    /// <summary>
    /// Логика взаимодействия для AdminSelectionPage.xaml
    /// </summary>
    public partial class AdminSelectionPage : Page
    {
        DBSession _dBSession;
        public AdminSelectionPage(DBSession dBSession)
        {
            _dBSession = dBSession;

            InitializeComponent();
        }
        //Переход к странице позицый
        private void Produc_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProductsAll(_dBSession));
        }
        //переход к странице услуг
        private void Services_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ServicesAll(_dBSession));
        }
        //переход к странице заказов
        private void Orders_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OrdersAll(_dBSession));
        }
        //переход к странице позицый на модерации
        private void Basket_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PositionsMod(_dBSession));
        }
        //переход к странице статистики
        private void StatisticPurchase_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Statistic(_dBSession));
        }
        //Выход из страницы
        private void Return_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Login(_dBSession));
        }
        //Переход на страницу создания категорий
        private void Category_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Category(_dBSession));
        }
       
    }
}
