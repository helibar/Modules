using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MailSystem
{
    class Program
    {
        static Timer timer;
        static MailManager mailManager = new MailManager();

        static void Main(string[] args)
        {
            CallBack();
            Console.ReadLine();
        }

        private static void CallBack()
        {
            //YOu didn't subscribe to the event.
            //mailManager.MailArrived += (sender, args) => Console.WriteLine($"Title: {args.Title}, Body: {args.Body}");

            //start in 1 second, every 1 second
            timer = new Timer(_ => mailManager.SimulateMailArrived(), null, 1000, 1000);
        }
    }
}
