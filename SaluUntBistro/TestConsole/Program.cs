using SaluUntBistro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    // TEST SOLUTION - for testing purposes
    class Program
    {
        static void Main(string[] args)
        {
            var emailAddresses = EmailProcessor.LoadEmailAddresses();

            foreach (var email in emailAddresses)
            {
                Console.WriteLine(email.Email);
            }

            RSSProcessor rss = new RSSProcessor();

            var rssFeed = rss.GetRssFeed();

            foreach (var item in rssFeed)
            {
                Console.WriteLine(item);
            }
        }
    }
}
