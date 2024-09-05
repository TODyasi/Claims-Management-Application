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

namespace CMCS.Design.Wpf.Draft
{
    /// <summary>
    /// Interaction logic for LecturerViewPage.xaml
    /// </summary>
    public partial class LecturerView : Page
    {
        public LecturerView()
        {
            InitializeComponent();
            InitializeNavbar();
        }
        private void InitializeNavbar()
        {
            // Example role check. Replace with your actual logic.
            bool isLecturer = true; // This should be dynamically determined
            bool isLoggedIn = true; // This should be dynamically determined

            SubmitClaimsButton.Visibility = isLecturer ? Visibility.Visible : Visibility.Collapsed;
            ReviewClaimsButton.Visibility = isLecturer ? Visibility.Collapsed : Visibility.Visible;
            LogoutButton.Visibility = isLoggedIn ? Visibility.Visible : Visibility.Collapsed;
            LoginButton.Visibility = isLoggedIn ? Visibility.Collapsed : Visibility.Visible;
        }

        //NavBar button handlers
        private void Home_Click(object sender, RoutedEventArgs e) { /* Handle Home button click */ }
        private void SubmitClaims_Click(object sender, RoutedEventArgs e) { /* Handle Submit Claims button click */ }
        private void ReviewClaims_Click(object sender, RoutedEventArgs e) { /* Handle Review Claims button click */ }
        private void UploadDocument_Click(object sender, RoutedEventArgs e) { /* Handle Upload Document button click */ }
        private void Profile_Click(object sender, RoutedEventArgs e) { /* Handle Profile button click */ }
        private void HelpSupport_Click(object sender, RoutedEventArgs e) { /* Handle Help/Support button click */ }
        private void Logout_Click(object sender, RoutedEventArgs e) { /* Handle Logout button click */ }
        private void Login_Click(object sender, RoutedEventArgs e) { /* Handle Log In button click */ }

        // Sidebar button handlers
        private void AddClaim_Click(object sender, RoutedEventArgs e) { /* Handle Add Claim button click */ }
        private void EditClaim_Click(object sender, RoutedEventArgs e) { /* Handle Edit Claim button click */ }
        private void DeleteClaim_Click(object sender, RoutedEventArgs e) { /* Handle Delete Claim button click */ }
        private void ViewClaims_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new MyClaimsView();
        }


    }
}
