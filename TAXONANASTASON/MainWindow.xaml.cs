using System;
using System.Collections.Generic;
using System.Linq;
using TAXONANASTASON.Models;
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

namespace TAXONANASTASON
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EntryButton_Click(object sender, RoutedEventArgs e)
        {
            Autorization entry = new Autorization();
            Close();
            entry.Show();            
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            registration regis = new registration();
            Close();
            regis.Show();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        //private void MainWin_Loaded(object sender, RoutedEventArgs e)
        //{
        //    MainLabel.Content = ("Admin").GetHashCode();
        //}
    }
}
