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

namespace Text_Editor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox != null)
                textBox.FontFamily = new FontFamily(fontName);
        }
        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            int fontSize = Convert.ToInt32(((sender as ComboBox).SelectedItem as TextBlock).Text);
            if (textBox != null)
                textBox.FontSize = fontSize;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FontWeight fontWeight = textBox.FontWeight;
            if (textBox != null && fontWeight != FontWeights.Bold)
            {
                textBox.FontWeight = FontWeights.Bold;
            }
            else if (textBox != null && fontWeight == FontWeights.Bold)
            {
                textBox.FontWeight = FontWeights.Normal;
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FontStyle fontStyle = textBox.FontStyle;
            if (textBox != null && fontStyle != FontStyles.Italic)
            {
                textBox.FontStyle = FontStyles.Italic;
            }
            else if (textBox != null && fontStyle == FontStyles.Italic)
            {
                textBox.FontStyle = FontStyles.Normal;
            }
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TextDecorationCollection fontDecoration = textBox.TextDecorations;
            if (textBox != null && fontDecoration != TextDecorations.Underline)
            {
                textBox.TextDecorations = TextDecorations.Underline;
            }
            else if (textBox != null && fontDecoration == TextDecorations.Underline)
            {
                textBox.TextDecorations = null;
            }
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {                     
            if (textBox != null && textBox.Foreground != Brushes.Black)
            {
                textBox.Foreground = Brushes.Black;
            }           
        }
        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {           
            if (textBox != null && textBox.Foreground != Brushes.Red)
            {
                textBox.Foreground = Brushes.Red;
            }
        }
    }
}
