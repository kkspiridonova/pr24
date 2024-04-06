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
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        List<Class1> list = Json.des<List<Class1>>("test.json") ?? new List<Class1>();
        public Window1(int iniialize)
        {
            InitializeComponent();
            if (iniialize == 1) frame.Content = new Page1();
            else if (iniialize == 2)
            {
                if (list.Count == 0) frame.Content = new Page3();
                else frame.Content = new Page2(list);
                redactTest.IsEnabled = false;
            }
        }
        private void Window_Closed(object sender, EventArgs e) { }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (list.Count == 0) frame.Content = new Page3();
            else frame.Content = new Page2(list);
        }

        private void redactTest_Click(object sender, RoutedEventArgs e) => frame.Content = new Page1();
    }
}
