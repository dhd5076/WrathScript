using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrustrationBot.Posts
{
    /// <summary>
    /// Keeps track of the biometric data for all posts and handles updating the GUI with the new post data
    /// </summary>
    class PostTracker
    {
        private Post currentPost;
        private List<Post> posts;
        private PostFetcher postFetcher;
        private string subredditToTrack;

        /// <summary>
        /// Create a new post tracker class
        /// </summary>
        /// <param name="subredditToTrack">The subreddit that we are going to analyze</param>
        public PostTracker(string subredditToTrack)
        {
            this.postFetcher = new PostFetcher();
            this.subredditToTrack = subredditToTrack;
            this.posts = new List<Post>();
            posts.Add(new Post("[FIRST POST]", "[EMPTY]"));
        }

        /// <summary>
        /// Begins the data tracker which load up the first post after fetching the list
        /// </summary>
        public void Start()
        {
            Console.WriteLine("Starting Tracker...");
            this.posts.AddRange(this.postFetcher.FetchPosts(subredditToTrack));
            currentPost = posts.ElementAt<Post>(0);
            Console.WriteLine("Tracker Loaded");

        }

        /// <summary>
        /// Move onto the next post if possible
        /// </summary>
        /// <returns>Whether we are at the end of the list of posts</returns>
        public bool Next()
        {
            var newIndex = posts.IndexOf(currentPost) + 1;
            if (newIndex < posts.Count - 2) {
                currentPost = posts.ElementAt<Post>(newIndex);
                Console.WriteLine("Loading Next Post...");
                return false;
            } else
            {
                Console.WriteLine("All posts tracked!");
                return true;
            }
        }

        /// <summary>
        /// Resets the data tracker to its default state
        /// </summary>
        public void Reset()
        {
            Console.WriteLine("Resetting...");
            this.posts.Clear();
            posts.Add(new Post("[FIRST POST]", "[EMPTY]"));
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get the current post that is being used for analysis
        /// </summary>
        /// <returns>The tracker's current post</returns>
        public Post getCurrentPost()
        {
            return this.currentPost;
        }
    }
}
