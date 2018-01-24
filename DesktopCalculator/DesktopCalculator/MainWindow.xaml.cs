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

namespace DesktopCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private string part1 = "";
        private string part2 = "";
        private string action;

        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void num1Btn_Click(object sender, RoutedEventArgs e)
        {
            string buttonValue = ((Button)sender).Content.ToString();
            ResultBox.Text = ResultBox.Text + ((Button)sender).Content;
            part1 = part1 + buttonValue;
        
        }

        private void plusBtn_Click(object sender, RoutedEventArgs e)
        {
            ResultBox.Text = ResultBox.Text + "+";
            part2 = part1;
            part1 = "";
            action = "+";
        }

        private void Execute_Button_Click(object sender, RoutedEventArgs e)
        {
            int part1num = int.Parse(part1);
            int part2num = int.Parse(part2);
            if(action == "+")
            {
                ResultBox.Text = (part1num + part2num).ToString();
            }

                 else if (action == "-")
            {
                ResultBox.Text = (part2num - part1num).ToString();
            }
            
            part1 = ResultBox.Text;
        }

        private void minusBtn_Click(object sender, RoutedEventArgs e)
        {
            ResultBox.Text = ResultBox.Text + "-";
            part2 = part1;
            part1 = "";
            action = "-";
        }
    }
}
