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
using TAXONANASTASON.Models;
using System.Windows.Shapes;

namespace TAXONANASTASON
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }
        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }
        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonPopUpLogout_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void AdminWin_Loaded(object sender, RoutedEventArgs e)
        {
            YourName.Text = App.admin.Client.Firstname;
        }

        private void MyProfileButton_Click(object sender, RoutedEventArgs e)
        {
            ucMyProfile.Visibility = Visibility.Visible;
            ucMyPassword.Visibility = Visibility.Hidden;
            ucAddDriver.Visibility = Visibility.Hidden;
            ucAddAdmin.Visibility = Visibility.Hidden;
            ucInfo.Visibility = Visibility.Hidden;
            ucUSERS.Visibility = Visibility.Hidden;
        }

        private void ChangePassword_Click(object sender, RoutedEventArgs e)
        {
            ucMyPassword.Visibility = Visibility.Visible;
            ucMyProfile.Visibility = Visibility.Hidden;
            ucAddDriver.Visibility = Visibility.Hidden;
            ucAddAdmin.Visibility = Visibility.Hidden;
            ucInfo.Visibility = Visibility.Hidden;
            ucUSERS.Visibility = Visibility.Hidden;
        }

        private void CreateAdmin_Click(object sender, RoutedEventArgs e)
        {
            ucAddAdmin.Visibility = Visibility.Visible;
            ucMyPassword.Visibility = Visibility.Hidden;
            ucMyProfile.Visibility = Visibility.Hidden;
            ucAddDriver.Visibility = Visibility.Hidden;
            ucInfo.Visibility = Visibility.Hidden;
            ucUSERS.Visibility = Visibility.Hidden;
        }

        private void CreateDriver_Click(object sender, RoutedEventArgs e)
        {
            ucAddDriver.Visibility = Visibility.Visible;
            ucMyPassword.Visibility = Visibility.Hidden;
            ucMyProfile.Visibility = Visibility.Hidden;
            ucAddAdmin.Visibility = Visibility.Hidden;
            ucInfo.Visibility = Visibility.Hidden;
            ucUSERS.Visibility = Visibility.Hidden;
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            ucInfo.Visibility = Visibility.Visible;
            ucAddDriver.Visibility = Visibility.Hidden;
            ucMyPassword.Visibility = Visibility.Hidden;
            ucMyProfile.Visibility = Visibility.Hidden;
            ucAddAdmin.Visibility = Visibility.Hidden;
            ucUSERS.Visibility = Visibility.Hidden;
        }

        private void XML_Click(object sender, RoutedEventArgs e)
        {
            ucXML.Visibility = Visibility.Visible;
            ucInfo.Visibility = Visibility.Hidden;
            ucAddDriver.Visibility = Visibility.Hidden;
            ucMyPassword.Visibility = Visibility.Hidden;
            ucMyProfile.Visibility = Visibility.Hidden;
            ucAddAdmin.Visibility = Visibility.Hidden;
            ucUSERS.Visibility = Visibility.Hidden;
        }

        private void Trips_Click(object sender, RoutedEventArgs e)
        {
            ucUSERS.Visibility = Visibility.Visible;
            ucXML.Visibility = Visibility.Hidden;
            ucInfo.Visibility = Visibility.Hidden;
            ucAddDriver.Visibility = Visibility.Hidden;
            ucMyPassword.Visibility = Visibility.Hidden;
            ucMyProfile.Visibility = Visibility.Hidden;
            ucAddAdmin.Visibility = Visibility.Hidden;
        }
    }
}
