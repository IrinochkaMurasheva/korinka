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

namespace WpfApp1.Pages.Buyer
{
    /// <summary>
    /// Логика взаимодействия для StatisticPurchase.xaml
    /// </summary>
    public partial class StatisticPurchase : Page
    {
        readonly DBSession _dBSession;
        public StatisticPurchase(DBSession dBSession)
        {
            _dBSession = dBSession;
            InitializeComponent();
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SelectionPageBuyer(_dBSession));
        }
    }
}