using System;
using System.IO;
using System.Media;

namespace CybersecurityBot
{
    static class AudioManager
    {
        public static void PlayGreeting()
        {
            string[] searchDirs = { AppDomain.CurrentDomain.BaseDirectory, Directory.GetCurrentDirectory() };

            string wavPath = null;
            foreach (string dir in searchDirs)
            {
                try
                {
                    var wavFiles = Directory.GetFiles(dir, "*.wav", SearchOption.TopDirectoryOnly);
                    if (wavFiles.Length > 0) { wavPath = wavFiles[0]; break; }
                }
                catch { }
            }

            if (!string.IsNullOrEmpty(wavPath))
            {
                using (var player = new SoundPlayer(wavPath))
                {
                    player.Load();
                    player.PlaySync();
                }
                return;
            }

            try { Console.Beep(800, 200); } catch { }
        }
    }
}