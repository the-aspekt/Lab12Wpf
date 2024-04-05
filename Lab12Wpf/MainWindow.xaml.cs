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
using System.Windows.Threading;

namespace Lab12Wpf
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

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (checkBox1 != null && checkBox2 != null && checkBox3 != null)
            {
                if (checkBox1.IsChecked == true && checkBox2.IsChecked == true && checkBox3.IsChecked == true)
                {
                    bingoLabel.Visibility = Visibility.Visible;
                    timer = new DispatcherTimer();
                    timer.Interval = TimeSpan.FromSeconds(3);
                    timer.Tick += Timer_Tick;
                    timer.Start();

                    //очистить ресурсы
                    
                }
            }
        }

        private DispatcherTimer timer;

        private void Timer_Tick(object sender, EventArgs e)
        {
            bingoLabel.Visibility = Visibility.Collapsed;
            foreach (ResourceDictionary dictionary in this.Resources.MergedDictionaries)
                    {
                        dictionary.Clear();
                    }
            timer.Stop();
        }
    }
}
