namespace MailSystem
{
    public class MailArrivedEventArgs
    {
        public readonly string Title;
        public readonly string Body;

        public MailArrivedEventArgs(string title, string body)
        {
            this.Title = title;
            this.Body = body;
            System.Console.WriteLine(title);
            System.Console.WriteLine(body);
        }
    }
}