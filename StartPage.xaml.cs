using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;

namespace MyQuotes
{
    public partial class StartPage : PhoneApplicationPage
    {
        public StartPage()
        {
            InitializeComponent();
        }

        

        private void share(object sender, EventArgs e)
        {
            ShareLinkTask shareLinkTask = new ShareLinkTask();
            shareLinkTask.Title = "Download Quotes and Sayings";
            shareLinkTask.LinkUri = new Uri("http://www.windowsphone.com/s?appid=6b8bd2f1-0391-4ba0-a7f6-9825b3d0dbff", UriKind.Absolute);   //Change this appid only
            shareLinkTask.Message = "A creative application to learn and come through famous quotes and sayings";

            shareLinkTask.Show();
        }

        private void rateme(object sender, EventArgs e)
        {
            MarketplaceReviewTask marketplaceReviewTask = new MarketplaceReviewTask();
            marketplaceReviewTask.Show();
        }

        private void feedback(object sender, EventArgs e)
        {
            EmailComposeTask emailComposeTask = new EmailComposeTask();
            emailComposeTask.Subject = "Feedback to App";           //message subject
            emailComposeTask.Body = "Write your feedback here...";  //message body
            emailComposeTask.To = "vinaymatt@outlook.com";          //email id
            emailComposeTask.Show();
        }

   


        private void Image_ManipulationStarted(object sender, ManipulationStartedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/cat.xaml", UriKind.Relative));
        }

        private void ApplicationBarMenuItem_Click(object sender, EventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/about.xaml", UriKind.Relative));
        }


      
    }
}