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
    /// Логика взаимодействия для EditProduct.xaml
    /// </summary>
    public partial class EditService : Page
    {
        public DBSession _dBSession;
        readonly Models.Seller _seller;
        public Models.Service Service;
        public EditService(DBSession dBSession,Models.Seller seller,Models.Service service)
        {
            _dBSession = dBSession;
            _seller = seller;
            Service = service;
            InitializeComponent();
        }
        //заполнение данных из UI
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Service.Name = ServiceName.Text;
            Service.Price = int.Parse(ServiceName.Text);
            Service.Description = DescriptionService.Text;
            Service.Moderation = false;
            Service.Visibly = false;
            _dBSession.SaveChanges();
            MessageBox.Show("товар изменен.");
            NavigationService.Navigate(new EditServices(_dBSession, _seller));
        }
        //Возврат на предыдущую страницу
        private void Return_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditServices(_dBSession, _seller));
        }
    }
}
