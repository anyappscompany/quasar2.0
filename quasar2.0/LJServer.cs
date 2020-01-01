using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

using System.Security;
using System.Net;
using System.IO;
using System.Web;
using System.Collections.Specialized;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Threading;

namespace quasar2._0
{
	public class LJServer
	{
		/// <summary>
		/// Сделать словарь из полученных в ходе запроса значений
		/// </summary>
		/// <param name="response"></param>
		/// <returns></returns>
		private StringDictionary MakeDict (string response)
		{
			string[] split = response.Split ("\n".ToCharArray ());

			StringDictionary dict = new StringDictionary ();
			for (int i = 0; i < split.Length - 1; i += 2)
			{
				dict[split[i]] = split[i + 1];
			}

			return dict;
		}

		readonly string ServerApiUri = "http://livejournal.com/interface/flat"; 

		string GetChallenge ()
		{
			string request = "mode=getchallenge";
			string challengeResponse = SendRequest (ServerApiUri, request, null);

			StringDictionary dict = MakeDict (challengeResponse);
			if (dict["success"] == "OK")
			{
				return dict["challenge"];
			}

			return "";
		}

		//ILog _log;        
        private string ip1;
        private int port1;
        private string uag1;
        ListBox li;
		public LJServer (string ip, int port, string uag, ListBox li)
		{
            this.li = li; 
            this.ip1 = ip;
            this.port1 = port;
            this.uag1 = uag;
		}


		/// <summary>
		/// Просто загрузить страницу
		/// </summary>
		/// <param name="url"></param>
		/// <returns></returns>
        private WebResponse GetResponseGetPage(string url, CookieCollection cookies)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            try
            {
                request.UserAgent = uag1;
                request.KeepAlive = false;
                request.Method = "GET";
                request.AllowAutoRedirect = true;
                request.Proxy = new WebProxy(ip1, port1);
                request.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
                request.Timeout = Timeout.Infinite;
                request.CookieContainer = new CookieContainer();
                if (cookies != null)
                {
                    request.CookieContainer.Add(cookies);
                }
                return request.GetResponse();
            }
            catch
            {
                RndProxy prox = new RndProxy(li);
                this.ip1 = prox.GetProxy().IP;
                this.port1 = prox.GetProxy().Port;
                return null;
            }
        }

		public string GetPage (string url, CookieCollection cookies)
		{
            label1:
            WebResponse WR;
            string currResponse="";
            while ((WR = GetResponseGetPage(url, cookies)) == null)
            {
                Thread.Sleep(15000);
            }
            if (WR != null)
            {
                // Читаем ответ
                Stream responseStream;
                responseStream = WR.GetResponseStream();

                StreamReader readStream;
                readStream = new StreamReader(responseStream, Encoding.UTF8);


                currResponse = readStream.ReadToEnd();
                readStream.Close();
                WR.Close();
            }
            else
            {
                goto label1;
            }
			return currResponse;
		}

