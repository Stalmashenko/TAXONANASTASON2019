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
using System.Xml.Serialization;
using System.IO;
using System.Data.Entity;

namespace TAXONANASTASON.adminControls
{
    /// <summary>
    /// Логика взаимодействия для CheckInfo.xaml
    /// </summary>
    public partial class CheckInfo : UserControl
    {
        public CheckInfo()
        {
            InitializeComponent();
        }

        private void AllTrip_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AllScroll.Visibility = Visibility.Visible;
                DataGridAllTrip.Items.Refresh();

                DataGridAllTrip.Visibility = Visibility.Visible;
                DataGridCurrentTrip.Visibility = Visibility.Hidden;
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.Message);
            }
        }

        private void CurrentTrip_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AllScroll.Visibility = Visibility.Hidden;
                DataGridCurrentTrip.Items.Refresh();

                DataGridAllTrip.Visibility = Visibility.Hidden;
                DataGridCurrentTrip.Visibility = Visibility.Visible;
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.Message);
            }
        }

        private void Information_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                using (Context db = new Context())
                {
                    db.CLIENT.Load();
                    db.DRIVER.Load();
                    db.CAR.Load();
                    db.ADDRESS.Load();
                    db.STREET.Load();
                   // db.TRIP_STATUS.Load();
                    

                    DataGridAllTrip.Items.Clear();
                    DataGridCurrentTrip.Items.Clear();

                    var trips = db.TRIP.OrderBy(p => p.Id);
                    DataGridAllTrip.ItemsSource = trips.ToList();

                    //var currentTrip = db.TRIP.Where(p => p.StatusId == 1);
                    //DataGridCurrentTrip.ItemsSource = currentTrip.ToList();
                }
            }
            catch (Exception ex)
            {
                MaterialMessageBox.ShowError("ОШИБКА: " + ex.Message);
            }
        }
    }
}
