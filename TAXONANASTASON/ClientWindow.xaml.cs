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
    /// Логика взаимодействия для ClientWindow.xaml
    /// </summary>
    public partial class ClientWindow : Window
    {
        public ClientWindow()
        {
            InitializeComponent();
        }
        private void ButtonPopUpLogout_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ClientWin_Loaded(object sender, RoutedEventArgs e)
        {
            YourName.Text = App.currentUser.Client.Firstname;
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

        private void MyProfileButton_ChangePassword_Click(object sender, RoutedEventArgs e)
        {
            HeaderWork.Text = "Изменение пароля";
            ucChangePassword.Visibility = Visibility.Visible;
            ucMyProfile.Visibility = Visibility.Hidden;
            ucTrip.Visibility = Visibility.Hidden;
            ucCurTrip.Visibility = Visibility.Hidden;
            ucHistory.Visibility = Visibility.Hidden;
            ucLastTrip.Visibility = Visibility.Hidden;

        }

        private void MyProfileButton_Click(object sender, RoutedEventArgs e)
        {
            HeaderWork.Text = "Мои профиль";
            ucMyProfile.Visibility = Visibility.Visible;
            ucChangePassword.Visibility = Visibility.Hidden;
            ucTrip.Visibility = Visibility.Hidden;
            ucCurTrip.Visibility = Visibility.Hidden;
            ucHistory.Visibility = Visibility.Hidden;
            ucLastTrip.Visibility = Visibility.Hidden;

        }

        private void MyTripButton_Click(object sender, RoutedEventArgs e)
        {
            HeaderWork.Text = "Заказать такси";
            ucTrip.Visibility = Visibility.Visible;
            ucChangePassword.Visibility = Visibility.Hidden;
            ucMyProfile.Visibility = Visibility.Hidden;
            ucHistory.Visibility = Visibility.Hidden;
            ucCurTrip.Visibility = Visibility.Hidden;
            ucLastTrip.Visibility = Visibility.Hidden;

        }

        private void MyHistoryButton_Click(object sender, RoutedEventArgs e)
        {
            HeaderWork.Text = "Моя история";
            ucHistory.Visibility = Visibility.Visible;
            ucChangePassword.Visibility = Visibility.Hidden;
            ucMyProfile.Visibility = Visibility.Hidden;
            ucTrip.Visibility = Visibility.Hidden;
            ucCurTrip.Visibility = Visibility.Hidden;
            ucLastTrip.Visibility = Visibility.Hidden;

        }

        private void MyCurTripButton_Click(object sender, RoutedEventArgs e)
        {
            HeaderWork.Text = "Текущая поездка";
            ucCurTrip.Visibility = Visibility.Visible;
            ucHistory.Visibility = Visibility.Hidden;
            ucChangePassword.Visibility = Visibility.Hidden;
            ucMyProfile.Visibility = Visibility.Hidden;
            ucTrip.Visibility = Visibility.Hidden;
            ucLastTrip.Visibility = Visibility.Hidden;
        }

        private void MyLastTripButton_Click(object sender, RoutedEventArgs e)
        {
            ucCurTrip.Visibility = Visibility.Hidden;
            ucHistory.Visibility = Visibility.Hidden;
            ucChangePassword.Visibility = Visibility.Hidden;
            ucMyProfile.Visibility = Visibility.Hidden;
            ucTrip.Visibility = Visibility.Hidden;
            ucLastTrip.Visibility = Visibility.Visible;
        }
    }
}
