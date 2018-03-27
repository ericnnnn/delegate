using System;

namespace ConsoleApp3
{
    public class MessagerService
    {
        public void OnVideoEncoded(object source,VideoEventArgs args)
        //public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("MessageService: Sending a text message...."+args.Video.Title);
            //Console.WriteLine("MessageService: Sending a text message....");
        }
    }
}
