using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzeriChat.Class
{
    public class Message
    {
        public string? Title { get; set; }
        public string? Time { get; set; }

        public Message()
        {
            Title = null;
            Time = null;
        }
        public Message(string text, string time)
        {
            Title = text;
            Time = time;
        }
    }

}
