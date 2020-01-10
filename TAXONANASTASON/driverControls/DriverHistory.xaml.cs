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
using System.Data.Entity;

namespace TAXONANASTASON.driverControls
{
    /// <summary>
    /// Логика взаимодействия для DriverHistory.xaml
    /// </summary>
    public partial class DriverHistory : UserControl
    {
        public DriverHistory()
        {
            InitializeComponent();
        }

        private void DriverHistoryButton_Click(object sender, RoutedEventArgs e)
        {
            DataGridTrip.Visibility = Visibility.Visible;
            try
            {
                using (Context db = new Context())
                {
                    db.CLIENT.Load();
                    db.DRIVER.Load();
                    db.CAR.Load();
                    db.ADDRESS.Load();
                    db.STREET.Load();

                    DataGridTrip.ItemsSource = null;

                    var trip = db.TRIP.Where(p => p.DriverId == App.currentUser.Driver.Id);
                    DataGridTrip.ItemsSource = trip.ToList();
                }
            }
            catch (Exception ex)
            {
                MaterialMessageBox.ShowError("ОШИБКА: " + ex.Message);
            }
        }
    }
}
