using System;
using System.Text.RegularExpressions;

namespace AirplaneProject.Application.Extensions
{
    public static class StringExtension
    {
        public static string ToCamelCase(this string source)
        {
            // If there are 0 or 1 characters, just return the string.
            if (source == null || source.Length < 2)
                return source;

            if (source.Equals(source.ToUpper()))
                return source.ToLower();

            // Split the string into words.
            string[] words = Regex.Split(source, @"(?<!^)(?=[A-Z])");

            // Combine the words.
            string result = words[0].ToLower();
            for (int i = 1; i < words.Length; i++)
            {
                result +=
                    words[i].Substring(0, 1).ToUpper() +
                    words[i].Substring(1);
            }

            return result;
        }

        public static string ToPascalCase(this string source)
        {
            // If there are 0 or 1 characters, just return the string.
            if (source == null) return source;
            if (source.Length < 2) return source.ToUpper();

            // Split the string into words.
            string[] words = Regex.Split(source, @"(?<!^)(?=[A-Z])");

            // Combine the words.
            string result = "";
            foreach (string word in words)
            {
                result +=
                    word.Substring(0, 1).ToUpper() +
                    word.Substring(1);
            }

            return result;
        }

        // Capitalize the first character and add a space before
        // each capitalized letter (except the first character).
        public static string ToProperCase(this string source)
        {
            // If there are 0 or 1 characters, just return the string.
            if (source == null) return source;
            if (source.Length < 2) return source.ToUpper();

            // Split the string into words.
            string[] words = source.ToLower().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            // Combine the words.
            string result = "";
            foreach (string word in words)
            {
                result +=
                    word.Substring(0, 1).ToUpper() +
                    word.Substring(1) + " ";
            }

            return result.Trim();
        }

        public static string ToSlug(this string phrase)
        {
            string str = phrase.RemoveAccent().ToLower();

            str = Regex.Replace(str, @"[^a-z0-9\s-]", ""); // invalid chars           
            str = Regex.Replace(str, @"\s+", " ").Trim(); // convert multiple spaces into one space   
            //str = str.Substring(0, str.Length <= 45 ? str.Length : 45).Trim(); // cut and trim it   
            str = str.Trim(); // cut and trim it   
            str = Regex.Replace(str, @"\s", "-"); // hyphens   

            return str;
        }

        public static string RemoveAccent(this string txt)
        {
            byte[] bytes = System.Text.Encoding.GetEncoding("Cyrillic").GetBytes(txt);
            return System.Text.Encoding.ASCII.GetString(bytes);
        }

        public static int ToInt32(this string s)
        {
            int i;
            int.TryParse(s, out i);
            return i;
        }
    }
}
