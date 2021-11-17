using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Notification3
    {
        public void DoNotify(IMesenger mesenger)
        {
            mesenger.SendMessage();
        }
    }
}
