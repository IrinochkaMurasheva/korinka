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
using WpfApp1.Pages;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        readonly DBSession _dBSession;
        public Login(DBSession dBSession)
        {
            _dBSession = dBSession;
            InitializeComponent();

        }

        private void Input_Click(object sender, RoutedEventArgs e)
        {
            if (BoxLogin.Text == "Buyer")
            {
                NavigationService.Navigate(new SelectionPageBuyer(_dBSession));
            }
            else if (BoxLogin.Text == "Seller")
            {
                NavigationService.Navigate(new SelectionPageSeller(_dBSession));
            }
            else
                MessageBox.Show("Нет пользователя!");
        }
    }
}
