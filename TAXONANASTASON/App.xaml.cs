using System;
using TAXONANASTASON.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace TAXONANASTASON
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static USER currentUser { get; set; }
        public static USER admin { get; set; }
    }
}
