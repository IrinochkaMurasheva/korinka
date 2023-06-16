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
    /// </summary>
    public partial class SelectionPageBuyer : Page
    {
        readonly DBSession _dBSession;
        public SelectionPageBuyer(DBSession dBSession)
        {
            _dBSession=dBSession;
            InitializeComponent();
        }

        private void Services_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Basket_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Orders_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Produc_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
