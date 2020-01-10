using System;
using BespokeFusion;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TAXONANASTASON.Models;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;

namespace TAXONANASTASON.userControls
{
    /// <summary>
    /// Логика взаимодействия для History.xaml
    /// </summary>
    public partial class History : UserControl
    {
        public History()
        {
            InitializeComponent();
        }

        private void MyHistoryButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (Context db = new Context())
                {
                    Scroll.Visibility = Visibility.Visible;
                    db.CLIENT.Load();
                    db.DRIVER.Load();
                    db.CAR.Load();
                    db.ADDRESS.Load();
                    db.STREET.Load();
                    DataGridTrip.ItemsSource = null;
                    var trip = db.TRIP.Where(p => p.ClientId == App.currentUser.Client.Id);
                    DataGridTrip.ItemsSource = trip.ToList();
                    DataGridTrip.Visibility = Visibility.Visible;
                }

            }
            catch (Exception ex)
            {
                MaterialMessageBox.ShowError(ex.Message);
            }
        }
    }
}
