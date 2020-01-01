using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace quasar2._0
{
	/// <summary>
	/// ����� ��� ������� ������ ����� http://jenyay-test.livejournal.com/21741.html �� ������������:
	/// ��� ������������, ����� �����, ���������� ��� ���.
	/// </summary>
	class UrlInfo
	{
		/// <summary>
		/// ��� ������������ ��� ����������
		/// </summary>
		public readonly string Journal;


		/// <summary>
		/// ����� �����
		/// </summary>
		public readonly int Id;

		/// <summary>
		/// ��� ����������?
		/// </summary>
		public readonly bool IsCommunity;

		/// <summary>
		/// �������� ������
		/// </summary>
		public readonly string Url;


		public UrlInfo (string url)
		{
			// �� ������ ������ �������� ������ � �������
			Url = url;

			// ���� ����� ���������� ���������� ��������� � ����������� �� ����, 
			// � ����� ��������� ���������� �����
			string urlRe;

			if (url.StartsWith ("http://community.livejournal.com"))
			{
				// ������ �� ����������
				IsCommunity = true;
				urlRe = @"http://community.livejournal.com/(?<name>.*)/(?<id>\d+)\.html";
			}
			else if (url.StartsWith ("http://users.livejournal.com") ||
				url.StartsWith ("http://user.livejournal.com"))
			{
				// ������ �� ������������ � "������������" �������
				IsCommunity = false;
				urlRe = @"http://users?.livejournal.com/(?<name>.*)/(?<id>\d+)\.html";
			}
			else
			{
				// ������ �� ������������ � ���������� �������
				IsCommunity = false;
				urlRe = @"http://(?<name>.*).livejournal.com/(?<id>\d+)\.html";
			}

			// ������ ��� ������������ (��� ����������) � ����� ������
			Match match = Regex.Match (url, urlRe, RegexOptions.IgnoreCase);


			// �������� ��� �� ���� ������� � ������� ����������� ���������
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
