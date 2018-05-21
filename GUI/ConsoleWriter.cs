using System;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace FrustrationBot
{
    /// <summary>
    /// Code from: https://saezndaree.wordpress.com/2009/03/29/how-to-redirect-the-consoles-output-to-a-textbox-in-c/
    /// Aims to redirect console output to a form textbox
    /// </summary>
    public class ConsoleWriter : TextWriter
    {
        TextBox _output = null;

        public ConsoleWriter(TextBox output)
        {
            _output = output;
        }

        public override void Write(char value)
        {
            base.Write(value);
            _output.Invoke((MethodInvoker)(() =>
            {
                _output.AppendText(value.ToString());
            }));

        }

        public override Encoding Encoding
        {
            get { return System.Text.Encoding.UTF8; }
        }
    }
}
