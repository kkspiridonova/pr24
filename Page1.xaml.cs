using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
         List<Class1> list = Json.des<List<Class1>>("test.json") ?? new List<Class1>();
        public Page1()
        {
            InitializeComponent();
            data.ItemsSource = list;
        }

        private void dataGrid_BeginningEdit(object sender, DataGridCellEditEndingEventArgs e)
        {
            Json.ser("test.json", list);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            data.ItemsSource = null;
            data.ItemsSource = list;
        }
    }
}
