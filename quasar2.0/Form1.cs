using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;

namespace quasar2._0
{    
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();            
        }
        private bool isLimit;
        private int Limit;
        private int NumThread;        
        private int TSleep;
        private static int StartPage;
        private static int Count;
        private bool flag;
        private int endt = 0;
        Object locker = new Object();
        Object locker1 = new Object();
        delegate void AddText(string text, Color color);
        void WriteLog(string text, Color color)
        {

            if (LogRichTextBox.InvokeRequired)
            {
                this.BeginInvoke(new AddText(WriteLog), new object[] { text, color });
            }
            else
            {
                if ((LogRichTextBox.Lines.Length) > 100)
                {
                    LogRichTextBox.Text = string.Empty;
                }
                LogRichTextBox.Select(0, 0);
                Font font = new Font("Tahoma", 8, FontStyle.Regular);
                LogRichTextBox.SelectionFont = font;
                LogRichTextBox.SelectionColor = color;
                LogRichTextBox.SelectedText = text + Environment.NewLine;
            }
        }
        delegate void EndPocessEventHandler();
        private void Form1_onEndProcess()
        {
            //Start.Enabled = true;
            //Stop.Enabled = false;
            //Pause.Enabled = false;
            //Resume.Enabled = false;

            if (Start.InvokeRequired && Stop.InvokeRequired && Pause.InvokeRequired && Resume.InvokeRequired && groupBox1.InvokeRequired && groupBox2.InvokeRequired && groupBox3.InvokeRequired && StartNumericUpDown.InvokeRequired && ThreadNumericUpDown.InvokeRequired && SleepNumericUpDown.InvokeRequired && LimitNumericUpDown.InvokeRequired)
            {
                this.BeginInvoke(
                    new EndPocessEventHandler(Form1_onEndProcess));
            }
            else
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
                Start.Enabled = true;
                Stop.Enabled = false;
                Pause.Enabled = false;
                Resume.Enabled = false;
                StartNumericUpDown.Enabled = true;
                ThreadNumericUpDown.Enabled = true;
                //SleepNumericUpDown.Enabled = true;
                LimitNumericUpDown.Enabled = true;
            }
        }

        private Thread[] ThreadCommentation;

        private void Commentation()
        {
            try
            {
                while (flag) // или страница больше максимальной
                {
                    string RatingContent;
                    RndAccounts Account = new RndAccounts(AccountsList);
                    AccountsData AcData = new AccountsData();
                    RndProxy ProxyR = new RndProxy(ProxyList);
                    RndUAgent AgentR = new RndUAgent();

                    string ip = ProxyR.GetProxy().IP;
                    int port = ProxyR.GetProxy().Port;
                    string uag = AgentR.GetUA();

                    List<string> Usrs = new List<string>();
                    //lock (locker)
                    //{
                    //WriteLog(StartPage.ToString(), Color.FromArgb(/* R */ 0x00, /* G*/ 0x66, /* B */ 0x00));
                    Thread.Sleep(500);
                    //StartPage++;
                    AcData.Login = Account.GetAccounts().Login;
                    AcData.Password = Account.GetAccounts().Password;
                    //}
                    LJServer server = new LJServer(ip, port, uag, ProxyList);
                    CookieCollection cookies;
                    try
                    {
                        cookies = server.GetBaseCookie(AcData.Login, AcData.Password);
                    }
                    catch
                    {
                        //
                        continue;
                    }

                    //PreviewWebBrowser.DocumentText = server.GetPage("http://www.livejournal.com", server.GetBaseCookie("sshreder", "jhsdfs45cxb"));
                    // Вход
                    //LJServer server = new LJServer();
                    //server.GetBaseCookie(AcData.Login, AcData.Password);

                    LJRatings lr = new LJRatings(ProxyList, LogRichTextBox);
                    lock (locker)
                    {
                        StartPage++;
                    }
                    //WriteLog("~ " + StartPage.ToString(), Color.FromArgb(/* R */ 0x00, /* G*/ 0x00, /* B */ 0x00));
                    RatingContent = lr.GetContent("http://www.livejournal.com/ratings/users/?page=" + StartPage);

                    Usrs = lr.GetDnev(RatingContent);
                    for (int i = 0; i < Usrs.Count; i++)
                    {
                        if (isLimit)
                        {
                            if (Limit == Count)
                            {
                                flag = false;
                                break;
                            }
                        }
                        if (!flag) break;
                        string str;
                        string posta;
                        str = server.GetPage("http://" + Usrs[i] + ".livejournal.com", cookies);

                        if ((posta = server.GetRndPost(str, Usrs[i])) != null)
                        {
                            WriteLog(posta, Color.FromArgb(/* R */ 0x00, /* G*/ 0x00, /* B */ 0x99));
                            /*можно комментировать?*/
                            if (server.Valid(server.GetPage("http://" + posta + "?mode=reply", cookies)))
                            {
                                WriteLog(posta + " -Комментарий разрешен", Color.FromArgb(/* R */ 0x33, /* G*/ 0xCC, /* B */ 0xFF));
                                RndComment rndcom = new RndComment(CommentList);
                                string comment = rndcom.GetComment();
                                server.PostComment(AcData.Login, AcData.Password, "http://" + posta, comment, "", 0, cookies);
                                Count++;
                                WriteLog("~ " + StartPage + " [" + Count.ToString() + "]" + posta + " -Отправлен", Color.FromArgb(/* R */ 0xFF, /* G*/ 0x00, /* B */ 0xFF));                                
                            }
                            else
                            {
                                WriteLog(posta + " -Есть capcha или отключены комментарии или только друзья или нет формы или еще какая хрень", Color.FromArgb(/* R */ 0xFF, /* G*/ 0x99, /* B */ 0x66));
                            }
                        }
                        else
                        {
                            WriteLog("В дневнике " + Usrs[i] + " не найдены посты или не удалось определить", Color.FromArgb(/* R */ 0x99, /* G*/ 0x33, /* B */ 0x33));
                        }
                        //PreviewWebBrowser.DocumentText = str;
                        // Проверить возможность оставить комментарий
                    }
                }
            }
            catch { }            
            WriteLog("Поток завершен", Color.FromArgb(/* R */ 0x99, /* G*/ 0x00, /* B */ 0x66));
            endt++;
            if (endt == NumThread)
            {
                Form1_onEndProcess();
                //Start.Enabled = true;
                //Stop.Enabled = false;
                //Pause.Enabled = false;
                //Resume.Enabled = false;
            }
        }

        private void PostAdd_Click(object sender, EventArgs e)
        {            
            if (CommentText.TextLength > 0)
            {
                /*Добавление нового комментария*/
                CommentList.Items.Add(CommentText.Text);
                /*Запись сообщения в log*/
                if ((LogRichTextBox.Lines.Length) > 100)
                {
                    LogRichTextBox.Text = string.Empty;
                }
                LogRichTextBox.Select(0, 0);
                Font font = new Font("Tahoma", 8, FontStyle.Regular);
                LogRichTextBox.SelectionFont = font;
                LogRichTextBox.SelectionColor = Color.FromArgb(/* R */ 0x00, /* G*/ 0x66, /* B */ 0x00);            
                LogRichTextBox.SelectedText = ". Добавлен новый комментарий: " + CommentText.Text + Environment.NewLine;
            }                     
        }

        private void PostRemove_Click(object sender, EventArgs e)
        {
            while (CommentList.SelectedItems.Count > 0)
            {
                string RemCom;
                RemCom = CommentList.SelectedItems[0].ToString();
                /*Удаление комментария*/
                if (CommentList.SelectedIndex == -1)
                {
                    /*Запись сообщения в log*/
                    if ((LogRichTextBox.Lines.Length) > 100)
                    {
                        LogRichTextBox.Text = string.Empty;
                    }
                    LogRichTextBox.Select(0, 0);
                    Font font = new Font("Tahoma", 8, FontStyle.Regular);
                    LogRichTextBox.SelectionFont = font;
                    LogRichTextBox.SelectionColor = Color.FromArgb(/* R */ 0x99, /* G*/ 0x33, /* B */ 0x33); ;

                    LogRichTextBox.SelectedText = ". Не выбран элемент для удаления" + Environment.NewLine;
                }
                else
                {
                    CommentList.Items.RemoveAt(CommentList.SelectedIndex);
                    /*Запись сообщения в log*/
                    if ((LogRichTextBox.Lines.Length) > 15)
                    {
                        LogRichTextBox.Text = string.Empty;
                    }
                    LogRichTextBox.Select(0, 0);
                    Font font = new Font("Tahoma", 8, FontStyle.Regular);
                    LogRichTextBox.SelectionFont = font;
                    LogRichTextBox.SelectionColor = Color.FromArgb(/* R */ 0xFF, /* G*/ 0xCC, /* B */ 0x00);

                    LogRichTextBox.SelectedText = ". Удален комеентарий: " + RemCom + Environment.NewLine;
                }                
            }
        }

        private void PostList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CommentList.SelectedIndex == -1)
                {
                    //
                }
                else
                {
                    string RemCom;
                    RemCom = CommentList.SelectedItems[0].ToString();
                    CommentText.Text = RemCom;
                }
        }

        private void ProxyAdd_Click(object sender, EventArgs e)
        {            
            if (Proxy.TextLength > 0)
            {
                /*Добавление нового комментария*/
                ProxyList.Items.Add(Proxy.Text);               
                /*Запись сообщения в log*/
                if ((LogRichTextBox.Lines.Length) > 100)
                {
                    LogRichTextBox.Text = string.Empty;
                }
                LogRichTextBox.Select(0, 0);
                Font font = new Font("Tahoma", 8, FontStyle.Regular);
                LogRichTextBox.SelectionFont = font;
                LogRichTextBox.SelectionColor = Color.FromArgb(/* R */ 0x00, /* G*/ 0x66, /* B */ 0x00);
                LogRichTextBox.SelectedText = ". Добавлен новый proxy: " + Proxy.Text + Environment.NewLine;
            }
        }

        private void ProxyRemove_Click(object sender, EventArgs e)
        {            
            while (ProxyList.SelectedItems.Count > 0)
            {
                string RemProxy;
                RemProxy = ProxyList.SelectedItems[0].ToString();
                /*Удаление комментария*/
                if (ProxyList.SelectedIndex == -1)
                {
                    /*Запись сообщения в log*/
                    if ((LogRichTextBox.Lines.Length) > 100)
                    {
                        LogRichTextBox.Text = string.Empty;
                    }
                    LogRichTextBox.Select(0, 0);
                    Font font = new Font("Tahoma", 8, FontStyle.Regular);
                    LogRichTextBox.SelectionFont = font;
                    LogRichTextBox.SelectionColor = Color.FromArgb(/* R */ 0x99, /* G*/ 0x33, /* B */ 0x33); ;

                    LogRichTextBox.SelectedText = ". Не выбран элемент для удаления" + Environment.NewLine;
                }
                else
                {
                    ProxyList.Items.RemoveAt(ProxyList.SelectedIndex);
                    /*Запись сообщения в log*/
                    if ((LogRichTextBox.Lines.Length) > 15)
                    {
                        LogRichTextBox.Text = string.Empty;
                    }
                    LogRichTextBox.Select(0, 0);
                    Font font = new Font("Tahoma", 8, FontStyle.Regular);
                    LogRichTextBox.SelectionFont = font;
                    LogRichTextBox.SelectionColor = Color.FromArgb(/* R */ 0xFF, /* G*/ 0xCC, /* B */ 0x00);

                    LogRichTextBox.SelectedText = ". Удален proxy: " + RemProxy + Environment.NewLine;
                }
            }
        }

        private void ProxyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProxyList.SelectedIndex == -1)
            {
                //
            }
            else
            {
                string RemProxy;
                RemProxy = ProxyList.SelectedItems[0].ToString();
                Proxy.Text = RemProxy;
            }
        }

        private void AccountsAdd_Click(object sender, EventArgs e)
        {
            if (Accounts.TextLength > 0)
            {
                /*Добавление нового комментария*/
                AccountsList.Items.Add(Accounts.Text);
                /*Запись сообщения в log*/
                if ((LogRichTextBox.Lines.Length) > 100)
                {
                    LogRichTextBox.Text = string.Empty;
                }
                LogRichTextBox.Select(0, 0);
                Font font = new Font("Tahoma", 8, FontStyle.Regular);
                LogRichTextBox.SelectionFont = font;
                LogRichTextBox.SelectionColor = Color.FromArgb(/* R */ 0x00, /* G*/ 0x66, /* B */ 0x00);
                LogRichTextBox.SelectedText = ". Добавлен новый аккаунт: " + Accounts.Text + Environment.NewLine;
            }
        }

        private void AccountsRemove_Click(object sender, EventArgs e)
        {
            while (AccountsList.SelectedItems.Count > 0)
            {
                string RemAccounts;
                RemAccounts = AccountsList.SelectedItems[0].ToString();
                /*Удаление комментария*/
                if (AccountsList.SelectedIndex == -1)
                {
                    /*Запись сообщения в log*/
                    if ((LogRichTextBox.Lines.Length) > 100)
                    {
                        LogRichTextBox.Text = string.Empty;
                    }
                    LogRichTextBox.Select(0, 0);
                    Font font = new Font("Tahoma", 8, FontStyle.Regular);
                    LogRichTextBox.SelectionFont = font;
                    LogRichTextBox.SelectionColor = Color.FromArgb(/* R */ 0x99, /* G*/ 0x33, /* B */ 0x33);

                    LogRichTextBox.SelectedText = ". Не выбран элемент для удаления" + Environment.NewLine;
                }
                else
                {
                    AccountsList.Items.RemoveAt(AccountsList.SelectedIndex);
                    /*Запись сообщения в log*/
                    if ((LogRichTextBox.Lines.Length) > 100)
                    {
                        LogRichTextBox.Text = string.Empty;
                    }
                    LogRichTextBox.Select(0, 0);
                    Font font = new Font("Tahoma", 8, FontStyle.Regular);
                    LogRichTextBox.SelectionFont = font;
                    LogRichTextBox.SelectionColor = Color.FromArgb(/* R */ 0xFF, /* G*/ 0xCC, /* B */ 0x00);

                    LogRichTextBox.SelectedText = ". Удален аккаунт: " + RemAccounts + Environment.NewLine;
                }
            }
        }

        private void AccountsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AccountsList.SelectedIndex == -1)
            {
                //
            }
            else
            {
                string RemAccounts;
                RemAccounts = AccountsList.SelectedItems[0].ToString();
                Accounts.Text = RemAccounts; 
            }
        }

        private void PreviewComment_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string Comment="";
            if (CommentText.Text.Length > 0)
            {
                Comment = CommentText.Text;
                sb.Append("<html><body>");
                sb.Append(Comment);
                sb.Append("</body></html>");
                PreviewWebBrowser.DocumentText = sb.ToString();
            }            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
                        
        }

        private void Start_Click(object sender, EventArgs e)
        {
            endt = 0;
            Limit = Convert.ToInt32(LimitNumericUpDown.Value);
            isLimit = false;
            if (Limit < 1)
            {
                isLimit = false;
            }
            else
            {
                isLimit = true;
            }
            NumThread = Convert.ToInt32(ThreadNumericUpDown.Value);
            TSleep = Convert.ToInt32(SleepNumericUpDown.Value);
            StartPage = Convert.ToInt32(StartNumericUpDown.Value) - 1;
            Count = 0;
            ThreadCommentation = new Thread[NumThread];
            flag = true;
            for (int i = 0; i < NumThread; i++)
            {

                ThreadCommentation[i] = new Thread(new ThreadStart(Commentation));
                ThreadCommentation[i].Start();
            }
            Start.Enabled = false;
            Resume.Enabled = false;
            Stop.Enabled = true;
            Pause.Enabled = true;
            StartNumericUpDown.Enabled = false;
            ThreadNumericUpDown.Enabled = false;
            //SleepNumericUpDown.Enabled = false;
            LimitNumericUpDown.Enabled = false;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < NumThread; i++)
            {
                ThreadCommentation[i].Suspend();
            }
            Pause.Enabled = false;
            Start.Enabled = false;
            Stop.Enabled = false;
            Resume.Enabled = true;
        }

        private void Resume_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < NumThread; i++)
            {
                ThreadCommentation[i].Resume();
            }
            Resume.Enabled = false;
            Start.Enabled = false;
            Stop.Enabled = true;
            Pause.Enabled = true;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            flag = false;
            Stop.Enabled = false;
            Start.Enabled = false;
            Pause.Enabled = false;
            Resume.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string curID = "FB278BFACEB3337FBFF";
            //string curID = "FB278BF61E91C44FBFF";Петрова ID
            HardwareID HI = new HardwareID();
            if(curID!=HI.getUniqueID("C"))
            {
                MessageBox.Show("Bad Hardware Id");
                Application.Exit();
            }
        }        
    }
}
