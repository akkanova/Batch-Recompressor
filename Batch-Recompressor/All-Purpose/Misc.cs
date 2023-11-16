using System.Text.RegularExpressions;

namespace Batch_Recompressor.AllPurpose
{
    internal class Misc
    {
        public static string ToHumanReadable(ulong fileSizeBytes)
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

        /// <summary>
        /// Converts PascalCase to a normal sentence
        /// </summary>
        /// <param name="input">PascalCaseString</param>
        /// <returns>Sentence Case String</returns>
        public static string ToSentenceCase(string input)
        {
            return Regex.Replace(input, "[a-z][A-Z]",
                matches => $"{matches.Value[0]} {matches.Value[1]}");
        }
    }
}
