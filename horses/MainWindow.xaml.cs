using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace horses
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
          
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
            gr.Content = Convert.ToInt32(sl.Value).ToString();

        }

        private void mn_Loaded(object sender, RoutedEventArgs e)
        {

            Thread thread = new Thread(Start);
            thread.Start();
        }
        public void Start()
        {
            Brush fg = Brushes.Black;
            int value1 = 0;
            int value2 = 0;
            int value3 = 0;
            int value4 = 0;
            int value5 = 0;
            int value6 = 0;
            int k = 0;
            int n1 = 0;
            //int n2 = 0;
            //int n3 = 0;
            //int n4 = 0;
            //int n5 = 0;
            //int n6 = 0;
            Random rand = new Random();
            for (double i = 0; i <= 100; i++)
            {
                Thread.Sleep(rand.Next(10, 300));

                value1 += (rand.Next(1, 5));
                Dispatcher.BeginInvoke(DispatcherPriority.Normal, new Action(() => h1.Value = value1));
                Thread.Sleep(rand.Next(10, 1000));
                value2 += (rand.Next(1, 5));
                Dispatcher.BeginInvoke(DispatcherPriority.Normal, new Action(() => h2.Value = value2));

                value3 += (rand.Next(1, 5));
                Dispatcher.BeginInvoke(DispatcherPriority.Normal, new Action(() => h3.Value = value3));

                value4 += (rand.Next(1, 5));
                Dispatcher.BeginInvoke(DispatcherPriority.Normal, new Action(() => h4.Value = value4));

                value5 += (rand.Next(1, 5));
                Dispatcher.BeginInvoke(DispatcherPriority.Normal, new Action(() => h5.Value = value5));

                value6 += (rand.Next(1, 5));
                Dispatcher.BeginInvoke(DispatcherPriority.Normal, new Action(() => h6.Value = value6));
                if (value1 >= 100)
                {
                    if (n1 == 0)
                    {
                        n1++;
                        k++;
                        
                    }
                   
                }
                else
                {

                }
            }
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {

            Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }

        private void h1_Loaded(object sender, RoutedEventArgs e)
        {
            var p = (ProgressBar)sender;

            if (p.Value==p.Maximum)
            {
                p.Foreground = Brushes.Yellow;
               
            }
            
            }

        private void h1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ThicknessAnimation ta = new ThicknessAnimation();
            Thickness topMargin = new Thickness(25, 0,25,0);
            ta.To = ___Img_.Margin;
            ta.From = topMargin;
            ta.Duration = TimeSpan.FromSeconds(2);
            ___Img_.BeginAnimation(FrameworkElement.MarginProperty, ta);
        }

        private void h2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ThicknessAnimation ta = new ThicknessAnimation();
            Thickness topMargin = new Thickness(0, 0, 0, 0);
            ta.To = ___Img_.Margin;
            ta.From = topMargin;
            ta.Duration = TimeSpan.FromSeconds(2);
            ___Img_.BeginAnimation(FrameworkElement.MarginProperty, ta);
        }
    }
    
}
