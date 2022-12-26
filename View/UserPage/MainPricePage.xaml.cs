using barbershop.Core;
using barbershop.View.LoginPage;
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

namespace barbershop.View.UserPage
{
    /// <summary>
    /// Логика взаимодействия для MainPricePage.xaml
    /// </summary>
    public partial class MainPricePage : Page
    {
        public MainPricePage()
        {
            InitializeComponent();
        }
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigate.FrameObject.Navigate(new UserPage());
        }
    }
}
