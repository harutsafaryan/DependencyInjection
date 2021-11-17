using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Notification2
    {
        private IMesenger _mesenger;
        public string Text { get; set; }

        public Notification2()
        {
        }

        public IMesenger MessagaService
        {
            private get
            {
                return _mesenger;
            }
            set
            {
                _mesenger = value;
            }
        }

        public void DoNotify()
        {
            _mesenger.SendMessage(Text);
        }
    }
}
