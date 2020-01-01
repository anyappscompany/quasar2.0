using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Text.RegularExpressions;

namespace quasar2._0
{
    class LJRatings
    {
        private string ip;
        private int port;
        private string uagent;
        private ListBox li;
        private RichTextBox rtb;        
        delegate void AddText(string text, Color color);
        void WriteLog(string text, Color color)
        {

            if (this.rtb.InvokeRequired)
            {
                this.rtb.BeginInvoke(new AddText(WriteLog), new object[] { text, color });
            }
            else
            {
                if ((this.rtb.Lines.Length) > 100)
                {
                    this.rtb.Text = string.Empty;
                }
                this.rtb.Select(0, 0);
                Font font = new Font("Tahoma", 8, FontStyle.Regular);
                this.rtb.SelectionFont = font;
                this.rtb.SelectionColor = color;
                this.rtb.SelectedText = text + Environment.NewLine;
            }
        }

        public LJRatings(ListBox li, RichTextBox rtb)
        {            
            this.li = li;
            this.rtb = rtb;
            RndProxy prox = new RndProxy(li);
            RndUAgent uag = new RndUAgent();
            this.ip = prox.GetProxy().IP;
            this.port = prox.GetProxy().Port;
            uagent = uag.GetUA();
        }
        private WebResponse GetResponse(string url, bool redirect)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            try
            {
                request.UserAgent = uagent;
                request.KeepAlive = false;
                request.Method = "GET";
                request.AllowAutoRedirect = redirect;
                request.Proxy = new WebProxy(ip, port);
                request.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
                request.Timeout = Timeout.Infinite;
                return request.GetResponse();
            }
            catch
            {
                RndProxy prox = new RndProxy(li);                
                this.ip = prox.GetProxy().IP;
                this.port = prox.GetProxy().Port;
                return null;
            }
        }
        public string GetContent(string url)
        {
            label1:
            WebResponse WR;
            string content = "";
            Font font = new Font("Tahoma", 8, FontStyle.Regular);

            while ((WR=GetResponse(url, false)) == null)
            {
                WriteLog(". Не удается загрузить страницу: " + url + " " + ip + ":" + port.ToString() + " " + uagent, Color.FromArgb(/* R */ 0x99, /* G*/ 0x33, /* B */ 0x33));
                Thread.Sleep(15000); 
            }
            if (WR != null)
            {                
                try
                {
                    StreamReader reader = new StreamReader(WR.GetResponseStream());
                    content = reader.ReadToEnd();
                }
                catch
                {
                    WriteLog(". Не удается получить содежимое: " + url + " " + ip + ":" + port.ToString() + " " + uagent, Color.FromArgb(/* R */ 0x99, /* G*/ 0x33, /* B */ 0x33));
                }
                if (content.Length < 0)
                {
                    goto label1;
                }
            }
            else
            {
                goto label1;
            }
            WriteLog(". Данные получены: " + url + " " + ip + ":" + port.ToString() + " " + uagent, Color.FromArgb(/* R */ 0x00, /* G*/ 0x66, /* B */ 0x00));
            return content;
        }
        public List<string> GetDnev(string content)
        {
            MatchCollection matchList = null;
            List<string> Users = new List<string>();
            String pattern = @"nowrap.*<a\shref='http:\/\/(.*?).livejournal.com\/profile'>";
            Regex exp = new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.IgnorePatternWhitespace);
            matchList = exp.Matches(content);

            if (matchList.Count > 0)
            {
                for (int i = 0; i < matchList.Count; i++)
                {
                    Match match = matchList[i];
                    if (match.Value.Length > 0)
                    {
                        string str = match.Value;
                        str = str.Remove(0, 24);
                        str = str.Remove(str.IndexOf(".livejournal.com/profile'>"));
                        Users.Add(str);
                    }
                }
            }
            return Users;
        }
    }
}
