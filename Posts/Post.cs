using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedditSharp;
namespace FrustrationBot
{
    class Post
    {
        private string title;
        private string imgURL;
        private int avgBPM;

        public Post()
        {
           
        }

        public string getTitle() { return this.title; }
    }
}
