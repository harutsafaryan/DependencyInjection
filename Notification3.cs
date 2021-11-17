using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Notification3
    {
        public string Text { get; set; }
        public void DoNotify(IMesenger mesenger)
        {
            mesenger.SendMessage(Text);
        }
    }
}
