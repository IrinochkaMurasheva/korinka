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
    /// Логика взаимодействия для Remains.xaml
    /// </summary>
    public partial class Remains : Page
    {
        readonly DBSession _dBSession;
        public Remains(DBSession dBSession)
        {
            _dBSession = dBSession;
            InitializeComponent();
        }
    }
}
