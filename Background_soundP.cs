using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace the_incident_in_Ravda
{
    public static class Background_soundP
    {
        private static SoundPlayer player;

        public static void Start()
        {
            if (player == null)
            {
                player = new SoundPlayer("scary_background_music.wav"); // Path to your WAV file
                player.LoadAsync();
                player.PlayLooping(); // Loop the sound
            }
        }

        public static void Stop()
        {
            player?.Stop();
        }
    }
}
