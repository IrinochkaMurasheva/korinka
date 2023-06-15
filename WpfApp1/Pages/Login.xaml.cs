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
using WpfApp1.Pages;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();

        }

        private void Input_Click(object sender, RoutedEventArgs e)
        {
            if (BoxLogin.Text == "Buyer")
            {
                NavigationService.Navigate(new SelectionPageBuyer());
            }
            else if (BoxLogin.Text == "Seller")
            {
                NavigationService.Navigate(new SelectionPageSeller());
            }
            else
                MessageBox.Show("Нет пользователя!");
        }
    }
}
