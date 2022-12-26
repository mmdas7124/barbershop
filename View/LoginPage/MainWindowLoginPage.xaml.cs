using barbershop.Core;
using barbershop.Model;
using barbershop.View.EmployerPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
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
    /// Логика взаимодействия для MainWindowLoginPage.xaml
    /// </summary>
    public partial class MainWindowLoginPage : Page
    {
        public MainWindowLoginPage()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Users userModel = FrameNavigate.DB.Users.FirstOrDefault(u =>
                u.Login == TbLogin.Text && u.Password == PsbPassword.Password);

                if (userModel == null)
                {
                    MessageBox.Show("Ошибка данных",
                                    "Системное сообщение",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Error);
                }

                else
                {

                    switch (userModel.RoleID)
                    {
                        case 1:
                            FrameNavigate.FrameObject.Navigate(new AdministratorPage.AdministratorPage());
                            break;
                        case 2:
                            FrameNavigate.FrameObject.Navigate(new UserPage.UserPage());
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),
                               "Системная ошибка",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

            }
        }
        private void Btnwork_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigate.FrameObject.Navigate(new EmployerPage.MainEmployerPage());
        }

        private void BtnRegistration_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigate.FrameObject.Navigate(new MainWindowRegistratorPage());
        }
    }
    
}
