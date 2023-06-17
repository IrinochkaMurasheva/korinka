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

namespace WpfApp1.Pages.Admin
{
    /// <summary>
    /// Логика взаимодействия для Category.xaml
    /// </summary>
    public partial class Category : Page
    {
        DBSession _dBSession;

        public Category(DBSession dBSession)
        {
            _dBSession = dBSession;
            InitializeComponent();
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminSelectionPage(_dBSession));
        }

        private void AddCategory_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Category(_dBSession));
        }
    }
}
