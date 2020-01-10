using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BespokeFusion;
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

namespace TAXONANASTASON.userControls
{
    /// <summary>
    /// Логика взаимодействия для CurTrip.xaml
    /// </summary>
    public partial class CurTrip : UserControl
    {
        public CurTrip()
        {
            InitializeComponent();
        }

        private void CheckInfo_Click(object sender, RoutedEventArgs e)
        {
            using (Context db = new Context())
            {
                var CurTrip = db.TRIP.Where(p => p.Status.Status == "В ПРОЦЕССЕ" && p.ClientId == App.currentUser.ClientId).FirstOrDefault();
                if (CurTrip != null)
                {
                    var TaxiDriver = db.DRIVER.Where(p => p.Id == CurTrip.DriverId).FirstOrDefault();

                    Driver.Text = TaxiDriver.Surname + " " + TaxiDriver.Firstname;
                    Car.Text = TaxiDriver.Car.TypeModel + " " + TaxiDriver.Car.CarModel.Model;
                    FromAddress.Text = CurTrip.FromAddress.Street.Street + " " + CurTrip.FromAddress.House.ToString();
                    ToAddress.Text = CurTrip.ToAddress.Street.Street + " " + CurTrip.ToAddress.House.ToString();
                    Sum.Text = CurTrip.Summa.ToString();
                    Status.Text = "В ПРОЦЕССЕ";

                    DriverText.Visibility = Visibility.Visible;
                    Driver.Visibility = Visibility.Visible;
                    Car.Visibility = Visibility.Visible;
                    CarText.Visibility = Visibility.Visible;
                    FromAddress.Visibility = Visibility.Visible;
                    FromText.Visibility = Visibility.Visible;
                    ToAddress.Visibility = Visibility.Visible;
                    ToText.Visibility = Visibility.Visible;
                    Sum.Visibility = Visibility.Visible;
                    SumText.Visibility = Visibility.Visible;    
                    StatusPanel.Visibility = Visibility.Visible;
                }
                else
                {
                    MaterialMessageBox.ShowError("Текущая поездка не найдена! \nЗакажи такси прямо сейчас, нажав на кнопку меню 'ЗАКАЗАТЬ ТАКСИ'. \nИ не забудь оценить поездку! С:");
                }
            }
        }
    }
}
