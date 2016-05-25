using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Labirint
{
    public static class Sound
    {
        static SoundPlayer sound_fail = new SoundPlayer(Properties.Resources.Alarm02);
        static SoundPlayer sound_key = new SoundPlayer(Properties.Resources.Alarm03);
        static SoundPlayer sound_start = new SoundPlayer(Properties.Resources.Alarm06);
        static SoundPlayer sound_youwin = new SoundPlayer(Properties.Resources.Alarm01);
        static bool sound_enebled = true;

        public static void sound_on()
        {
            sound_enebled = true;
        }
        public static void sound_off()
        {
            sound_enebled = false;
        }


        public static void play_fail()
        {
            if (sound_enebled)
            sound_fail.Play();
        }

        public static void play_key()
        {
            if (sound_enebled)
                sound_key.Play();
        }

        public static void play_start()
        {
            if (sound_enebled)
                sound_start.Play();
        }

        public static void play_youwin()
        {
            if (sound_enebled)
                sound_start.Play();
        }
    }
}
