using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RocApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomepageHandler : ContentPage
	{
		public HomepageHandler ()
		{
			InitializeComponent ();
            //Calling The HomePage In HomePage handler.
            //The Page Handler Has Only Bottom Menu.
            var page = new HomePage();
            Holder.Content = page.Content;

            ProfileTap.Tapped += ProfileTap_Tapped;
            MessagesTap.Tapped += MessagesTap_Tapped;
            StarTap.Tapped += StarTap_Tapped;

            StarFrame.OutlineColor = Color.Transparent;
            StarFrame.BackgroundColor = Color.Transparent;

            MessageFrame.OutlineColor = Color.FromHex("#3b71c6");
            MessageFrame.BackgroundColor = Color.FromHex("#3b71c6");

            ProfileFrame.OutlineColor = Color.Transparent;
            ProfileFrame.BackgroundColor = Color.Transparent;

            Message.Source = "MessageWhite.png";
            Profile.Source = "profile.png";
            Star.Source = "star.png";

        }

        private void StarTap_Tapped(object sender, EventArgs e)
        {
            StarFrame.OutlineColor = Color.FromHex("#3b71c6");
            StarFrame.BackgroundColor = Color.FromHex("#3b71c6");

            MessageFrame.OutlineColor = Color.Transparent;
            MessageFrame.BackgroundColor = Color.Transparent;

            ProfileFrame.OutlineColor = Color.Transparent;
            ProfileFrame.BackgroundColor = Color.Transparent;
            Message.Source = "speech.png";
            Profile.Source = "profile.png";
            Star.Source = "StarWite.png";

        }

        private void MessagesTap_Tapped(object sender, EventArgs e)
        {

            var page = new HomePage();
            Holder.Content = page.Content;

            StarFrame.OutlineColor = Color.Transparent;
            StarFrame.BackgroundColor = Color.Transparent;

            MessageFrame.OutlineColor = Color.FromHex("#3b71c6");
            MessageFrame.BackgroundColor = Color.FromHex("#3b71c6");

            ProfileFrame.OutlineColor = Color.Transparent;
            ProfileFrame.BackgroundColor = Color.Transparent;

            Message.Source = "MessageWhite.png";
            Profile.Source = "profile.png";
            Star.Source = "star.png";
        }

        private void ProfileTap_Tapped(object sender, EventArgs e)
        {
            StarFrame.OutlineColor = Color.Transparent;
            StarFrame.BackgroundColor = Color.Transparent;

            MessageFrame.OutlineColor = Color.Transparent;
            MessageFrame.BackgroundColor = Color.Transparent;

            ProfileFrame.OutlineColor = Color.FromHex("#3b71c6");
            ProfileFrame.BackgroundColor = Color.FromHex("#3b71c6");

            Message.Source = "speech.png";
            Profile.Source = "profileWhite.png";
            Star.Source = "star.png";
        }
    }
}