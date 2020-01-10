using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using BespokeFusion;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Serialization;
using System.IO;

namespace TAXONANASTASON.adminControls
{
    /// <summary>
    /// Логика взаимодействия для users.xaml
    /// </summary>
    public partial class users : UserControl
    {
        public users()
        {
            InitializeComponent();
        }

        private void AllClients_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataGridDrivers.Items.Refresh();

                DataGridDrivers.Visibility = Visibility.Hidden;
                DataGridClients.Visibility = Visibility.Visible;
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.Message);
            }
        }

        private void AllDrivers_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (Context db = new Context())
                {
                    db.DRIVER.Load();
                    db.CAR.Load();
                    var drivers = db.DRIVER.OrderBy(p => p.Id);
                    DataGridDrivers.ItemsSource = drivers.ToList();
                }                

                DataGridDrivers.Visibility = Visibility.Visible;
                DataGridClients.Visibility = Visibility.Hidden;
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.Message);
            }
        }

        private void AllUsers_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                using (Context db = new Context())
                {
                    DataGridDrivers.Items.Clear();
                    DataGridClients.Items.Clear();


                    var clients = db.CLIENT.OrderBy(p => p.Id);
                    DataGridClients.ItemsSource = clients.ToList();
                    
                }
            }
            catch (Exception ex)
            {
                MaterialMessageBox.ShowError("ОШИБКА: " + ex.Message);
            }
        }

        private void XMLParse_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                SqlConnection connection = new SqlConnection("Data Source=.\\;Initial Catalog=TAXI2019;Integrated Security=True;");
                SqlDataAdapter adapter = new SqlDataAdapter("select * from DRIVERs", connection);

                DataSet ds = new DataSet("DRIVERS");
                DataTable dt = new DataTable("DRIVER");
                ds.Tables.Add(dt);
                adapter.Fill(ds.Tables["DRIVER"]);

                ds.WriteXml("Driversdb.xml");
                MaterialMessageBox.Show("XML экпорт завершен успешно");
            }
            catch
            {
                MaterialMessageBox.ShowError("XML эксмпорт не завершен ");

            }

        }

        private void XMLExport_Click(object sender, RoutedEventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("Driversdb.xml");

            DataTable dt = ds.Tables[0];
            SqlConnection connection = new SqlConnection("Data Source=.\\;Initial Catalog=TAXI2019;Integrated Security=True;");
            connection.Open();
            int count = 0;

            for (int j = 0; j < dt.Rows.Count; j++)
            {
                try
                {

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "insert into DRIVERs(Surname, Firstname, Fathersname, Card, Phone, Balance, CarId, StatusId) values ('" +
                    Convert.ToString(dt.Rows[j]["Surname"]) + "', '" + Convert.ToString(dt.Rows[j]["Firstname"]) + "', '" + Convert.ToString(dt.Rows[j]["Fathersname"]) + "', " + Convert.ToString(dt.Rows[j]["Balance"]) + ", '"
                    + Convert.ToString(dt.Rows[j]["Card"])  + "', " + Convert.ToInt32(dt.Rows[j]["CarId"]) + ", " + Convert.ToInt32(dt.Rows[j]["StatusId"]) + ", '" + Convert.ToString(dt.Rows[j]["Phone"]) + "')";

                    cmd.Connection = connection;

                    cmd.CommandType = System.Data.CommandType.Text;

                    int c = cmd.ExecuteNonQuery();

                    if (c != 0)
                        count += c;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            MessageBox.Show(count + " rows exported", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            connection.Close();
        }
    }
    
}
