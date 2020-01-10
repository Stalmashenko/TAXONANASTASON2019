using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TAXONANASTASON.Models;
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

namespace TAXONANASTASON.adminControls
{
    /// <summary>
    /// Логика взаимодействия для CreateDriver.xaml
    /// </summary>
    public partial class CreateDriver : UserControl
    {
        public CreateDriver()
        {
            InitializeComponent();
        }
        private double GetRandomBalance()
        {
            Random random = new Random();
            return random.Next(1, 999999) / 100.0;
        }

        private void AddDriver_Loaded(object sender, RoutedEventArgs e)
        {            
            using (Context db = new Context())
            {
                
                CarCompany.ItemsSource = db.CAR_MODEL.ToList();
                CarCompany.DisplayMemberPath = "Model";

                CarTarif.ItemsSource = db.TARIF.ToList();
                CarTarif.DisplayMemberPath = "Type";

                CarTarif.SelectedIndex = 0;
                CarCompany.SelectedIndex = 0;

            }
        }

        private void AddDriverButton_Click(object sender, RoutedEventArgs e)
        {
            Validation check = new Validation();

            CAR newCar = new CAR()
            {
                TypeModel = CarModel.Text,
                TarifId = ((TARIF)CarTarif.SelectedItem).Id,
                CarModelId = ((CAR_MODEL)CarCompany.SelectedItem).Id
            };
            DRIVER newDriver = new DRIVER()
            {
                Surname = DriverSurname.Text,
                Firstname = DriverFirstname.Text,
                Fathersname = DriverFatherName.Text,
                Card = DriverCard.Text,
                Phone = DriverPhone.Text,
                Balance = GetRandomBalance(),
                Car = newCar,
                StatusId = 1
            };
            USER newUser = new USER()
            {
                Login = DriverLogin.Text,
                Driver = newDriver,
                Role = "Driver"
            };
            if (DriverPassword.Password != string.Empty)
            {
                newUser.Password = DriverPassword.Password.GetHashCode().ToString();
            }
            if (check.CheckValid(newDriver) && check.CheckValid(newUser))
            {
                using (Context db = new Context())
                {
                    var someUser = db.USER.FirstOrDefault(u => u.Login == DriverLogin.Text);
                    if (someUser == null)
                    {
                        var phoneNumClient = db.CLIENT.FirstOrDefault(u => u.Phone == DriverPhone.Text);
                        var phoneNumDriver = db.DRIVER.FirstOrDefault(u => u.Phone == DriverPhone.Text);

                        if (phoneNumClient == null && phoneNumDriver == null)
                        {
                            db.USER.Add(newUser);
                            db.SaveChanges();

                            DriverLogin.Text = "";
                            DriverPassword.Password = "";
                            DriverSurname.Text = "";
                            DriverFirstname.Text = "";
                            DriverFatherName.Text = "";
                            DriverCard.Text = "";
                            DriverPhone.Text = "";
                            CarModel.Text = "";

                            MaterialMessageBox.Show("Регистрация прошла успешно. Водитель создан!", "Создание водителя");
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
