using barbershop.Core;
using barbershop.Model;
using barbershop.View.LoginPage;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Web.Compilation;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace barbershop.View.UserPage
{
    /// <summary>
    /// Логика взаимодействия для UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        public UserPage()
        {
            InitializeComponent();
            ComboBoxServices.ItemsSource = FrameNavigate.DB.Services.OrderBy(u => u.Title).ToList();
            ComboBoxServices.ItemsSource = FrameNavigate.DB.Services.OrderBy(u => u.Price).ToList();
            ComboBoxPositions.ItemsSource = FrameNavigate.DB.Positions.OrderBy(u => u.Title).ToList();
        }



        private void BtnSign_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы записаны");
            if (string.IsNullOrEmpty(TbFullName.Text) ||
                string.IsNullOrEmpty(TbPhone.Text))
            {
                MessageBox.Show("Все поля должны быть заполнены!",
                                "Системное сообщение",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }
            


        }



        private void BtnPrice_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigate.FrameObject.Navigate(new MainPricePage());
        }
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigate.FrameObject.Navigate(new MainWindowLoginPage());
        }
    }
}
