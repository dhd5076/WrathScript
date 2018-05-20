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
        private GUI guiForm;

        /// <summary>
        /// Create a new program object and run our main form
        /// </summary>
        private Program()
        {
            guiForm = new GUI();
            Application.Run(guiForm);
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
