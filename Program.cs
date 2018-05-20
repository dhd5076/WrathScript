using FrustrationBot.Input;
using FrustrationBot.Posts;
using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace FrustrationBot
{
    class Program
    {
        private GUI guiForm = new GUI();
        private HRComReader hrComReader;
        private PostTracker postTracker;

        /// <summary>
        /// Create a new program object
        /// </summary>
        private Program()
        {

        }

        /// <summary>
        /// Entry point to the application
        /// </summary>
        /// <param name="args">Command Line Arguments</param>
        static void Main(string[] args)
        {
            new Program();
        }
    }
}
