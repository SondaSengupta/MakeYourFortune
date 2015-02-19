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
            FortuneList.DataContext = repo.Context().Fortunes.Local;
        }

        private void TextboxEnter(object sender, RoutedEventArgs e)
        {
            FortuneMakerTextBox.Text = "";
        }

        private void FortuneCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ChecktoEnableSubmit();
  
        }

        private void ChecktoEnableSubmit()
        {
            if (FortuneMakerTextBox.Text == "" || FortuneMakerTextBox.Text == "Enter your favorite fortune here...")
            {
                SubmitButton.IsEnabled = false;

            }

            else
            {
                SubmitButton.IsEnabled = true;
            }
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            this.textboxText = FortuneMakerTextBox.Text;
            this.fortuneCategory = FortuneCategory.Text;
            repo.Add(new FortuneItem(textboxText, fortuneCategory));
            FortuneMakerTextBox.Text = "Enter your favorite fortune here...";
            SubmitButton.IsEnabled = false;
            FortuneCategory.Text = null;
        }

        private void FortuneOutputVisibility()
        {
            FortuneOutput.Visibility = Visibility.Visible;
        }

        private void CareerButton_Click(object sender, RoutedEventArgs e)
        {
            
            string careerFortune = repo.GetByCategory("Career");
            FortuneOutput.Text = careerFortune;
            CookieMoveOut();
            FortuneOutputVisibility();
        }

        private void RelationshipButton_Click(object sender, RoutedEventArgs e)
        {
            string relationshipFortune = repo.GetByCategory("Relationships");
            FortuneOutput.Text = relationshipFortune;
            CookieMoveOut();
            FortuneOutputVisibility();
            
        }

        private void HealthButton_Click(object sender, RoutedEventArgs e)
        {
            string healthFortune = repo.GetByCategory("Health");
            FortuneOutput.Text = healthFortune;
            CookieMoveOut();
            FortuneOutputVisibility();
        }

        private void LifeButton_Click(object sender, RoutedEventArgs e)
        {
            string lifeFortune = repo.GetByCategory("Life");
            FortuneOutput.Text = lifeFortune;
            CookieMoveOut();
            FortuneOutputVisibility();

        }

        //143 and 220
        private void CookieMoveIn()
        {
            Canvas.SetLeft(LeftCookieIMG, 143);
            Canvas.SetLeft(RightCookieIMG, 220);
            FortuneOutput.Visibility = Visibility.Hidden;
        }

        private void CookieMoveOut()
        {
            Canvas.SetLeft(LeftCookieIMG, 2);
            Canvas.SetLeft(RightCookieIMG, 400);
        }

        private void ShowList_Click(object sender, RoutedEventArgs e)
        {
            FortuneList.Visibility = Visibility.Visible;
            ShowList.Visibility = Visibility.Collapsed;
            HideList.Visibility = Visibility.Visible;
        }

        private void HideList_Click(object sender, RoutedEventArgs e)
        {
            FortuneList.Visibility = Visibility.Collapsed;
            ShowList.Visibility = Visibility.Visible;
            HideList.Visibility = Visibility.Collapsed;
        }

        private void CloseCookie_Click(object sender, RoutedEventArgs e)
        {
            CookieMoveIn();
        }
    }
}
