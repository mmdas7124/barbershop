﻿using barbershop;
using barbershop.View;
using barbershop.Core;
using barbershop.View.EmployerPage;
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
using barbershop.Model;

namespace barbershop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            FrameNavigate.FrameObject = MyFrame;
            FrameNavigate.DB = new barbershopEntities();
            MyFrame.Navigate(new MainWindowLoginPage());
        }



        private void Window_MouseDown(object sender, MouseEventArgs e)
        {
            DragMove();
        }

       

   


    }
}
