using System;
using System.Collections.Generic;
using System.Linq;
using BespokeFusion;
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
using TAXONANASTASON.Models;
using System.Data.Entity.Validation;

namespace TAXONANASTASON.userControls
{
    /// <summary>
    /// Логика взаимодействия для CreateTrip.xaml
    /// </summary>
    public partial class CreateTrip : UserControl
    {
        public CreateTrip()
        {
            InitializeComponent();
        }
        public static DRIVER Driver { get; set; }
        TRIP newTrip = new TRIP();
        private double Distance()
        {
            Random random = new Random();
            return random.Next(300, 3000) / 100.0;
        }
        private double GetRandomSumComfort()
        {
            Random random = new Random();
            return random.Next(400, 2900) / 100.0;
        }
        private double GetRandomSumStandart()
        {
            Random random = new Random();
            return random.Next(600, 5000) / 100.0;
        }
        private double GetRandomSumElite()
        {
            Random random = new Random();
            return random.Next(1000, 8000) / 100.0;
        }
        private void AddTrip_Loaded(object sender, RoutedEventArgs e)
        {
            using (Context db = new Context())
            {
                int[] Number = Enumerable.Range(1, 100).ToArray();

                FromStreet.ItemsSource = db.STREET.OrderBy(p=>p.Street).ToList();
                FromStreet.DisplayMemberPath = "Street";
                FromHouse.ItemsSource = Number;

                ToStreet.ItemsSource = db.STREET.OrderBy(p => p.Street).ToList();
                ToStreet.DisplayMemberPath = "Street";
                ToHouse.ItemsSource = Number;

                FromStreet.SelectedIndex = 0;
                ToStreet.SelectedIndex = 0;
                ToHouse.SelectedIndex = 0;
                FromHouse.SelectedIndex = 0;

            }
        }

        private void OrderTrip_Click(object sender, RoutedEventArgs e)
        {            
            if (DriverSurname.Text!=String.Empty && DriverFirstname.Text != String.Empty && ModelCar.Text!=String.Empty && FirmCar.Text != String.Empty && Sum.Text != String.Empty)
            {
                ADDRESS FromAdd = new ADDRESS()
                {
                    House = FromHouse.SelectedItem.ToString(),
                    StreetId = ((STREET)FromStreet.SelectedItem).Id,
                };
                ADDRESS toAdd = new ADDRESS()
                {
                    House = ToHouse.SelectedItem.ToString(),
                    StreetId = ((STREET)ToStreet.SelectedItem).Id,
                };
                DateTime curDate = DateTime.Now;

                newTrip.StartDate = curDate.ToString();
                newTrip.Summa = Convert.ToDouble(Sum.Text);
                newTrip.Distance = Distance();
                newTrip.ClientId = App.currentUser.Client.Id;
                newTrip.DriverId = Driver.Id;
                newTrip.ToAddress = toAdd;
                newTrip.FromAddress = FromAdd;
                newTrip.StatusId = 1;

                using (Context db = new Context())
                {
                    db.TRIP.Add(newTrip);
                    db.SaveChanges();

                    DriverSurname.Text = "";
                    DriverFirstname.Text = "";
                    ModelCar.Text = "";
                    FirmCar.Text = "";
                    Sum.Text = "";
                    FromStreet.SelectedIndex = 0;
                    ToStreet.SelectedIndex = 0;
                    ToHouse.SelectedIndex = 0;
                    FromHouse.SelectedIndex = 0;

                    var ChangeDriverStatus = db.DRIVER.Where(p=>p.Id==Driver.Id).FirstOrDefault();
                    if (ChangeDriverStatus!=null)
                    {

                        //ChangeDriverStatus.StatusId = 2;
                        //db.SaveChanges();
                        MaterialMessageBox.Show("Статус водителя изменен" + ChangeDriverStatus.Surname);                       
                    }
                    else
                    {
                        MaterialMessageBox.ShowError("Ошибка при изменении статуса водителя");
                    }
                    
                    MaterialMessageBox.Show("Такси заказано! \nСовсем скоро водитель будет на месте! \nХорошей поездки!", "Заказ такси");
                }
            }
            else
            {
                MaterialMessageBox.ShowError("Прежде, чем заказать такси, выберите тариф!");

            }
        }

        private void Comfort_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (Context db = new Context())
                {
                    var Comfort = db.DRIVER.Where(p => p.Car.Tarif.Type == "КОМФОРТ" && p.StatusId == 1).FirstOrDefault();
                    if (Comfort != null)
                    {
                        Driver = Comfort;
                        DriverSurname.Text = Driver.Surname;
                        DriverFirstname.Text = Driver.Firstname;
                        ModelCar.Text = Driver.Car.TypeModel;
                        FirmCar.Text = Driver.Car.CarModel.Model;
                        Sum.Text = (GetRandomSumComfort()).ToString();
                        newTrip.Tarif = "КОМФОРТ";
                    }
                    else
                    {
                        MaterialMessageBox.ShowError("Все водители тарифа КОМФОРТ заняты. \nПопробуйте снова через несколько минут или же выберите другой тариф!");
                    }
                }
            }
            catch (Exception ex)
            {
                MaterialMessageBox.ShowError(ex.Message);
            }           
            
        }

        private void Standart_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (Context db = new Context())
                {
                    var Standart = db.DRIVER.Where(p => p.Car.Tarif.Type == "СТАНДАРТ" && p.StatusId == 1).FirstOrDefault();
                    if (Standart != null)
                    {
                        Driver = Standart;
                        DriverSurname.Text = Driver.Surname;
                        DriverFirstname.Text = Driver.Firstname;
                        ModelCar.Text = Driver.Car.TypeModel;
                        FirmCar.Text = Driver.Car.CarModel.Model;
                        Sum.Text = (GetRandomSumStandart()).ToString();
                        newTrip.Tarif = "СТАНДАРТ";
                    }
                    else
                    {
                        MaterialMessageBox.ShowError("Все водители тарифа СТАНДАРТ заняты. \nПопробуйте снова через несколько минут или же выберите другой тариф!");
                    }
                }
            }
            catch (Exception ex)
            {
                MaterialMessageBox.ShowError(ex.Message);
            }
        }

        private void Elite_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (Context db = new Context())
                {
                    var Elite = db.DRIVER.Where(p => p.Car.Tarif.Type == "ЭЛИТ" && p.StatusId == 1).FirstOrDefault();
                    if (Elite != null)
                    {
                        Driver = Elite;
                        DriverSurname.Text = Driver.Surname;
                        DriverFirstname.Text = Driver.Firstname;
                        ModelCar.Text = Driver.Car.TypeModel;
                        FirmCar.Text = Driver.Car.CarModel.Model;
                        Sum.Text = (GetRandomSumElite()).ToString();
                        newTrip.Tarif = "ЭЛИТ";
                    }
                    else
                    {
                        MaterialMessageBox.ShowError("Все водители тарифа ЭЛИТ заняты. \nПопробуйте снова через несколько минут или же выберите другой тариф!");
                    }
                }
            }
            catch (Exception ex)
            {
                MaterialMessageBox.ShowError(ex.Message);
            }
        }
    }
}
