using System.Collections.Generic;
using System.Windows;
using AzeriChat.Class;

namespace AzeriChat
{
    public partial class MainWindow : Window
    {
       public  List<Message> messages { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            messages = new List<Message>()
            {
                new()
                {
                    Title="Hi!",
                    Time="9:00"
                },
                new()
                {
                    Title="Hello",
                    Time="9:05"
                },
                   new()
                {
                    Title="How are you?",
                    Time="10:09"
                },
                new()
                {
                    Title=";)",
                    Time="11:45"
                },
                   new()
                {
                    Title="asdfasfd",
                    Time="12:00"
                },
      
                
            };
            DataContext = this;
        }

    }
}
