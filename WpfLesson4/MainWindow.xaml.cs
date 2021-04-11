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

namespace WpfLesson4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Car> GetCars()
        {
            return new List<Car>
            {
                new Car
                {
                    Model="E-200",
                    Vendor="Mercedes",
                    Year=2021
                },
                new Car
                {
                    Model="F-12 Berlinetta",
                    Vendor="Ferrari",
                    Year=2021
                },
                new Car
                {
                    Model="M5",
                    Vendor="BMW",
                    Year=2021
                },
                new Car
                {
                    Model="Cruze LTZ RS",
                    Vendor="Chevrolet",
                    Year=2021
                }
            };
        }
        public MainWindow()
        {
            InitializeComponent();
            // prgbar.IsIndeterminate = true;
           // lstbox.ItemsSource = GetCars();
        }

        private void downBtn_Click(object sender, RoutedEventArgs e)
        {
        //    if (prgbar.Value > prgbar.Minimum)
        //    {
        //        --prgbar.Value;
        //    }
        }

        private void upBtn_Click(object sender, RoutedEventArgs e)
        {
            //if (prgbar.Value < prgbar.Maximum)
            //{
            //    ++prgbar.Value;
            //}
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //txtblock1.Text = Convert.ToInt32(slider.Value).ToString();
            //txtblock2.Text = Convert.ToInt32(slider.Value).ToString();
        }

        private void lstbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //var car = lstbox.SelectedItem as Car;
            //if (car != null)
            //{
            //    modelTxtblock.Text = $"Model : {car.Model}";
            //    vendorTxtblock.Text = $"Vendor : {car.Vendor}";
            //    yearTxtblock.Text = $"Year : {car.Year.ToString()}";
            //}

            //modelTxtblock.Text = "Model : ";
            //vendorTxtblock.Text = "Vendor : ";
            //yearTxtblock.Text = "Year : ";

            //var carObjects = lstbox.SelectedItems;
            //foreach (var item in carObjects)
            //{
            //    if(item is Car car)
            //    {
            //        modelTxtblock.Text += car.Model+" ";
            //        vendorTxtblock.Text += car.Vendor + " ";
            //        yearTxtblock.Text += car.Year.ToString() + " ";
            //    }
            //}


        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //var item = cmbbox.SelectedItem as ComboBoxItem;
            //var stackpanel = item.Content as StackPanel;
            //foreach (var element in stackpanel.Children)
            //{
            //    if (element is TextBlock tb) {
            //        MessageBox.Show(tb.Text);
            //    }    
            //}
           
        }
    }
}
