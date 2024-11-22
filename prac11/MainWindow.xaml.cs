using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace prac11
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
        /// <summary>
        /// Кнопка поиска строк в первой строке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind1_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem selectedItem = InputComboBox.SelectedItem as ComboBoxItem;
            string input = string.Empty;

            if (selectedItem != null)
            {
                input = selectedItem.Content.ToString();
            }

            string pattern = @"a\d+a";
            MatchCollection matches = Regex.Matches(input, pattern);

            OutputTextBlock.Text = "Найденные строки:\n";
            foreach (Match match in matches)
            {
                OutputTextBlock.Text += match.Value + " ";
            }
        }
        /// <summary>
        /// Кнопка поиска строк во второй строке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind2_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem selectedItem = InputComboBox.SelectedItem as ComboBoxItem;
            string input = string.Empty;

            if (selectedItem != null)
            {
                input = selectedItem.Content.ToString();
            }

            string pattern = @"\ba[^ex]*a\b";
            MatchCollection matches = Regex.Matches(input, pattern);

            OutputTextBlock.Text = "Найденные строки:\n";
            foreach (Match match in matches)
            {
                OutputTextBlock.Text += match.Value + " ";
            }
        }
        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Демьяхин Роман ИСП-31 12 Вариант\nДана строка 'a1a a22a a333a a4444a a55555a aba aca'. Напишите регулярное выражение, которое найдет строки, в которых по краям стоят буквы 'a', а между ними любое количество цифр.\nДана строка 'aba aea aca aza axa a-a a#a'. Напишите регулярное выражение, которое найдет строки следующего вида: по краям стоят буквы 'a', а между ними - не 'e' и не 'x'. ",
                            "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}