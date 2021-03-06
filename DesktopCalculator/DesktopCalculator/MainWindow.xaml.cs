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
        private bool signSelected = false; 

        public MainWindow()
        {
            InitializeComponent();
        }
                

        private void num1Btn_Click(object sender, RoutedEventArgs e)
        {
            string buttonValue = ((Button)sender).Content.ToString();
            ResultBox.Text = ResultBox.Text + ((Button)sender).Content;
            part1 = part1 + buttonValue;
            signSelected = false;
        }

        private void action_Click(object sender, RoutedEventArgs e)
        {
            if (signSelected)
            {
                ResultBox.Text = ResultBox.Text.Substring(0, ResultBox.Text.Length - 1).ToString();
            }
                
            else

            
            {
                ResultBox.Text = ResultBox.Text + ((Button)sender).Content.ToString();

                part2 = part1;
                part1 = "";

                signSelected = true;

                action = ((Button)sender).Content.ToString();
            }

           

        }

        private void Execute_Button_Click(object sender, RoutedEventArgs e)
        {
            int part1num = int.Parse(part1);
            int part2num = int.Parse(part2);

            Arithmetics arithmetics = new Arithmetics();
            try
            { 
            ResultBox.Text = arithmetics.Calculate(part2num, part1num, action).ToString();
            }
            catch (DivideByZeroException ex)
            {
                ResultBox.Text = "Division by 0 not allowed";
            }
                
            part1 = ResultBox.Text;
        }
              

    }
}
