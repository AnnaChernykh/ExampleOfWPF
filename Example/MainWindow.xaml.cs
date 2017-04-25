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

namespace Example
{public class param
        {
            public string name { get; set; }
            public double value { get; set; }
        }
    
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        
        public MainWindow()
        {
            InitializeComponent();
            
            
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            //надо, чтоб цеплял и имя, и значение
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            string s = (selectedItem.Content.ToString());
            MessageBox.Show("Empty!"+s);
        }

        
    }
}
