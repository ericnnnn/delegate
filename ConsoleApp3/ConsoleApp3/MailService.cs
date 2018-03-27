using System;

namespace ConsoleApp3
{
    public class MailService
    {
        public void OnVideoEncoded(object source,VideoEventArgs e)
        //public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("Mailservice: sending an email...."+e.Video.Title);
            //Console.WriteLine("Mailservice: sending an email....");
        }
    }
}
