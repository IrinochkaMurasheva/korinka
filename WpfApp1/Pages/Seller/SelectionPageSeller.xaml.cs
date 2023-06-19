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

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для SelectionPageSeller.xaml
    /// </summary>
    public partial class SelectionPageSeller : Page
    {
        readonly DBSession _dBSession;
        readonly Models.Seller _seller;
        public SelectionPageSeller(DBSession dBSession, Models.Seller seller)
        {
            _dBSession = dBSession;
            InitializeComponent();
            _seller = seller; 
        }
        //выход
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Login(_dBSession));
        }
        //карточка организации
        private void Organization_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OrganizationCard(_dBSession,_seller));
        }
        //добавление услуг
        private void AddServices_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddServices(_dBSession, _seller));
        }
        //остатки
        private void remains_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Remains(_dBSession, _seller));
        }
        //заказы
        private void Orders_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OrdersSeller(_dBSession, _seller));
        }
        //редактированире позицый
        private void EditProduct_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditProducts(_dBSession, _seller));
        }
        //редактирование услуг
        private void EditServices_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditServices(_dBSession, _seller));
        }
        //добавление позицый
        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddProduct(_dBSession, _seller));
        }
        //статистика
        private void SalesStatistic_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SalesStatistic(_dBSession, _seller));
        }
    }
}
