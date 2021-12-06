using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Practice_11
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

        private string _pattern;

        private void Information_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил Гаврюшин К. А. ИСП-34.", "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void RegularExpressions_Click(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex(_pattern);
            MatchCollection matches = regex.Matches(inputValue.Text);
            string result = string.Empty;
            foreach (var match in matches)
            {
                result += $" {match}";
            }
            MessageBox.Show(result);
        }

        private void ExerciseTwo_Checked(object sender, RoutedEventArgs e)
        {
            inputValue.Text = "aba aea aca aza axa a-a a#a";
            _pattern = @"a[^ex\s]a";
        }

        private void ExerciseOne_Checked(object sender, RoutedEventArgs e)
        {
            inputValue.Text = "a1a a22a a333a a4444a a55555a aba aca";
            _pattern = @"a\d+a";
        }
    }
}
