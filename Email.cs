using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Email : IMesenger
    {
        public void SendMessage(string text)
        {
            Console.WriteLine($"sending email: {text}");
        }
    }
}
