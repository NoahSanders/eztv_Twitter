using System;
using System.Collections.Generic;
using TweetinCore.Interfaces;
using Tweetinvi;
using TwitterToken;

namespace eztv_Twitter
{
    public class Scraper
    {
        /// <summary>
        /// Token values for ShowMonitor application
        /// </summary>
        private Token _token;

        /// <summary>
        /// Twitter user ID for eztv
        /// </summary>
        private long _userID;

        /// <summary>
        /// Scraper object - creates token for using twitter api
        /// </summary>
        public Scraper()
        {
            _token = new Token(
                "2266820437-L5j7hXlvyAjTKz7vadvYtioWQ0rIWgMl5WZVFxG",
                "YcME9TGc4mcBfSW7WsMYn0vLsHUTctPbRiN1pKcR0Db11",
                "lhNlxKUX2rGa4K9dAniNw",
                "n0c0enY5NxdXqodqK0rIcjAH8JpopyKAs75nVUlXIY"
            );

            //double check this
            _userID = 89779019;
        }

        /// <summary>
        /// Gets eztv timeline
        /// </summary>
        /// <param name="count">currently non-functional</param>
        /// <returns>List of tweets from timeline</returns>
        public List<ITweet> GetRecentTweets(int count)
        {
            List<ITweet> timeline = new List<ITweet>();
            try
            {
                User user = new User(_userID, _token, true);
                timeline = user.GetUserTimeline();
            }
            catch (Exception e)
            {
                //yeezus christ improve this bullshit
                throw e;
            }
            return timeline;
        }
    }
}
