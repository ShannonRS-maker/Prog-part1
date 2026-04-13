using System;
using System.IO;
using System.Media;

namespace CybersecurityBot
{
    static class AudioManager
    {
        public static void PlayGreeting()
        {
            try
            {
                string exeDir = AppContext.BaseDirectory;
                string currentDir = Environment.CurrentDirectory;

                string[] searchDirs = new string[] { exeDir, currentDir };
                string[] fileNames = new string[] { "greeting.wav", "Greeting.wav" };

                string wavPath = null;

                foreach (string dir in searchDirs)
                {
                    foreach (string name in fileNames)
                    {
                        string candidate = Path.Combine(dir, name);
                        if (File.Exists(candidate))
                        {
                            wavPath = candidate;
                            break;
                        }
                    }
                    if (wavPath != null) break;
                }

                if (wavPath == null)
                {
                    foreach (string dir in searchDirs)
                    {
                        try
                        {
                            var wavFiles = Directory.GetFiles(dir, "*.wav", SearchOption.TopDirectoryOnly);
                            if (wavFiles.Length > 0) { wavPath = wavFiles[0]; break; }
                        }
                        catch { }
                    }
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
                else
                {
                    Console.WriteLine($"[Audio] greeting.wav not found. Searched:");
                    Console.WriteLine($"  {exeDir}");
                    Console.WriteLine($"  {currentDir}");
                }
            }
            catch (PlatformNotSupportedException)
            {
                Console.WriteLine("[Audio] SoundPlayer not supported on this platform.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Audio] Playback error: {ex.Message}");
            }

            try { Console.Beep(800, 200); } catch { }
        }
    }
}
