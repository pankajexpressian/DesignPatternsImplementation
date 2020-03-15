using System;

namespace DesignPatternsImplementation.Adapter
{
    public interface AdvancedMediaPlayer
    {
        public void playVlc(String fileName);
        public void playMp4(String fileName);
    }
}
