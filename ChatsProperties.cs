using ImageCircle.Forms.Plugin.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RocApp
{
    class ChatsProperties
    {
        public ImageSource Profile { get; set; }
        public string FullName { get; set; }
        public string Message { get; set; }
        public string TimeSent { get; set; }
        public string UnseenMessages { get; set; }


        public ChatsProperties(ImageSource Profile, string FullName, string Message, string TimeSent, string UnseenMessages)
        {
            this.Profile = Profile;
            this.FullName = FullName;
            this.Message = Message;
            this.TimeSent = TimeSent;
            this.UnseenMessages = UnseenMessages;

        }
    }
}
