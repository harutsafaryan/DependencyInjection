using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Notification1
    {
        IMesenger _mesenger;
        public string Text { get; set; }
        public Notification1(IMesenger mesenger)
        {
            _mesenger = mesenger;
        }

        public void DoNotify()
        {
            _mesenger.SendMessage(Text);
        }
    }
}
