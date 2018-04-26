﻿using System;
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

namespace _419edited
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
        //set blank of heightbox
        private void heightbutton_Click(object sender, RoutedEventArgs e)
        {
            heightbox.Background = Brushes.Yellow;
            heightbox.Text = "";
        }
        //set blank of weightbox
        private void weightbutton_Click_1(object sender, RoutedEventArgs e)
        {
            weightbox.Background = Brushes.Yellow;
            weightbox.Text = "";
        }

       

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (IsInitialized)
            {
                heightbox.Text = slider_h.Value.ToString("#00.00").ToString(); // change value by hand    
                weightbox.Text = slider_w.Value.ToString("#00.00").ToString();

            double w = double.Parse(weightbox.Text);
            double h = double.Parse(heightbox.Text);
            double BMI = 10000*w / (h * h);
            answer.Text= BMI.ToString("#00.00").ToString();
            }
        }

     
    }
}
