using RedditSharp;
using RedditSharp.Things;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrustrationBot.Posts
{
    class PostFetcher
    {
        private Reddit reddit;
        private Subreddit subreddit;

        public PostFetcher()
        {
            reddit.LogIn("FrustrationBot", "123123");
        }
    }
}
