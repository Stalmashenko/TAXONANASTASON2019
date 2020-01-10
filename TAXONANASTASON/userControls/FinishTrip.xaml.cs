using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using BespokeFusion;
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
    /// Логика взаимодействия для FinishTrip.xaml
    /// </summary>
    public partial class FinishTrip : UserControl
    {
        public FinishTrip()
        {
            InitializeComponent();
        }
        TRIP Current;

        private void CheckInfo_Click(object sender, RoutedEventArgs e)
        {
            using (Context db = new Context())
            {
                var CurTrip = db.TRIP.Where(p => p.Status.Status == "ЗАВЕРШЕНА" && p.ClientId == App.currentUser.ClientId && p.Rating == 0).FirstOrDefault();

                if (CurTrip != null)
                {
                    Current = CurTrip;
                    var TaxiDriver = db.DRIVER.Where(p => p.Id == CurTrip.DriverId).FirstOrDefault();

                    Driver.Text = TaxiDriver.Surname + " " + TaxiDriver.Firstname;
                    Car.Text = TaxiDriver.Car.TypeModel + " " + TaxiDriver.Car.CarModel.Model;
                    FromAddress.Text = CurTrip.FromAddress.Street.Street + " " + CurTrip.FromAddress.House.ToString();
                    ToAddress.Text = CurTrip.ToAddress.Street.Street + " " + CurTrip.ToAddress.House.ToString();
                    Sum.Text = CurTrip.Summa.ToString();
                    Status.Text = "ЗАВЕРШЕНА";

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
                    RaitingPanel.Visibility = Visibility.Visible;
                }
                else
                {
                    MaterialMessageBox.ShowError("Законченная поездка не найдена. \nОжидайте, когда водитель завершит поездку. \nНу или заказывайте такси прямо сейчас! :)");
                }
            }
        }

        private void RateTrip_Click(object sender, RoutedEventArgs e)
        {
            using (Context db = new Context())
            {
                var CurTrip = db.TRIP.Where(p => p.Status.Status == "ЗАВЕРШЕНА" && p.ClientId == App.currentUser.ClientId && p.Rating == 0).FirstOrDefault();
                if(CurTrip != null)
                {
                    CurTrip.Rating = Rating.Value;
                    db.SaveChanges();
                    MaterialMessageBox.ShowError("Cпасибо за то, что оценили поездку! Будем рады видеть Вас еще!");

                }
                else
                {
                    MaterialMessageBox.ShowError("Не получилось оценить поездку. Попробуйте снова позже!");
                }
            }
        }
    }
}
