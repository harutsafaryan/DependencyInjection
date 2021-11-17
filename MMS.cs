using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class MMS : IMesenger
    {
        public void SendMessage()
        {
            Console.WriteLine("sending mms");
        }
    }
}
