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
using BespokeFusion;
using TAXONANASTASON.Models;

namespace TAXONANASTASON.adminControls
{
    /// <summary>
    /// Логика взаимодействия для CreateAdmin.xaml
    /// </summary>
    public partial class CreateAdmin : UserControl
    {
        public CreateAdmin()
        {
            InitializeComponent();
        }
        private double GetRandomBalance()
        {
            Random random = new Random();
            return random.Next(1, 999999) / 100.0;
        }
        private void AddAdminButton_Click(object sender, RoutedEventArgs e)
        {
            Validation check = new Validation();
            CLIENT newClient = new CLIENT()
            {
                Surname =  AdminSurname.Text,
                Firstname = AdminFirstname.Text,
                Card = AdminCard.Text,
                Phone = AdminPhone.Text,
                Balance = GetRandomBalance()
            };
            USER newUser = new USER()
            {
                Login =  AdminLogin.Text,
                Client = newClient, 
                Role = "Admin"
            };
            if (AdminPassword.Password != string.Empty)
            {
                newUser.Password = AdminPassword.Password.GetHashCode().ToString();
            }
            if (check.CheckValid(newClient) && check.CheckValid(newUser))
            {
                using (Context db = new Context())
                {
                    var someUser = db.USER.FirstOrDefault(u => u.Login == AdminLogin.Text);
                    if (someUser == null)
                    {
                        var DriverphoneNum = db.DRIVER.FirstOrDefault(u => u.Phone == AdminPhone.Text);
                        var ClientphoneNum = db.CLIENT.FirstOrDefault(u => u.Phone == AdminPhone.Text);
                        if (DriverphoneNum == null && ClientphoneNum == null)
                        {
                            db.USER.Add(newUser);
                            db.SaveChanges();

                            AdminLogin.Text = "";
                            AdminPassword.Password = "";
                            AdminSurname.Text = "";
                            AdminFirstname.Text = "";
                            AdminPhone.Text = "";
                            AdminCard.Text = "";

                            MaterialMessageBox.Show("Регистрация прошла успешно. Админ создан!", "Создание админа");
                        }
                        else
                        {
                            MaterialMessageBox.ShowError("Введенный номер телефона уже привязан к другому профилю. Попробуйте снова!");
                        }
                    }
                    else
                    {
                        MaterialMessageBox.ShowError("Пользователь с таким логином уже существует. Попробуйте снова!");
                    }
                }
            }
        }
    }
}