		/// <summary>
		/// Получить базовые cookies для доступа журналу и подзамочным записям
		/// </summary>
		/// <param name="login">Имя пользователя</param>
		/// <param name="password">Пароль</param>
		/// <returns>Возвращает полученные cookies</returns>
		public CookieCollection GetBaseCookie (string login, string password)
		{
			string lj_login_chal = GetChallenge ();

			// Рассчитаем ответ как в методе авторизации challenge / response
			string auth_response = GetAuthResponse (password, lj_login_chal);

			// Строка запроса для отправки через форму
			string textRequest = string.Format ("chal={0}&response={1}&user={2}",
				HttpUtility.UrlEncode (lj_login_chal),
				HttpUtility.UrlEncode (auth_response),
				HttpUtility.UrlEncode (login));
			 
			// Выводим в лог посылаемый запрос
			/*_log.WriteLine ("\r\n*** Request:");
			_log.WriteLine (textRequest);*/

			byte[] byteArray = Encoding.UTF8.GetBytes (textRequest);

			// Получаем класс запроса
			HttpWebRequest request =
				(HttpWebRequest)WebRequest.Create ("http://www.livejournal.com/login.bml");

			// Заполняем параметры запроса
			request.Method = "POST";

			// Запрещаем автоматический редирект, чтобы сохранить cookies, полученные на первой странице после запроса
			request.AllowAutoRedirect = false;
			request.ContentType = "application/x-www-form-urlencoded";
			request.ContentLength = textRequest.Length;
			request.UserAgent = "LJServerTest";
            request.UserAgent = uag1;
            request.Proxy = new WebProxy(ip1, port1);
            request.Timeout = Timeout.Infinite;
			// Очищаем коллекцию от старых cookie и добавляем туда новые
			request.CookieContainer = new CookieContainer ();

			// Отправляем данные запроса
			Stream requestStream = request.GetRequestStream ();
			requestStream.Write (byteArray, 0, textRequest.Length);

			// Получаем класс ответа
			HttpWebResponse response = (HttpWebResponse)request.GetResponse ();

			// Читаем ответ
			Stream responseStream = response.GetResponseStream ();
			StreamReader readStream = new StreamReader (responseStream, Encoding.UTF8);

			string currResponse = readStream.ReadToEnd ();

			// Выводим в лог ответ сервера
			/*_log.WriteLine ("\r\n*** Response:");
			_log.WriteLine (currResponse);*/

			readStream.Close ();
			response.Close ();

			// Оставим только самые необходимые cookies
			CookieCollection newCollection = new CookieCollection ();
			for (int i = 0; i < response.Cookies.Count; i++)
			{
				if (response.Cookies[i].Name == "ljloggedin" ||
					response.Cookies[i].Name == "ljmastersession")
				{
					newCollection.Add (response.Cookies[i]);
				}
			}

			// Выведем в лог только полезные cookie
			/*_log.WriteLine ("\r\n*** Cookies:");
			for (int i = 0; i < newCollection.Count; i++)
			{
				_log.WriteLine (newCollection[i].ToString ());
			}*/

			return newCollection;
		}

		/// <summary>
		/// Посчитать md5. Взято у lj.net. http://lj-net.cvs.sourceforge.net/lj-net/lj-net/Utils.cs?view=markup
		/// </summary>
		/// <param name="text"></param>
		/// <returns></returns>
		private string ComputeMD5 (string text)
		{
			MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider ();
			byte[] hashBytes = md5.ComputeHash( Encoding.UTF8.GetBytes( text ) );

			StringBuilder sb = new StringBuilder();

			foreach( byte hashByte in hashBytes )
				sb.Append( Convert.ToString( hashByte, 16 ).PadLeft( 2, '0' ) );

			return sb.ToString();
		}

		/// <summary>
		/// Вычисление ответа на оклик
		/// </summary>
		/// <param name="password"></param>
		/// <param name="challenge"></param>
		/// <returns></returns>
		private string GetAuthResponse (string password, string challenge)
		{
			// md5 от пароля
			string hpass = ComputeMD5 (password);

			string constr = challenge + hpass;
			string auth_response = ComputeMD5 (constr);

			return auth_response;
		}


