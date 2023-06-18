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
            ListAddInfo();
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminSelectionPage(_dBSession));
        }

        private void AddCategory_Click(object sender, RoutedEventArgs e)
        {
            var categoryBD = _dBSession.categories.SingleOrDefault(p => p.Name == AddNameCategoty.Text);
            if (categoryBD == null)
            {
                Models.Category category = new Models.Category()
                {
                    Name = AddNameCategoty.Text
                };
                _dBSession.categories.Add(category);
                _dBSession.SaveChanges();
                MessageBox.Show("Создана новая категория.");
                NavigationService.Navigate(new Category(_dBSession));
            }
        }
        private void EditCategory(object sender, RoutedEventArgs e)
        {
            var categoryListView = (Models.Category)((Button)sender).DataContext;
            var categoryBD = _dBSession.categories.SingleOrDefault(p => p.Name == categoryListView.Name);
            _dBSession.categories.Remove(categoryBD); 
            _dBSession.SaveChanges();
            ListAddInfo();
        }
        public void ListAddInfo()
        {
            
            if (_dBSession != null)
            {
                var categories = _dBSession.categories.ToList();
                foreach (var category in categories)
                {
                    listUsers.Items.Add(category);
                }
            }
        }

        private void listUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var categoryListView = (Models.Category)listUsers.SelectedItem;
            if (categoryListView != null)
            {
                var categoryBD = _dBSession.categories.SingleOrDefault(p => p.Name == categoryListView.Name);
                if (categoryBD.Visebly == true)
                {
                    categoryBD.Visebly = false;
                }
                else
                    categoryBD.Visebly = true;
                _dBSession.SaveChanges();
            }
            NavigationService.Navigate(new Category(_dBSession));

        }
    }
}
