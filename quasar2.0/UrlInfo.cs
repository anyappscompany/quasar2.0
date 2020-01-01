using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace quasar2._0
{
	/// <summary>
	/// Класс для разбора адреса вроде http://jenyay-test.livejournal.com/21741.html на составляющие:
	/// имя пользователя, номер поста, сообщество или нет.
	/// </summary>
	class UrlInfo
	{
		/// <summary>
		/// Имя пользователя или сообщества
		/// </summary>
		public readonly string Journal;


		/// <summary>
		/// Номер поста
		/// </summary>
		public readonly int Id;

		/// <summary>
		/// Это сообщество?
		/// </summary>
		public readonly bool IsCommunity;

		/// <summary>
		/// Исходная ссылка
		/// </summary>
		public readonly string Url;


		public UrlInfo (string url)
		{
			// На всякий случай сохраним строку с адресом
			Url = url;

			// Сюда будем записывать регулярное выражения в зависимости от того, 
			// с какой подстроки начинается адрес
			string urlRe;

			if (url.StartsWith ("http://community.livejournal.com"))
			{
				// Ссылка на сообщество
				IsCommunity = true;
				urlRe = @"http://community.livejournal.com/(?<name>.*)/(?<id>\d+)\.html";
			}
			else if (url.StartsWith ("http://users.livejournal.com") ||
				url.StartsWith ("http://user.livejournal.com"))
			{
				// Ссылка на пользователя в "экзотическом" формате
				IsCommunity = false;
				urlRe = @"http://users?.livejournal.com/(?<name>.*)/(?<id>\d+)\.html";
			}
			else
			{
				// Ссылка на пользователя в приваычном формате
				IsCommunity = false;
				urlRe = @"http://(?<name>.*).livejournal.com/(?<id>\d+)\.html";
			}

			// Найдем имя пользователя (или сообщества) и номер записи
			Match match = Regex.Match (url, urlRe, RegexOptions.IgnoreCase);


			// Проверим все ли было найдено с помощью регулярного выражения
			if (!match.Success)
			{
				throw new FormatException ("Invalud URL format");
			}

			if (!match.Groups["name"].Success)
			{
				throw new FormatException ("Invalud URL format");
			}

			if (!match.Groups["id"].Success)
			{
				throw new FormatException ("Invalud URL format");
			}

			Journal = match.Groups["name"].Value;
			Id = int.Parse (match.Groups["id"].Value);
		}
	}
}
