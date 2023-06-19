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
    /// Страница регистрации покупателей
    /// </summary>
    public partial class RegisteredBuyer : Page
    {
        DBSession _dBSession;
        public RegisteredBuyer(DBSession dBSession)
        {
            _dBSession = dBSession;
            InitializeComponent();
            
        }
        //создание покупателя
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Models.Buyer buyer = new Models.Buyer()
            {
                Surname = Surname.Text,
                Name = Name.Text,
                Patronymic = Patronymic.Text,
                Password = Password.Text,
                Phone = Phone.Text
            };
            _dBSession.buyers.Add(buyer);
            _dBSession.SaveChanges();
            NavigationService.Navigate(new Login(_dBSession));
        }
        //возврат
        private void Return_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Login(_dBSession));
        }
    }
}
