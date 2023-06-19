using System;
using System.Collections.Generic;
using System.IO;
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
using WpfApp1.Pages.Admin;
using WpfApp1.Pages.Seller;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        DBSession _dBSession;
        public Login(DBSession dBSession)
        {
            _dBSession = dBSession;
            CheckBD();
            InitializeComponent();

        }

        private void Input_Click(object sender, RoutedEventArgs e)
        {
            var admin=_dBSession.admins.SingleOrDefault(p=>p.Login==BoxLogin.Text);
            var seller=_dBSession.sellers.SingleOrDefault(p=> p.Phone == BoxLogin.Text);
            var buyer = _dBSession.buyers.SingleOrDefault(p => p.Phone == BoxLogin.Text);
            if (buyer != null)
            {
                if (BoxPassword.Text == buyer.Password)
                { 
                    NavigationService.Navigate(new SelectionPageBuyer(_dBSession,buyer)); 
                }
                else
                    MessageBox.Show("Неправильный пароль!");
            }
            else if (seller != null )
            {
                if (BoxPassword.Text == seller.Password)
                {
                    NavigationService.Navigate(new SelectionPageSeller(_dBSession,seller));
                }
                else
                    MessageBox.Show("Неправильный пароль!");
            }
            else if (admin != null)
            {
                if(BoxPassword.Text == admin.Password)
                {
                    NavigationService.Navigate(new AdminSelectionPage(_dBSession));
                }
            }
            else
                MessageBox.Show("Нет пользователя!");
        }

        private void Registered_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Registered(_dBSession));
        }

        public void CheckBD()
        {
            if (_dBSession!=null)
            {
                List<string> list = new List<string>();
                using (StreamReader reader = new StreamReader("Settings.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        list.Add(reader.ReadLine());
                    }
                }
                var adminDB = _dBSession.admins.ToList();
                if (adminDB.Count() == 0)
                {

                    Models.Admin admin = new Models.Admin()
                    {
                        Name = list[0],
                        Login = list[1],
                        Password = list[2]
                    };
                    _dBSession.admins.Add(admin);
                    _dBSession.SaveChanges();

                }
                var statusDB = _dBSession.status.ToList();
                if (statusDB.Count() == 0)
                {
                    for (int i = 3; i < 6; i++)
                    {
                        Status status = new Status()
                        {
                            Name = list[3]
                        };
                        _dBSession.status.Add(status);
                    }
                    _dBSession.SaveChanges();
                }
            }
        }
    }
}
