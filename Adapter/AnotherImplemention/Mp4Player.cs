using System;

namespace DesignPatternsImplementation.Adapter
{
    public class Mp4Player : AdvancedMediaPlayer
    {


        public void playVlc(String fileName)
        {
            //do nothing
        }


        public void playMp4(String fileName)
        {
            Console.WriteLine("Playing mp4 file. Name: " + fileName);
        }
    }
}
