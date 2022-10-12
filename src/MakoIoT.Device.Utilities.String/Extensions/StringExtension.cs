using System.Text;

namespace MakoIoT.Device.Utilities.String.Extensions
{
    public static class StringExtension
    {
        /// <summary>
        /// Escapes curly braces, so the string can be used for interpolation.
        /// </summary>
        /// <param name="s">The string</param>
        /// <returns>Escaped string</returns>
        public static string EscapeForInterpolation(this string s)
        {
            var builder = new StringBuilder(s);
            builder.Replace("{", "{{").Replace("}", "}}");
            return builder.ToString();
        }
    }
}
