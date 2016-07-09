using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSystem
{
    class MailManager
    {
        public event EventHandler<MailArrivedEventArgs> MailArrived;

        //raise the event
        protected virtual void OnMailArrived(MailArrivedEventArgs args)
        {
            if (MailArrived != null)
            {
                MailArrived(this, args);
            }
        }


        public void SimulateMailArrived()
        {
            this.OnMailArrived(new MailArrivedEventArgs("This is title.", "This is body..."));
        }

    }
}
