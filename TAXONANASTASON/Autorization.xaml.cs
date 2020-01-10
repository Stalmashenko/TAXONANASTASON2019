using System;
using TAXONANASTASON.Models;
using BespokeFusion;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
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
    /// Логика взаимодействия для Autorization.xaml
    /// </summary>
    public partial class Autorization : Window
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void entryButton_Click(object sender, RoutedEventArgs e)
        {
            if (PassBox.Password != String.Empty && LoginBox.Text != string.Empty)
            {
                using (Context db = new Context())
                {
                    string password = PassBox.Password.GetHashCode().ToString();
                    string login = LoginBox.Text;
                    var admin = db.USER.FirstOrDefault(x => x.Login == login && x.Password == password && x.Role == "Admin");
                    var user = db.USER.FirstOrDefault(x => x.Password == password && x.Login == login && x.Role == "Client");
                    var driver = db.USER.FirstOrDefault(x => x.Password == password && x.Login == login && x.Role == "Driver");
                    if (admin != null && user == null && driver == null)
                    {
                        AdminWindow adminWin = new AdminWindow();                    
                        App.admin = admin;
                        adminWin.Show();
                        Close();
                    }

                    if (user != null && admin == null && driver== null)
                    {
                        ClientWindow clientWin = new ClientWindow();
                        App.currentUser = user;
                        clientWin.Show();
                        Close();
                    }

                    if (driver != null && user == null && admin == null)
                    {
                        DriverWindow driverWin = new DriverWindow();
                        App.currentUser = driver;
                        driverWin.Show();
                        Close();
                    }
                    if (driver == null && user == null && admin == null)
                    {
                        MaterialMessageBox.ShowError("Пользователь не найден. Введите данные заново!");
                    }

                }
            }
            else
            {
                MaterialMessageBox.ShowError("Введите данные!");
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Close();
            mainWindow.Show();
        }
    }
}
