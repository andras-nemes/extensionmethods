using System;

namespace ExtensionMethods.Extensions.Basics
{
    public static class SampleExtensions
    {
        public static string ToCustomFormat(this DateTime dateTime)
        {
            return "This is some custom datetime format.";
        }

        public static string ToEmail(this string fullName, string nickName, int yearOfBirth)
        {
            return string.Concat(fullName.ToLower().Replace(" ", "."), yearOfBirth, "@", nickName.ToLower().Replace(" ", string.Empty), ".com");
        }
    }
}