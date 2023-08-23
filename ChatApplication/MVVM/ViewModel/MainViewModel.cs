using ChatApplication.Core;
using ChatApplication.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Policy;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        public ObservableCollection<MessageModel> Messages { get; set; }
        public ObservableCollection<ContactModel> Contacts { get; set; }


        /* Commands */
        public RelayCommand SendCommand { get; set; }
        private ContactModel _selectedContact;

        public ContactModel SelectedContact
        {
            get { return _selectedContact; }
            set { _selectedContact = value; }
        }
        


        private string _message;

        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();

            SendCommand = new RelayCommand(o =>
            {
                Messages.Add(new MessageModel
                {
                    Message = Message,
                    FirstMessage = false
                });
                Message = "";
            });

            Messages.Add(new MessageModel
            {
                Username = "Allision",
                UsernameColor = "#409aff",
                ImageSource = "https://i.imgur.com/yMWvLXd.png",
                Message = "First",
                IsNativeOrigin = false,
                FirstMessage = true,
            });

            for (int i = 0; i < 3; i++)
            {
                Messages.Add(new MessageModel
                {
                    Username = "Allision",
                    UsernameColor = "#409aff",
                    ImageSource = "https://i.imgur.com/yMWvLXd.png",
                    Message = "Test",
                    IsNativeOrigin = false,
                    FirstMessage = true,
                });
            }

            for (int i = 0; i < 4; i++)
            {
                Messages.Add(new MessageModel
                {
                    Username = "Bunny",
                    UsernameColor = "#409aff",
                    ImageSource = "https://i.imgur.com/yMWvLXd.png",
                    Message = "Test",
                    IsNativeOrigin = false,
                    FirstMessage = true,
                });
            }

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
