using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace question
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
        int score = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach(RadioButton item in spfirst.Children)
            {
                if(item.Tag.ToString() == "Y" && item.IsChecked == true)
                {
                    score = score + 1;
                }
            }
            foreach (RadioButton item in spsecond.Children)
            {
                if (item.Tag.ToString() == "Y" && item.IsChecked == true)
                {
                    score = score + 1;
                }
            }
            foreach (RadioButton item in spthird.Children)
            {
                if (item.Tag.ToString() == "Y" && item.IsChecked == true)
                {
                    score = score + 1;
                }
            }
            foreach (RadioButton item in spfourth.Children)
            {
                if (item.Tag.ToString() == "Y" && item.IsChecked == true)
                {
                    score = score + 1;
                }
            }
            foreach (RadioButton item in spfifth.Children)
            {
                if (item.Tag.ToString() == "Y" && item.IsChecked == true)
                {
                    score = score + 1;
                }
            }
            foreach (RadioButton item in spsIX.Children)
            {
                if (item.Tag.ToString() == "Y" && item.IsChecked == true)
                {
                    score = score + 1;
                }
            }
            foreach (RadioButton item in spseven.Children)
            {
                if (item.Tag.ToString() == "Y" && item.IsChecked == true)
                {
                    score = score + 1;
                }
            }
            foreach (RadioButton item in speight.Children)
            {
                if (item.Tag.ToString() == "Y" && item.IsChecked == true)
                {
                    score = score + 1;
                }
            }
            foreach (RadioButton item in spnine.Children)
            {
                if (item.Tag.ToString() == "Y" && item.IsChecked == true)
                {
                    score = score + 1;
                }
            }
            foreach (RadioButton item in spten.Children)
            {
                if (item.Tag.ToString() == "Y" && item.IsChecked == true)
                {
                    score = score + 1;
                }
            }
            foreach (CheckBox item in speleven.Children)
            {
                if (item.Tag.ToString() == "Y" && item.IsChecked == true)
                {
                    score = score + 1;
                }
            }
            lblscore.Content = score.ToString();
            spvis.Visibility = Visibility.Collapsed;
        }
    }
}