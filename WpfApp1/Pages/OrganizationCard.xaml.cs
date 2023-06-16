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

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для OrganizationCard.xaml
    /// </summary>
    public partial class OrganizationCard : Page
    {
        public DBSession _dBSession;

        public OrganizationCard(DBSession dBSession)
        {
            _dBSession = dBSession;
            InitializeComponent();
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SelectionPageSeller(_dBSession));
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
