namespace Batch_Recompressor.Core
{
    public class GlobalSettings
    {
        private static GlobalSettings? s_instance;
        private static readonly object s_lock;

        public static GlobalSettings Instance { 
            get
            {
                s_instance ??= LoadSettings();
                return s_instance;
            }
        }

        static GlobalSettings()
        {
            s_lock = new();
        }

        private static GlobalSettings LoadSettings()
        {
            lock (s_lock) 
            { 
                if (s_instance is not null)
                    return s_instance;

                // Complex Load Something

                return new GlobalSettings();  
            }
        }

        public string DefaultOutputDirectory { get; set; }
        public string FFMpegExecutablePath  { get; set; }
        public string FFProbeExecutablePath { get; set; }

        private GlobalSettings()
        {
            DefaultOutputDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
            FFProbeExecutablePath = string.Empty;
            FFMpegExecutablePath = string.Empty;
        }

        public void Save()
        {
            // Save this instance
        }
    }
}
