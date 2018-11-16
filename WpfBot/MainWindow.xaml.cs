using HHBotLib;
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

namespace WpfBot
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HHModel m = new HHModel();
            string r = m.WEbClientGet("http://api.hh.ru/vacancies?text=Программист");

            ResListBox.Items.Clear();
            List<Work> work = m.JsonParseList(r);
            foreach (Work w in work)
             {
                // ResListBox.Items.Add(w.id + " " + w.Name);
                ListBoxItem item = new ListBoxItem();
               // item.Name = w.Name;
                item.Content = w.id + " " + w.Name;
                item.Tag = w.info;
                ResListBox.Items.Add(item);
                
            }

//            ResListBox.ItemsSource = work;
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(ResListBox.SelectedItem.ToString());
        }
    }
}
