using eztv_Twitter;
using System;
using Tweetinvi;

namespace TestScraper
{
    class Tester
    {
        static void Main(string[] args)
        {
            Scraper scraper = new Scraper();
            var tweets = scraper.GetRecentTweets(100);
            foreach (Tweet tweet in tweets)
            {
                Console.WriteLine("{0}:{1}", tweet.Id, tweet.Text);
            }
            Console.ReadKey();
        }
    }
}
