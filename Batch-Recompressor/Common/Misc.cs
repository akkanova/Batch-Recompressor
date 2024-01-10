namespace Batch_Recompressor.Common
{
    public class Misc
    {
        public static string FileSizeToString(ulong fileSizeBytes)
        {
            string[] suffixes = { "B", "KiB", "MiB", "GiB", "TiB" };
            double size = fileSizeBytes;

            int order = 0;
            while (size >= 1024 && order < suffixes.Length - 1)
            {
                order++;
                size /= 1024;
            }

            return string.Format("{0:0.##} {1}", size, suffixes[order]);
        }
    }
}