		/// <summary>
		/// Отправить запрос
		/// </summary>
		/// <param name="url">Адрес, по которому отправляется запрос</param>
		/// <param name="textRequest">Текст запроса</param>
		/// <param name="cookies">Куки, которые будут прицеплены к запросу</param>
		/// <returns></returns>
        /// 
        private WebResponse GetResponseSendRequest(string url, string textRequest, CookieCollection cookies)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            byte[] byteArray = Encoding.UTF8.GetBytes(textRequest);
            try
            {
                request.UserAgent = uag1;
                request.KeepAlive = false;
                request.Method = "POST";
                request.ContentLength = byteArray.Length;
                request.AllowAutoRedirect = false;
                request.ContentType = "application/x-www-form-urlencoded";
                request.UserAgent = uag1;
                request.Timeout = Timeout.Infinite;
                request.Proxy = new WebProxy(ip1, port1);                
                request.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
                request.CookieContainer = new CookieContainer();
                
                if (cookies != null)
                {
                    request.CookieContainer.Add(cookies);
                }
                Stream requestStream = request.GetRequestStream();
                requestStream.Write(byteArray, 0, byteArray.Length);

                return request.GetResponse();
            }
            catch
            {
                RndProxy prox = new RndProxy(li);
                this.ip1 = prox.GetProxy().IP;
                this.port1 = prox.GetProxy().Port;
                return null;
            }
        }

		private string SendRequest (string url, 
			string textRequest, 
			CookieCollection cookies)
		{            
        label1:
            WebResponse WR;
            string currResponse = "";
            while ((WR = GetResponseSendRequest(url, textRequest, cookies)) == null)
            {
                Thread.Sleep(15000);
            }
            if (WR != null)
            {
                // Читаем ответ
                Stream responseStream;
                responseStream = WR.GetResponseStream();

                StreamReader readStream;
                readStream = new StreamReader(responseStream, Encoding.UTF8);


                currResponse = readStream.ReadToEnd();
                readStream.Close();
                WR.Close();
            }
            else
            {
                goto label1;
            }
            return currResponse;			
		}



		/// <summary>
		/// Отправить комментарий
		/// </summary>
		/// 
		/// <param name="login">Логин пользователя, 
		/// от имени которого нужно отправить комментарий</param>
		/// 
		/// <param name="password">Пароль пользователя</param>
		/// 
		/// <param name="url">Адрес поста, к которому нужно отправить комментарий</param>
		/// 
		/// <param name="message">Текст комментария</param>
		/// 
		/// <param name="subj">Заголовок комментария. 
		/// Можно передавать пустую строку</param>
		/// 
		/// <param name="parent">Идентификатор комментария, на который надо ответить. 
		/// Если комментарий должен относиться к посту циликом, 
		/// нужно этот параметр должен быть равен 0</param>
		/// 
		public void PostComment (string login, 
			string password, 
			string url,
			string message, 
			string subj, 
			int parent, CookieCollection cookies1)
		{
			// Разберем ссылку на составные части
			UrlInfo urlElements;

			try
			{
				urlElements = new UrlInfo (url);
			}
			catch (FormatException e)
			{
				//_log.WriteLine (e.Message);
				throw;
			}

			/*_log.WriteLine ("Parsing URL...");
			_log.WriteLine (string.Format ("Username: {0}", urlElements.Journal));
			_log.WriteLine (string.Format ("Post ID: {0}", urlElements.Id));*/

			CookieCollection cookies = cookies1;

			// Прочитаем страницу с формой отправки комментария
			string text;

			try
			{
				text = GetPage (url, cookies);
			}
			catch (WebException e)
			{
				//_log.WriteLine (e.ToString());
				throw new FormatException ("URL Error", e);
			}


			string lj_form_auth;
            try
            {
                lj_form_auth = GetLjFormAuth(text);
            }
            catch
            {
                return;
            }

			// В логине надо заменить все '-' на '_'
			string cookieuser = login.Replace ('-', '_');
			string journal = urlElements.Journal.Replace ('-', '_');

			// Сформируем запрос
			StringBuilder sb = new StringBuilder ();
			sb.AppendFormat ("usertype=cookieuser&");
			sb.AppendFormat ("subject={0}&", HttpUtility.UrlEncode (subj));
			sb.AppendFormat ("body={0}&", HttpUtility.UrlEncode (message));
			sb.AppendFormat ("lj_form_auth={0}&", HttpUtility.UrlEncode (lj_form_auth));
			sb.AppendFormat ("cookieuser={0}&", cookieuser);
			sb.AppendFormat ("journal={0}&", journal);
			sb.AppendFormat ("itemid={0}&", urlElements.Id);
			sb.AppendFormat ("parenttalkid={0}&", parent);

			string request = sb.ToString ();

			// Запрос надо отправлять по этому адресу
			string urlServer = "http://www.livejournal.com/talkpost_do.bml";

            try
            {
                SendRequest(urlServer, request, cookies);
            }
            catch
            {
                //
            }
		}

		private string GetLjFormAuth (string text)
		{
			/*_log.WriteLine ("");
			_log.WriteLine ("Parsing Form...");*/


			// Найдем параметр lj_form_auth внутри формы
			string authFormRe = 
				"(\\\\)?\"lj_form_auth(\\\\)?\" value=(\\\\)?\"(?<auth>.*?)(\\\\)?\"";

			string lj_form_auth =
				Regex.Match (text, 
				authFormRe, 
				RegexOptions.Multiline | RegexOptions.IgnoreCase).Groups["auth"].Value;


			//_log.WriteLine (string.Format ("auth: {0}", lj_form_auth));

			if (lj_form_auth.Length == 0)
			{
				throw new FormatException ();
			}
			return lj_form_auth;
		}
        private bool capcha(String cont1)
        {
            string pattern2 = @"<script\s*src=""http://api.recaptcha.net/";
            Regex exp2 = new Regex(pattern2, RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.IgnorePatternWhitespace);
            MatchCollection matchList2 = exp2.Matches(cont1);
            if (matchList2.Count > 0)
            {
                for (int i = 0; i < matchList2.Count; i++)
                {
                    //Console.WriteLine(matchList2[i]);
                }
                return true;
            }
            return false;
        }
        private bool forma(String cont1)
        {
            string pattern2 = @"<textarea\s*class='textbox'\s*rows='10'\s*cols='75'\s*wrap='soft'\s*name='body'\s*id='commenttext'\s*tabindex='20'></textarea>";
            Regex exp2 = new Regex(pattern2, RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.IgnorePatternWhitespace);
            MatchCollection matchList2 = exp2.Matches(cont1);
            if (matchList2.Count > 0)
            {
                for (int i = 0; i < matchList2.Count; i++)
                {
                    //Console.WriteLine(matchList2[i]);
                }
                return true;
            }
            return false;
        }
        private bool commentdisabl(String cont1)
        {
            string pattern2 = @"<h2>Comments\s*Disabled:</h2>";
            Regex exp2 = new Regex(pattern2, RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.IgnorePatternWhitespace);
            MatchCollection matchList2 = exp2.Matches(cont1);
            if (matchList2.Count > 0)
            {
                for (int i = 0; i < matchList2.Count; i++)
                {
                    //Console.WriteLine(matchList2[i]);
                }
                return true;
            }
            return false;
        }
        private bool friendsonly(String cont1)
        {
            String pattern2 = @"friends\sonly";
            Regex exp2 = new Regex(pattern2, RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.IgnorePatternWhitespace);
            MatchCollection matchList2 = exp2.Matches(cont1);
            if (matchList2.Count > 0)
            {
                for (int i = 0; i < matchList2.Count; i++)
                {
                    //Console.WriteLine(matchList2[i]);
                }
                return true;
            }
            return false;
        }
        private string validc;
        public bool Valid(string content)
        {
            validc = content;
            if (!capcha(validc) && forma(validc) && !commentdisabl(validc) && !friendsonly(validc))
            {
                return true;
            }
            return false;
        }
        public string GetRndPost(string content, string user)
        {
            string page = "";
            string user1 = "";
            page = content;
            user1 = user;
            
            string pattern2 = @"<a(\s*)href=""http://" + user1 + @".livejournal.com/[0-9]{1,10}.html\?mode=reply""";
            Regex exp2 = new Regex(pattern2, RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.IgnorePatternWhitespace);
            MatchCollection matchList2 = exp2.Matches(page);
            
            if (matchList2.Count > 0)
            {
                //MessageBox.Show(page);
                Random rnd = new Random();
                //StrComment = li.Items[rnd.Next(li.Items.Count)].ToString();
                string str2;
                str2 = ((Match)matchList2[rnd.Next(matchList2.Count)]).Value.ToString();
                str2 = str2.Remove(0, 16);

                int founds2 = str2.IndexOf("?mode=reply\"");
                str2 = str2.Remove(founds2);

                return str2;
            }
            else
            {
                //MessageBox.Show(matchList2.Count.ToString());
                return null;
            }
        }

	}	// public class LJServer
}
