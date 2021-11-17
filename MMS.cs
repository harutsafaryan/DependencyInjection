using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class MMS : IMesenger
    {
        public void SendMessage(string text)
        {
            Console.WriteLine($"sending mms: {text}");
        }
    }
}
