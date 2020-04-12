using System;
using System.Text;

namespace YGO7.Core.Extensions
{
	public static class StringExtensions
	{
		public static string RemoveDiacritics(this string text)
		{
			if (string.IsNullOrWhiteSpace(text))
			{
				return text;
			}

			byte[] bytes = Encoding.GetEncoding("Cyrillic").GetBytes(text);
			return Encoding.ASCII.GetString(bytes);
		}

		public static string[] SplitTextoPesquisa(this string text)
		{
			if (string.IsNullOrEmpty(text))
			{
				return new string[0];
			}

			return text.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
		}
	}
}
