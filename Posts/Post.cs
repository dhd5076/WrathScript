using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedditSharp;
namespace FrustrationBot
{
    /// <summary>
    /// The class for handling the data of each post that is being evaluated
    /// </summary>
    class Post
    {
        public const int NUM_OF_DATA_POINTS = 10;

        public string title;
        public string text;
        public double avgBPM;
        private List<int> dataPoints;

        /// <summary>
        /// Create a new post object
        /// </summary>
        /// <param name="title"></param>
        /// <param name="text"></param>
        public Post(string title, string text)
        {
            this.title = title;
            this.text = text;
            this.dataPoints = new List<int>();
        }

        /// <summary>
        /// Add a new data point
        /// </summary>
        /// <param name="data"></param>
        public void AddBPM_Data(int dataPoint)
        {
            this.dataPoints.Add(dataPoint);
        }

        /// <summary>
        /// Called when the tracker is done with this post. Calculates the average data from the points collected;
        /// </summary>
        public void Finished()
        {
            this.avgBPM = dataPoints.Average();
        }
    }
}
