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
    /// Логика взаимодействия для DriverProfile.xaml
    /// </summary>
    public partial class DriverProfile : UserControl
    {
        public DriverProfile()
        {
            InitializeComponent();
        }

        private void DriverInfo_Loaded(object sender, RoutedEventArgs e)
        {
            MySurname.Text = App.currentUser.Driver.Surname;
            MyFirstname.Text = App.currentUser.Driver.Firstname;
            MyFathersname.Text = App.currentUser.Driver.Fathersname;
            MyPhone.Text = App.currentUser.Driver.Phone;

            MyCardNumber.Text = App.currentUser.Driver.Card;
            MyBalance.Text = App.currentUser.Driver.Balance.ToString()+" бел. руб";

            CarCompany.Text = App.currentUser.Driver.Car.CarModel.Model;
            CarModel.Text = App.currentUser.Driver.Car.TypeModel;
            CarTarif.Text = App.currentUser.Driver.Car.Tarif.Type;
        }

        private void UpdateBalance_Click(object sender, RoutedEventArgs e)
        {
            using (Context db = new Context())
            {
                var myUser = db.USER.FirstOrDefault(b => b.Id == App.currentUser.Id);
                MyBalance.Text = myUser.Driver.Balance.ToString() + " бел. руб";
            }
        }
    }
}
