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
            //You are missing a step.
            //var handler = MailArrived;
            //if (null != handler)
            //{
            //    handler(this, args);
            //}
            //Or use C# 6 feature: MailArrived?.Invoke(this, args);

            //The step that you missing ins important for threading. what will happen if a delegate will unsubscribe after the check for null? 
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
