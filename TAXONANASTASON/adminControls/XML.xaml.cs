using System;
using System.Collections.Generic;
using System.IO;
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
using TAXONANASTASON.Models;
using System.Xml.Serialization;

namespace TAXONANASTASON.adminControls
{
    /// <summary>
    /// Логика взаимодействия для XML.xaml
    /// </summary>
    public partial class XML : UserControl
    {
        public XML()
        {
            InitializeComponent();
        }

        private void ExportXML_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
            //    XmlSerializer formatter = new XmlSerializer(typeof(DataGrid));

            //    using (FileStream fs = new FileStream("user.xml", FileMode.OpenOrCreate))
            //    {
            //        using (Context db = new Context())
            //        {
            //            //List<USER> allUsers = new List<USER>();

            //            //foreach (USER n in db.USER)
            //            //{
            //            //    allUsers.Add(n);

            //            formatter.Serialize(fs,);
            //        }
            //    }
            //    MessageBox.Show("КОНГРАТУЛЕЙШН");
            //}
            //catch (Exception ERROR)
            //{
            //    MessageBox.Show(ERROR.Message);
            //}           
        }
    }
}
