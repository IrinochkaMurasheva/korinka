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
    /// Логика взаимодействия для создания услуги
    /// </summary>
    public partial class AddServices : Page
    {
        public DBSession _dBSession; 
        readonly Models.Seller _seller;

        public AddServices(DBSession dBSession,Models.Seller seller)
        {
            _dBSession = dBSession;
            _seller = seller;
            InitializeComponent();
        }
        // Сохранение данных введеных в UI для Services
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Models.Service service = new Service()
            {
                Name = ServiceName.Text,
                Price = int.Parse(ServicePrice.Text),
                Description = DescriptionService.Text,
                Moderation = false,
                Visibly = false,
                SellerId = _seller.Id
            };
            service.category = _dBSession.categories.SingleOrDefault(p => p.Name == CategoryBox.Name);
            _dBSession.services.Add(service);
            _dBSession.SaveChanges();
        }
        //Перенаправление на прошлую страницу
        private void Return_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SelectionPageSeller(_dBSession,_seller));
        }
        //загрузка категорий из БД
        public void addCategoryBox()
        {
            var categories = _dBSession.categories.ToList();
            foreach (var category in categories)
            {
                CategoryBox.Items.Add(category.Name);
            }
        }
    }
}
