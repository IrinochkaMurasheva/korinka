﻿using System;
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
    /// Логика взаимодействия для EditServices.xaml
    /// </summary>
    public partial class EditServices : Page
    {
        readonly DBSession _dBSession;
        readonly Models.Seller _seller;

        public EditServices(DBSession dBSession, Models.Seller seller)
        {
            _dBSession = dBSession;
            InitializeComponent();
            _seller = seller;
            ListAddInfo();
        }
        //редактировать выбранную позицыю
        private void EditCategory(object sender, RoutedEventArgs e)
        {
            var service = (Models.Service)((Button)sender).DataContext;
            NavigationService.Navigate(new EditService(_dBSession, _seller, service));
        }
        //загрузка услуг
        public void ListAddInfo()
        {

            if (_dBSession != null)
            {
                var services = _dBSession.services.Where(p => p.SellerId == _seller.Id).ToList();
                foreach (var service in services)
                {
                    listUsers.Items.Add(service);
                }
            }
        }
    }
}
