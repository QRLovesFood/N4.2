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

namespace N4_CLICKER
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        decimal point = 0;
        int inter = 1;
        decimal point_on_click = 0.0001M;
        int n = 1;
        public void Update()
        {
            pnt.Content = $"Биткоин: {point}";
            pntOnClick.Content = $"Майнинг фермы: {point_on_click}";
        }
        public void Img()
        {
            if (n == 0)
            {

            }
        }
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(inter);
            timer.Tick += Timer_Tick;
            timer.Start();
            Update();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            point += point_on_click;
            Update();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            point += point_on_click;
            Update();
        }

        private void X2_Click(object sender, RoutedEventArgs e)
        {
            point_on_click *= 2;
            Update();
        }

        private void X5_Click(object sender, RoutedEventArgs e)
        {
            point_on_click *= 5;
            Update();
        }

        private void X100_Click(object sender, RoutedEventArgs e)
        {
            point_on_click *= 100;
            Update();
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            point += 0.01M;
            Update();
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            point += 1;
            Update();
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            point += 100;
            Update();
        }

        private void RESET_Click(object sender, RoutedEventArgs e)
        {
            point = 0;
            point_on_click = 0.0001M;
            Update();
        }

        private void N1_Click(object sender, RoutedEventArgs e)
        {
            if (point >= 50)
            {
                point -= 50;
                
            }
        }

        private void EXIT_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void SHOP1_Click(object sender, RoutedEventArgs e)
        {
            if (point >= 1)
            {
                point -= 1;
                IMG5.Visibility = Visibility.Visible;
                SHOPLB1.Visibility = Visibility.Hidden;
                SHOP1.IsEnabled = false;
                SHOP1.Content = "Куплено";
            }
        }

        private void SHOP2_Click(object sender, RoutedEventArgs e)
        {
            if (point >= 10)
            {
                point -= 10;
                IMG22.Visibility = Visibility.Visible;
                SHOPLB2.Visibility = Visibility.Hidden;
                SHOP2.IsEnabled = false;
                SHOP2.Content = "Куплено";
            }
        }

        private void SHOP3_Click(object sender, RoutedEventArgs e)
        {
            if (point >= 100)
            {
                point -= 100;
                IMG33.Visibility = Visibility.Visible;
                SHOPLB3.Visibility = Visibility.Hidden;
                SHOP3.IsEnabled = false;
                SHOP3.Content = "Куплено";
            }
        }

        private void SHOP4_Click(object sender, RoutedEventArgs e)
        {
            if (point >= 10000)
            {
                point -= 10000;
                IMG44.Visibility = Visibility.Visible;
                SHOPLB4.Visibility = Visibility.Hidden;
                SHOP4.IsEnabled = false;
                SHOP4.Content = "Куплено";
            }
        }
    }
}
