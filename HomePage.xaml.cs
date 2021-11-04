using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RocApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();
            Social_Tap.Tapped += Social_Tap_Tapped;
            Messages_Tap.Tapped += Messages_Tap_Tapped;
            //Calling The Chat Page Inside The HomePage as The initial Page
            var page = new Chats();
            Holder.Content = page.Content;
            MessageBox.IsVisible = true;
            SocialBox.IsVisible = false;
        }

        private void Messages_Tap_Tapped(object sender, EventArgs e)
        {
            //Calling The Chat page When Its Clicked.
            var page = new Chats();
            Holder.Content = page.Content;
            MessageBox.IsVisible = true;
            SocialBox.IsVisible = false;
        }

        private void Social_Tap_Tapped(object sender, EventArgs e)
        {
            //Calling The Social Page When Its Clicked.
            var page = new SocialPage();
            Holder.Content = page.Content;
            MessageBox.IsVisible = false;
            SocialBox.IsVisible = true;
        }
    }
}