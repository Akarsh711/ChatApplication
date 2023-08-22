using ChatApplication.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication.MVVM.ViewModel
{
    internal class MainViewModel
    {
        public ObservableCollection<MessageModel> Messages { get; set; }
        public ObservableCollection<ContactModel> Contacts { get; set; }

        public MainViewModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();

            Messages.Add(new MessageModel
            {
                Username = "Allision",
                UsernameColor = "#409aff",
                ImageSource = "https://i.imgur.com/yMWvLXd.png",
                Message = "First",
                IsNativeOrigin = false,
                FirstMessage = true,
            });

            //for (int i = 0; i < 3; i++)
            //{
            //    Messages.Add(new MessageModel
            //    {
            //        Username = "Allision",
            //        UsernameColor = "#409aff",
            //        ImageSource = "https://i.imgur.com/yMWvLXd.png",
            //        Message = "Test",
            //        IsNativeOrigin = false,
            //        FirstMessage = true,
            //    });
            //}

            //for (int i = 0; i < 4; i++)
            //{
            //    Messages.Add(new MessageModel
            //    {
            //        Username = "Bunny",
            //        UsernameColor = "#409aff",
            //        ImageSource = "https://i.imgur.com/yMWvLXd.png",
            //        Message = "Test",
            //        IsNativeOrigin = false,
            //        FirstMessage = true,
            //    });
            //}

            Messages.Add(new MessageModel
            {
                Username = "Bunny",
                UsernameColor = "#409aff",
                ImageSource = "https://i.imgur.com/yMWvLXd.png",
                Message = "Last",
                IsNativeOrigin = false,
                FirstMessage = true,
            });

            for(int i = 0; i < 5; i++)
            {
                Contacts.Add(new ContactModel
                {
                    Username = $"Allision {i}",
                    ImageSource = "https://i.imgur.com/i2szTsp.png",
                    Messages = Messages
                });
            }
        }
    }
}
