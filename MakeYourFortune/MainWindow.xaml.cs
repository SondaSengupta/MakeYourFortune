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
using MakeYourFortune.Repository;
using MakeYourFortune.Model;

namespace MakeYourFortune
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static FortuneRepository repo = new FortuneRepository();
        private string textboxText;
        private string fortuneCategory;
        public MainWindow()
        {
            InitializeComponent();
            SubmitButton.DataContext = repo.Context().Fortunes.Local;
        }

        private void TextboxEnter(object sender, RoutedEventArgs e)
        {
            FortuneMakerTextBox.Text = "";
        }

        private void LifeButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FortuneCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FortuneMakerTextBox.Text != "" || FortuneMakerTextBox.Text != "Enter your favorite fortune here...")
            {
                SubmitButton.IsEnabled = true;

            }
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            this.textboxText = FortuneMakerTextBox.Text;
            this.fortuneCategory = FortuneCategory.SelectedValue.ToString();
            repo.Add(new FortuneItem(textboxText, fortuneCategory));
            FortuneMakerTextBox.Text = "Enter your favorite fortune here...";
            SubmitButton.IsEnabled = false;
        }
    }
}
