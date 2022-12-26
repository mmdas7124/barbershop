using barbershop.Core;
using barbershop.Model;
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

namespace barbershop.View.LoginPage
{
    /// <summary>
    /// Логика взаимодействия для MainWindowRegistratorPage.xaml
    /// </summary>
    public partial class MainWindowRegistratorPage : Page
    {
        public MainWindowRegistratorPage()
        {
            InitializeComponent();
        }
        private async void BtnRegistration_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbLogin.Text) ||
                string.IsNullOrEmpty(TbPassword.Text))
            {
                MessageBox.Show("Все поля должны быть заполнены!",
                                "Системное сообщение",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }
            else
            {
                if (FrameNavigate.DB.Users.Count(u => u.Login == TbLogin.Text) > 0)
                {
                    MessageBox.Show("Пользователь с такими инициалами уже зарегестрирован!",
                                    "Системное сообщение",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Error);
                }
                FrameNavigate.DB.Users.Add(new Users
                {
                    Login = TbLogin.Text,
                    Password = TbPassword.Text,
                    RoleID = 2
                });
                try
                {
                    await FrameNavigate.DB.SaveChangesAsync();
                    MessageBox.Show("Учетная запись создана!",
                               "Системное сообщение",
                               MessageBoxButton.OK,
                               MessageBoxImage.Information);
                    FrameNavigate.FrameObject.Navigate(new MainWindowLoginPage());
                }
                catch
                {

                }

            }
        }

      

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigate.FrameObject.Navigate(new MainWindowLoginPage());
        }
    }
}
