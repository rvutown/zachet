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
using static WpfApp1.EF.AppData;

namespace WpfApp1
{
    
    public partial class MainWindow : Window
    {
        private static DirectoryInfo dir = new DirectoryInfo("../");
        private static string fullPath = System.IO.Path.Combine(dir.FullName, "f.txt");


        public MainWindow()
        {
            InitializeComponent();

            lwMain.ItemsSource = Context.Customer.ToList();
        }
    }

}
