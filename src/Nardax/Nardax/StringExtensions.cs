using System;
using System.ComponentModel;
<<<<<<< HEAD
using System.Text;
=======
using System.Text.RegularExpressions;
>>>>>>> 06ea28bbd70daa4eb8931d841d721e1707a8ad33

namespace Nardax
{
    public static class StringExtensions
    {
        public static string TruncateLeft(this string value, int maxLength)
        {
            var startIndex = value.Length - maxLength;

            if (startIndex < 1)
            {
                return value;
            }

            return value.Substring(startIndex, maxLength);
        }

        public static string TruncateRight(this string value, int maxLength)
        {
            if (value.Length < maxLength)
            {
                return value;
            }

            return value.Substring(0, maxLength);
        }


        public static string RepeatMe(this string value, int times)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < times; i++)
            {
                sb.Append(value);
            }
            return sb.ToString();


        public static string RemoveWhiteSpace(this string value)
        {
            return Regex.Replace(value, "\\s", "");

        }
    }
}
