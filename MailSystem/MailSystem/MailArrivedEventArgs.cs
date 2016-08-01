namespace MailSystem
{
    public class MailArrivedEventArgs
    {
        //There are fields and not properties.
        public readonly string Title;
        public readonly string Body;

        public MailArrivedEventArgs(string title, string body)
        {
            this.Title = title;
            this.Body = body;

            //These shouldn't be here.
            //System.Console.WriteLine(title);
            //System.Console.WriteLine(body);
        }
    }
}