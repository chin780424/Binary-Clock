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
using System.IO;

namespace Zegar_Binarny
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        


        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();

        }

        private void Timer_Tick(object sender, EventArgs e) //Funkcja, którą timer będzie wykonywać
        {
            System.DateTime moment = DateTime.Now;

            BitmapImage One = new BitmapImage();
            One.BeginInit();
            One.UriSource = new Uri(@"one.png", UriKind.Relative);
            One.EndInit();

            BitmapImage Zero = new BitmapImage();
            Zero.BeginInit();
            Zero.UriSource = new Uri(@"zero.png", UriKind.Relative);
            Zero.EndInit();

            int hour = moment.Hour;
            int minute = moment.Minute;

            int hour1, hour2;
            int minute1, minute2;


            hour2 = hour % 10;
            hour1 = (hour - hour2)/10;

            minute2 = minute % 10;
            minute1 = (minute - minute2) / 10;


            if (hour1 == 2)
                hour1_2.Source = One;
            else
                hour1_2.Source = Zero;

            if (hour1 == 1)
                hour1_1.Source = One;
            else
                hour1_1.Source = Zero;

            // GODZINA 2 LICZBA
            if (hour2 >= 8)
            {
                hour2_4.Source = One;
                hour2 -= 8;
            }
            else hour2_4.Source = Zero;

            if (hour2 >= 4)
            {
                hour2_3.Source = One;
                hour2 -= 4;
            }
            else hour2_3.Source = Zero;

            if (hour2 >= 2)
            {
                hour2_2.Source = One;
                hour2 -= 2;
            }
            else hour2_2.Source = Zero;

            if (hour2 >= 1)
            {
                hour2_1.Source = One;
                hour2 -= 1;
            }
            else hour2_1.Source = Zero;

            // MINUTA 1 LICZBA

            if (minute1 >= 4)
            {
                minute1_3.Source = One;
                minute1 -= 4;
            }
            else minute1_3.Source = Zero;

            if (minute1 >= 2)
            {
                minute1_2.Source = One;
                minute1 -= 2;
            }
            else minute1_2.Source = Zero;

            if (minute1 >= 1)
            {
                minute1_1.Source = One;
                minute1 -= 1;
            }
            else minute1_1.Source = Zero;

            // GODZINA 2 LICZBA
            if (minute2 >= 8)
            {
                minute2_4.Source = One;
                minute2 -= 8;
            }
            else minute2_4.Source = Zero;

            if (minute2 >= 4)
            {
                minute2_3.Source = One;
                minute2 -= 4;
            }
            else minute2_3.Source = Zero;

            if (minute2 >= 2)
            {
                minute2_2.Source = One;
                minute2 -= 2;
            }
            else minute2_2.Source = Zero;

            if (minute2 >= 1)
            {
                minute2_1.Source = One;
                minute2 -= 1;
            }
            else minute2_1.Source = Zero;
        }
    }
}
