using barbershop.Core;
using barbershop.Model;
using barbershop.View.UserPage;
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

namespace barbershop.View.AdministratorPage
{
    /// <summary>
    /// Логика взаимодействия для AdministratorPage.xaml
    /// </summary>
    public partial class AdministratorPage : Page
    {
        public AdministratorPage()
        {
            InitializeComponent();
            DataUserInfo.ItemsSource = FrameNavigate.DB.Users.OrderBy(u => u.Login).ToList();
        }
        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            int idUser = (DataUserInfo.SelectedItem as Users).UserID;
            var result = MessageBox.Show("Хотите удалить пользователя?",
                                         "Системное сообщение",
                                         MessageBoxButton.YesNo,
                                         MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Users user = (from u in FrameNavigate.DB.Users where u.UserID == idUser select u).SingleOrDefault();
                FrameNavigate.DB.Users.Remove(user);
                FrameNavigate.DB.SaveChanges();
                DataUserInfo.ItemsSource = FrameNavigate.DB.Users.OrderBy(u => u.Login).ToList();
            }
        }
    }
}
