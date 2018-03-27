using System;
using System.Threading;

namespace ConsoleApp3
{
    public class VideoEventArgs:EventArgs
    {
        public Video Video { get; set; }
    }
    public class VideoEncoder
    {
        //define a delegate
        //define an event based on that delegate
        //raise the event

        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        //EventHandler
        //EventHandler<TEventArgs>

        public event EventHandler<VideoEventArgs> VideoEncoded;

        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        //public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        //public event VideoEncodedEventHandler VideoEncoded;



        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if(VideoEncoded!=null)
            {
                VideoEncoded(this,new VideoEventArgs() { Video=video});
                //VideoEncoded(this, EventArgs.Empty);
            }
        }
    }
}
