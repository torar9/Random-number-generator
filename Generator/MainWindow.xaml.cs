﻿using System.Windows;

namespace Generator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GeneratedNumber.Text = "0";
            NumberAmout.Text     = "1";
        }

        private void GenNumber(object sender, RoutedEventArgs e)
        {
            GeneratorE generator = new GeneratorE(lowAmout.Text, highAmout.Text, NumberAmout.Text);

            GeneratedNumber.Text = generator.Generate();
        }

        private void WAbout(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Author: Tomáš Silber"); // Last time edited: 10.7.2015 16:45
        }

        
    }
}
