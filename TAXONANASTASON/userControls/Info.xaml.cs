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

namespace TAXONANASTASON.userControls
{
    /// <summary>
    /// Логика взаимодействия для Info.xaml
    /// </summary>
    public partial class Info : UserControl
    {
        public Info()
        {
            InitializeComponent();
        }

        private void MyInfo_Loaded(object sender, RoutedEventArgs e)
        {
            MySurname.Text = App.currentUser.Client.Surname;
            MyFirstname.Text = App.currentUser.Client.Firstname;
            MyPhone.Text = App.currentUser.Client.Phone;

            MyCardNumber.Text = App.currentUser.Client.Card;
            MyBalance.Text = (App.currentUser.Client.Balance.ToString())+" бел. руб";
        }

        private void UpdateBalance_Click(object sender, RoutedEventArgs e)
        {
            using (Context db = new Context())
            {
                var myUser = db.USER.FirstOrDefault(b => b.Id == App.currentUser.Id);
                MyBalance.Text = myUser.Client.Balance.ToString() + " бел. руб";
            }
        }
    }
}
