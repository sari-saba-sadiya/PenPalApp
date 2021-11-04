using ImageCircle.Forms.Plugin.Abstractions;
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
	public partial class Chats : ContentPage
	{
		public Chats ()
		{
			InitializeComponent ();
            ChatList.ItemSelected += ChatList_ItemSelected;
            LoadList();
        }

        private void ChatList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
           
        }
       
        public void LoadList()
        {
          //Loading Offline list That Displays Users Info.
          //Note: This Will require online Data So I Used A Sample list For trial.
            List<ChatsProperties> ListOfChats = new List<ChatsProperties>();
            ListOfChats.Add(new ChatsProperties(ImageSource.FromUri(new Uri("https://weneedfun.com/wp-content/uploads/2016/07/Girls-Black-and-White-Profile-Pictures-1.jpg")), "Jacky", "Hi Jack How Is It?", "12:00pm", "1"));
            ListOfChats.Add(new ChatsProperties(ImageSource.FromUri(new Uri("https://erc.europa.eu/sites/default/files/images/researchers/Profile%20photo%20-%20JBouyer.jpg")), "Jean David", "When are We Meeting?", "12:00pm", "1"));
            ListOfChats.Add(new ChatsProperties(ImageSource.FromUri(new Uri("https://weneedfun.com/wp-content/uploads/2016/07/Girls-Black-and-White-Profile-Pictures-8.jpg")), "Aline Scott", "Are We Still Meeting tommorrow", "12:00pm", "1"));
            ChatList.ItemsSource = ListOfChats;
        }
    }
}