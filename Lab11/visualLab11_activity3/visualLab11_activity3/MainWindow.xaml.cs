﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace visualLab11_activity3
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

    

        private void text2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Combo1_SelectionChanged2(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItem = combobox2.SelectedItem as ComboBoxItem;
            text2.Text = selectedItem.Content.ToString();
        }

        private void Combo1_SelectionChanged1(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItem = combobox1.SelectedItem as ComboBoxItem;
            text1.Text = selectedItem.Content.ToString();
           
        }
    }
}