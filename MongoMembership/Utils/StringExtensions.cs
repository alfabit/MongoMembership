using System;
using System.Text;

namespace MongoMembership.Utils
{
    internal static class StringExtensions
    {
        public static string F(this string str, params object[] os)
        {
            return String.Format(str, os);
        }

        public static bool IsNullOrWhiteSpace(this string str)
        {
            return String.IsNullOrWhiteSpace(str);
        }

        public static bool IsNullOrEmpty(this string str)
        {
            return String.IsNullOrEmpty(str);
        }

        public static byte[] ToByteArray(this string str)
        {
            return Encoding.Unicode.GetBytes(str);
        }

        public static string ToUnicodeString(this byte[] allBytes, int length)
        {
            return Encoding.Unicode.GetString(allBytes, length, allBytes.Length - length);
        }

        public static string ToBase64String(this byte[] allBytes)
        {
            return Convert.ToBase64String(allBytes);
        }
    }
}