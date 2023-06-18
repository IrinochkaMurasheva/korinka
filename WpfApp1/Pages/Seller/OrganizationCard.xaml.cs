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

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для OrganizationCard.xaml
    /// </summary>
    public partial class OrganizationCard : Page
    {
        public DBSession _dBSession;
        public Models.Seller _Seller;

        public OrganizationCard(DBSession dBSession, Models.Seller seller)
        {
            _dBSession = dBSession;
            _Seller = seller;
            InitializeComponent();
            loadCard();
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SelectionPageSeller(_dBSession,_Seller));
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            _Seller.Name = OrganizationName.Text;
            _Seller.INN = OrganizationINN.Text;
            _Seller.OGRN = OrganizationOGRN.Text;
            _Seller.Phone = PhoneNumber.Text;
            _Seller.Password = OrganizationPassword.Text;
            _dBSession.SaveChanges();
        }
        public void loadCard()
        {
            OrganizationName.Text=_Seller.Name;
            OrganizationINN.Text= _Seller.INN;
            PhoneNumber.Text= _Seller.Phone;
            OrganizationOGRN.Text = _Seller.OGRN;
            OrganizationPassword.Text= _Seller.Password;
        }
    }
}
