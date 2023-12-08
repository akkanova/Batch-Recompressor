using Xabe.FFmpeg.Downloader;
using Xabe.FFmpeg;

namespace Batch_Recompressor
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InstallRequiredBinaries().Wait();

            ApplicationConfiguration.Initialize();
            Application.Run(new RecompressForm());
        }

        static async Task InstallRequiredBinaries()
        {
            string localApplicationData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string binaryDirectory = Path.Combine(localApplicationData, "Batch-Recompressor");
            FFmpeg.SetExecutablesPath(binaryDirectory);

            if (!Directory.Exists(binaryDirectory))
                await FFmpegDownloader.GetLatestVersion(FFmpegVersion.Full, binaryDirectory);
        }
    }
}