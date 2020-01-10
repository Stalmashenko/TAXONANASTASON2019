using BespokeFusion;
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

namespace TAXONANASTASON.driverControls
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
                var CurTrip = db.TRIP.Where(p => p.Status.Status == "В ПРОЦЕССЕ" && p.DriverId == App.currentUser.DriverId).FirstOrDefault();
                if (CurTrip != null)
                {

                    var TaxiClient = db.CLIENT.Where(p => p.Id == CurTrip.ClientId).FirstOrDefault();

                    Client.Text = TaxiClient.Surname + " " + TaxiClient.Firstname;
                    FromAddress.Text = CurTrip.FromAddress.Street.Street + " " + CurTrip.FromAddress.House.ToString();
                    ToAddress.Text = CurTrip.ToAddress.Street.Street + " " + CurTrip.ToAddress.House.ToString();
                    Sum.Text = CurTrip.Summa.ToString();
                    Status.Text = "В ПРОЦЕССЕ";

                    TripInfo.Visibility = Visibility.Visible;
                    StatusPanel.Visibility = Visibility.Visible;
                    EndTrip.Visibility = Visibility.Visible;
                }
                else
                {
                    MaterialMessageBox.ShowError("Текущая поездка не найдена! \nОжидайте своих клиентов!");
                }
            }
        }

        private void EndTrip_Click(object sender, RoutedEventArgs e)
        {
            using (Context db = new Context())
            {
                var CurTrip = db.TRIP.Where(p => p.Status.Status == "В ПРОЦЕССЕ" && p.DriverId == App.currentUser.DriverId).FirstOrDefault();
                if (CurTrip != null)
                {
                    TripInfo.Visibility = Visibility.Hidden;
                    StatusPanel.Visibility = Visibility.Hidden;
                    EndTrip.Visibility = Visibility.Hidden;

                    var curClient = db.CLIENT.Where(p => p.Id == CurTrip.ClientId).FirstOrDefault();
                    var curDriver = db.DRIVER.Where(p => p.Id == CurTrip.DriverId).FirstOrDefault();
                    curClient.Balance -= CurTrip.Summa;
                    curDriver.StatusId = 1;
                    CurTrip.StatusId = 2;
                    DateTime curDate = DateTime.Now;
                    CurTrip.FinishDate = curDate.ToString();
                    db.SaveChanges();
                    MaterialMessageBox.Show("Поездка завершена! \nТранзакция прошла успешно!");
                }
                else
                {
                    MaterialMessageBox.ShowError("Ошибка");
                }
            }
        }
    }
}
