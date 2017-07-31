using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace message_1
{
    class Program
    {

        static void Main(string[] args)
        {
            var data = new Dictionary<string, User>();
            string input = Console.ReadLine();
            while (input != "exit")
            {
                string[] inputToken = input.Split();
                if (inputToken[0] == "register")
                {
                    data.Add(inputToken[1], new User(inputToken[1]));
                }
                if (inputToken[1] == "send" && data.ContainsKey(inputToken[0]) && data.ContainsKey(inputToken[2]))
                {
                    data[inputToken[2]].ReceivedMessages.Add(new Message(inputToken[3], inputToken[0]));                 
                }
                input = Console.ReadLine();
            }
            string[] Names = Console.ReadLine().Split();
            string firstName = Names[0];
            string secondName = Names[1];
            List<string> first = new List<string>();
            List<string> second = new List<string>();
            foreach (var item in data)
            {
                string recipient = item.Value.UserName;
                List<Message> message = item.Value.ReceivedMessages;
                foreach (var mess in message)
                {
                    string content = mess.Content;
                    string sender = mess.Sender;
                    if (firstName == sender && secondName == recipient)
                    {
                        first.Add(string.Format($"{sender}: {content}"));                    
                    }
                    if (firstName == recipient && secondName == sender)
                    {
                        second.Add(string.Format($"{content} :{sender}"));
                    }
                }
            }
            if (0 == first.Count + second.Count)
            {
                Console.WriteLine("No messages");
            }
            for (int i = 0; i < first.Count + second.Count; i++)
            {
                if (i < first.Count)
                {
                    Console.WriteLine(first[i]);
                }
                if (i < second.Count)
                {
                    Console.WriteLine(second[i]);
                }
            }
        }
    }
    class User
    {
        public string UserName { get; set; }
        public List<Message> ReceivedMessages { get; set; }
        public User(string input)
        {
            UserName = input;
            ReceivedMessages = new List<Message>();
        }
    }
    class Message
    {
        public string Content { get; set; }
        public string Sender { get; set; }
        public Message(string content, string user)
        {
            Content = content;
            Sender = user;
        }

    }
}    

