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
    /// Interaction logic for ReviewerView.xaml
    /// </summary>
    public partial class ReviewerView : Page
    {
        public ReviewerView()
        {
            InitializeComponent();
        }
        private void Home_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the home page or perform the home action
            MessageBox.Show("Home button clicked.");
        }

        private void SubmitClaims_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the submit claims view or perform the submit claims action
            MessageBox.Show("Submit Claims button clicked.");
        }

        private void ReviewClaims_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the review claims view or perform the review claims action
            MessageBox.Show("Review Claims button clicked.");
        }

        private void UploadDocument_Click(object sender, RoutedEventArgs e)
        {
            // Open file dialog or perform the upload document action
            MessageBox.Show("Upload Document button clicked.");
        }

        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the profile view or perform the profile action
            MessageBox.Show("Profile button clicked.");
        }

        private void HelpSupport_Click(object sender, RoutedEventArgs e)
        {
            // Show help/support dialog or navigate to help/support page
            MessageBox.Show("Help/Support button clicked.");
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            // Log out the user
            MessageBox.Show("Logout button clicked.");
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            // Log in the user
            MessageBox.Show("Login button clicked.");
        }

        private void ViewClaims_Click(object sender, RoutedEventArgs e)
        {
            // Implement logic to approve a claim
            MessageBox.Show("View Claim button clicked.");
        }

        private void UpdateClaims_Click(object sender, RoutedEventArgs e)
        {
            // Implement logic to reject a claim
            MessageBox.Show("Update Claim button clicked.");
        }

        private void ReviewDetails_Click(object sender, RoutedEventArgs e)
        {
            // Implement logic to review claim details
            MessageBox.Show("Review Details button clicked.");
        }

        private void GenerateReport_Click(object sender, RoutedEventArgs e)
        {
            // Implement logic to generate a report
            MessageBox.Show("Generate Report button clicked.");
        }
    }
}

