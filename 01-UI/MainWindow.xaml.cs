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

namespace _01_UI
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

        private void SignUpBtn_Click(object sender, RoutedEventArgs e)
        {
            LogIn.Visibility = Visibility.Collapsed;
            SignUpFirstGrid.Visibility = Visibility.Visible;
        }

        private void NextBtn_Click(object sender, RoutedEventArgs e)
        {
            SignUpFirstGrid.Visibility=Visibility.Collapsed;
            SignUpSecondGrid.Visibility=Visibility.Visible;
        }

        private void BackToSignUpFirstGridBtn_Click(object sender, RoutedEventArgs e)
        {
            SignUpSecondGrid.Visibility = Visibility.Collapsed;
            SignUpFirstGrid.Visibility = Visibility.Visible;

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            SignUpFirstGrid.Visibility = Visibility.Collapsed;
            LogIn.Visibility = Visibility.Visible;
        }

        private void CreateBtn_Click(object sender, RoutedEventArgs e)
        {
            // validation

            string FirstName = FirstNameTextBox.Text;
            string LastName = LastNameTextBox.Text;
            // ...
            // save user
            // exeption handeling

            SignInOrUpGrid.Visibility = Visibility.Collapsed;
            MainPanel.Visibility = Visibility.Visible;

        }

        private void LogInBtn_Click(object sender, RoutedEventArgs e)
        {


            // validation
        }
    }
}
