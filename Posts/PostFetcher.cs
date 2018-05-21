using RedditSharp;
using RedditSharp.Things;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrustrationBot.Posts
{
    /// <summary>
    /// The class responsible for getting posts from reddit through RedditSharp.
    /// </summary>
    class PostFetcher
    {
        private Reddit reddit;

        /// <summary>
        /// Create a new PostFetcher intance
        /// </summary>
        public PostFetcher()
        {
            reddit = new Reddit();
            reddit.LogIn("FrustrationBot", "123123");
        }

        /// <summary>
        /// Fetch 25 posts from the subreddit given
        /// </summary>
        /// <param name="sub">The sub to fetch the data from</param>
        /// <returns></returns>
        public List<Post> FetchPosts(string sub)
        {
            var posts = new List<Post>();
            var subreddit = reddit.GetSubreddit(sub);
            foreach(var post in subreddit.Hot.Take(25))
            {
                Console.WriteLine("-->" + post.Title);
                posts.Add(new Post(post.Title, post.SelfText));
            }
            return posts;
        }
    }
}
