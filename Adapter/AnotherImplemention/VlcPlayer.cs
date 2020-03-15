using System;

namespace DesignPatternsImplementation.Adapter
{
    public class VlcPlayer : AdvancedMediaPlayer
    {

        public void playVlc(String fileName)
        {
            Console.WriteLine("Playing vlc file. Name: " + fileName);
        }


        public void playMp4(String fileName)
        {
            //do nothing
        }
    }
}
