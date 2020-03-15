using System;

namespace DesignPatternsImplementation.Adapter
{

    public class MediaAdapter : MediaPlayer
    {

        AdvancedMediaPlayer advancedMusicPlayer;

        public MediaAdapter(String audioType)
        {

            if (audioType == ("vlc"))
            {
                advancedMusicPlayer = new VlcPlayer();

            }
            else if (audioType == ("mp4"))
            {
                advancedMusicPlayer = new Mp4Player();
            }
        }


        public void play(String audioType, String fileName)
        {

            if (audioType == ("vlc"))
            {
                advancedMusicPlayer.playVlc(fileName);
            }
            else if (audioType == ("mp4"))
            {
                advancedMusicPlayer.playMp4(fileName);
            }
        }
    }

}
