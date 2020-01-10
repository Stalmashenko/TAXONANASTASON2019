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
using System.Windows.Shapes;

namespace TAXONANASTASON
{
    /// <summary>
    /// Логика взаимодействия для DriverWindow.xaml
    /// </summary>
    public partial class DriverWindow : Window
    {
        public DriverWindow()
        {
            InitializeComponent();
        }

        private void DrivWin_Loaded(object sender, RoutedEventArgs e)
        {
            YourName.Text = App.currentUser.Driver.Surname;
        }

        private void ButtonPopUpLogout_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MyProfileButton_ChangePassword_Click(object sender, RoutedEventArgs e)
        {
            ucMyPassword.Visibility = Visibility.Visible;
            ucDriverProfile.Visibility = Visibility.Hidden;
            ucDriverHistory.Visibility = Visibility.Hidden;
            ucDriverCur.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ucDriverProfile.Visibility = Visibility.Visible;
            ucMyPassword.Visibility = Visibility.Hidden;
            ucDriverHistory.Visibility = Visibility.Hidden;
            ucDriverCur.Visibility = Visibility.Hidden;
        }

        private void MyProfileButton_Click(object sender, RoutedEventArgs e)
        {
            ucDriverProfile.Visibility = Visibility.Visible;
            ucMyPassword.Visibility = Visibility.Hidden;
            ucDriverHistory.Visibility = Visibility.Hidden;
            ucDriverCur.Visibility = Visibility.Hidden;
        }

        private void MyTripButton_Click(object sender, RoutedEventArgs e)
        {
            ucDriverCur.Visibility = Visibility.Visible;
            ucDriverHistory.Visibility = Visibility.Hidden;
            ucMyPassword.Visibility = Visibility.Hidden;
            ucDriverProfile.Visibility = Visibility.Hidden;
        }

        private void MyHistoryButton_Click(object sender, RoutedEventArgs e)
        {
            ucDriverHistory.Visibility = Visibility.Visible;
            ucMyPassword.Visibility = Visibility.Hidden;
            ucDriverProfile.Visibility = Visibility.Hidden;
            ucDriverCur.Visibility = Visibility.Hidden;
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
    }
}
