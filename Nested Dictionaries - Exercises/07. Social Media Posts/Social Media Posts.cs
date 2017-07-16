using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Social_Media_Posts
{
    class Program
    {
        static Dictionary<string, Dictionary<string, List<string>>> postComment
                         = new Dictionary<string, Dictionary<string, List<string>>>();
        static Dictionary<string, int> like = new Dictionary<string, int>();
        static Dictionary<string, int> dislike = new Dictionary<string, int>();
        static void Main(string[] args)
        {

           
            string[] input = Console.ReadLine().Split();

            while (input[0] != "drop")
            {
                string temp = input[0];
                string inputToken = input[1];

                switch (temp)
                {
                    case "post":
                        NewPost(inputToken);
                        break;
                    case "like":
                        Like(inputToken);
                        break;
                    case "dislike":
                        Dislike(inputToken);
                        break;
                    case "comment":
                        string name = input[2];
                        List<string> comment = input.Skip(3).ToList(); 
                        Comment(inputToken, name, comment);
                        break;                  
                }
                input = Console.ReadLine().Split();
            }
            foreach (var item in postComment)
            {
                string post = item.Key;
                Dictionary<string,List< string>> comment = item.Value;
                int likes = 0;
                int dislikes = 0;
                foreach (var lk in like)
                {
                    string postlike = lk.Key;
                    if (postlike == post)
                    {
                        likes = lk.Value;
                    }
                }
                foreach (var dl in dislike)
                {
                    string postDislike = dl.Key;
                    if (postDislike == post)
                    {
                        dislikes = dl.Value;
                    }
                }
                Console.WriteLine($"Post: {post} | Likes: {likes} | Dislikes: {dislikes}");
                Console.WriteLine("Comments:");
                if (comment.Count == 0)
                {
                    Console.WriteLine("None");
                }
                else
                {
                    foreach (KeyValuePair<string,List< string>> com in comment)
                    {
                        Console.WriteLine($"*  {com.Key}: {string.Join(" ",com.Value)}");
                    }
                }
               
            }
        }
        static void NewPost(string inputToken)
        {
            postComment.Add(inputToken, new Dictionary<string, List<string>>());
            like.Add(inputToken, 0);
            dislike.Add(inputToken, 0);
        }
        static void Like(string inputToken)
        {
            like[inputToken]++;
        }
        static void Dislike(string inputToken)
        {
            dislike[inputToken]++;
        }
        static void Comment(string inputToken, string name,List< string> comment)
        {
            postComment[inputToken].Add(name, comment);
        }
    }
}
