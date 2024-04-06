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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        List<Class1> list = new List<Class1>();
        int index = 0;
        public Page2(List<Class1> list)
        {
            InitializeComponent();
            User.result = 0;
            this.list = list;
            set();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((sender as Button).Content.ToString() != "")
            {
                if ((sender as Button) == panel.Children[Convert.ToInt32(list[index].answer) - 1]) User.result += 1;
                index++;
                set();
            }
        }

        void set()
        {
            if (index == list.Count)
            {
                title.Text = $"Ваш результат {User.result} из {list.Count}";
                description.Text = "";
                (panel.Children[0] as Button).Content = "";
                (panel.Children[1] as Button).Content = "";
                (panel.Children[2] as Button).Content = "";
            }
            else
            {
                title.Text = list[index].title;
                description.Text = list[index].description;
                (panel.Children[0] as Button).Content = list[index].answer1;
                (panel.Children[1] as Button).Content = list[index].answer2;
                (panel.Children[2] as Button).Content = list[index].answer3;
            }
        }
    }
}
