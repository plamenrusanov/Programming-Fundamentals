using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new Dictionary<string, List<Message>>();
            string input = Console.ReadLine();
            while (input != "exit")
            {
                string[] inputToken = input.Split();
                if (inputToken[0] == "register")
                {
                    string userName = inputToken[1];
                    users.Add(userName, new List<Message>());
                }
                else
                {
                    string sender = inputToken[0];
                    string recipient = inputToken[2];
                    string content = inputToken[3];
                    if (users.ContainsKey(sender) && users.ContainsKey (recipient))
                    {
                        Message temp = new Message(content, sender);
                        //string userSender = users[sender];
                        users[recipient].Add(temp);
                    }
                } //Ivan send Pesho kak_si
                input = Console.ReadLine();
            }
            string[] dialog = Console.ReadLine().Split();
            string send = dialog[0];
            string recip = dialog[1];
            List<Message> Sender = users.Where(u => u.Key == send).Where(x => x.Value)
            foreach (var item in users)
            {
                string sender = item.Key;
                Console.WriteLine(sender);
                List<Message> comment = item.Value;
                foreach (var tuit in comment)
                {
                    Console.WriteLine(  tuit.Content +" :"+tuit.Sender);
                }
            }
        }
    }
    public class User
    {
        public string UserName { get; set; }
        public List<string> Messages { get; set; }
        public User (string userName, List<string> messages)
        {
            this.UserName = userName;
            this.Messages = messages;
        }
    }
    class Message
    {
        public string Content { get; set; }
        public string Sender { get; set; }
        public Message (string content, string sender)
        {
            this.Content = content;
            this.Sender = sender;
        }
    }
}
