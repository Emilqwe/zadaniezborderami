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

namespace zadaniezborderami
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

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            if (Rred.Visibility == Visibility.Visible) {
                Rred.Visibility = Visibility.Hidden;
                RedScrool.Visibility = Visibility.Hidden;
                RedSlider.Visibility = Visibility.Hidden;
                Progress.Value--;
            }

            else { 
                Rred.Visibility = Visibility.Visible;
                RedScrool.Visibility = Visibility.Visible;
                RedSlider.Visibility = Visibility.Visible;
                Progress.Value++;
            }
                
            
        }

        private void ListBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            if (Ryellow.Visibility == Visibility.Visible)
            {
                Ryellow.Visibility = Visibility.Hidden;
                YellowScrool.Visibility = Visibility.Hidden;
                YellowSlider.Visibility = Visibility.Hidden;
                Progress.Value--;
            }

            else
            {
                Ryellow.Visibility = Visibility.Visible;
                YellowScrool.Visibility = Visibility.Visible;
                YellowSlider.Visibility = Visibility.Visible;
                Progress.Value++;
            }
        }

        private void ListBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            if (Rblue.Visibility == Visibility.Visible)
            {
                Rblue.Visibility = Visibility.Hidden;
                BlueScrool.Visibility = Visibility.Hidden;
                BlueSlider.Visibility = Visibility.Hidden;
                Progress.Value--;
            }

            else
            {
                Rblue.Visibility = Visibility.Visible;
                BlueScrool.Visibility = Visibility.Visible;
                BlueSlider.Visibility = Visibility.Visible;
                Progress.Value++;
            }
        }

        private void ListBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            if (Rviolet.Visibility == Visibility.Visible)
            {
                Rviolet.Visibility = Visibility.Hidden;
                VioletScrool.Visibility = Visibility.Hidden;
                VioletSlider.Visibility = Visibility.Hidden;
                Progress.Value--;
            }

            else
            {
                Rviolet.Visibility = Visibility.Visible;
                VioletScrool.Visibility = Visibility.Visible;
                VioletSlider.Visibility = Visibility.Visible;
                Progress.Value++;
            }
        }

        private void ListBoxItem_Selected_4(object sender, RoutedEventArgs e)
        {
            if (Rpink.Visibility == Visibility.Visible)
            {
                Rpink.Visibility = Visibility.Hidden;
                PinkScrool.Visibility = Visibility.Hidden;
                PinkSlider.Visibility = Visibility.Hidden;
                Progress.Value--;
            }

            else
            {
                Rpink.Visibility = Visibility.Visible;
                PinkScrool.Visibility = Visibility.Visible;
                PinkSlider.Visibility = Visibility.Visible;
                Progress.Value++;
            }
        }

        private void ListBoxItem_Selected_5(object sender, RoutedEventArgs e)
        {
            if (Rgreen.Visibility == Visibility.Visible)
            {
                Rgreen.Visibility = Visibility.Hidden;
                GreenScrool.Visibility = Visibility.Hidden;
                GreenSlider.Visibility = Visibility.Hidden;
                Progress.Value--;
            }

            else
            {
                Rgreen.Visibility = Visibility.Visible;
                GreenScrool.Visibility = Visibility.Visible;
                GreenSlider.Visibility = Visibility.Visible;
                Progress.Value++;
            }
        }

        private void ListBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ScrollBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void GreenSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Rgreen.Width += 10;
        }

        private void GreenScrool_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Rgreen.Height += 10;
        }

        private void PinkScrool_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Rpink.Height += 10;
        }

        private void PinkSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Rpink.Width += 10;
        }

        private void VioletScrool_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Rviolet.Height += 10;
        }

        private void VioletSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Rviolet.Width += 10;
        }

        private void BlueScrool_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Rblue.Height += 10;
        }

        private void BlueSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Rblue.Width += 10;
        }

        private void YellowScrool_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Ryellow.Height += 10;
        }

        private void YellowSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Ryellow.Width += 10;
            
        }

        private void RedScrool_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Rred.Height += 10;
        }

        private void RedSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Rred.Width += 10;
        }
    }
}
