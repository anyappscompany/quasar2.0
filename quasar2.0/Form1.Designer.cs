namespace quasar2._0
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.LogRichTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LimitNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SleepNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Resume = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.ThreadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.StartNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PreviewComment = new System.Windows.Forms.Button();
            this.PreviewWebBrowser = new System.Windows.Forms.WebBrowser();
            this.CommentList = new System.Windows.Forms.ListBox();
            this.CommentText = new System.Windows.Forms.TextBox();
            this.CommentRemove = new System.Windows.Forms.Button();
            this.CommentAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AccountsRemove = new System.Windows.Forms.Button();
            this.AccountsAdd = new System.Windows.Forms.Button();
            this.AccountsList = new System.Windows.Forms.ListBox();
            this.Accounts = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProxyList = new System.Windows.Forms.ListBox();
            this.ProxyRemove = new System.Windows.Forms.Button();
            this.ProxyAdd = new System.Windows.Forms.Button();
            this.Proxy = new System.Windows.Forms.TextBox();
            this.AccountsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ProxyToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.StartNumericUpDownToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ThreadNumericUpDownToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SleepNumericUpDownToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.LimitNumericUpDownToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LimitNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SleepNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThreadNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartNumericUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(999, 823);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(991, 797);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "http://www.livejournal.com/";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox5.Controls.Add(this.LogRichTextBox);
            this.groupBox5.Location = new System.Drawing.Point(3, 596);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(980, 193);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "log";
            // 
            // LogRichTextBox
            // 
            this.LogRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogRichTextBox.Location = new System.Drawing.Point(7, 19);
            this.LogRichTextBox.Name = "LogRichTextBox";
            this.LogRichTextBox.ReadOnly = true;
            this.LogRichTextBox.Size = new System.Drawing.Size(967, 168);
            this.LogRichTextBox.TabIndex = 5;
            this.LogRichTextBox.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox4.Controls.Add(this.LimitNumericUpDown);
            this.groupBox4.Controls.Add(this.SleepNumericUpDown);
            this.groupBox4.Controls.Add(this.Resume);
            this.groupBox4.Controls.Add(this.Pause);
            this.groupBox4.Controls.Add(this.Stop);
            this.groupBox4.Controls.Add(this.Start);
            this.groupBox4.Controls.Add(this.ThreadNumericUpDown);
            this.groupBox4.Controls.Add(this.StartNumericUpDown);
            this.groupBox4.Location = new System.Drawing.Point(3, 511);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(980, 79);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "sending";
            // 
            // LimitNumericUpDown
            // 
            this.LimitNumericUpDown.Location = new System.Drawing.Point(132, 19);
            this.LimitNumericUpDown.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.LimitNumericUpDown.Name = "LimitNumericUpDown";
            this.LimitNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.LimitNumericUpDown.TabIndex = 7;
            this.LimitNumericUpDownToolTip.SetToolTip(this.LimitNumericUpDown, "0 = до упора, больше = будет лимит");
            // 
            // SleepNumericUpDown
            // 
            this.SleepNumericUpDown.Enabled = false;
            this.SleepNumericUpDown.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SleepNumericUpDown.Location = new System.Drawing.Point(384, 19);
            this.SleepNumericUpDown.Maximum = new decimal(new int[] {
            600000,
            0,
            0,
            0});
            this.SleepNumericUpDown.Name = "SleepNumericUpDown";
            this.SleepNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.SleepNumericUpDown.TabIndex = 6;
            this.SleepNumericUpDownToolTip.SetToolTip(this.SleepNumericUpDown, "1000 = 1сек");
            this.SleepNumericUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // Resume
            // 
            this.Resume.Enabled = false;
            this.Resume.Location = new System.Drawing.Point(249, 45);
            this.Resume.Name = "Resume";
            this.Resume.Size = new System.Drawing.Size(75, 23);
            this.Resume.TabIndex = 0;
            this.Resume.Text = "resume";
            this.Resume.UseVisualStyleBackColor = true;
            this.Resume.Click += new System.EventHandler(this.Resume_Click);
            // 
            // Pause
            // 
            this.Pause.Enabled = false;
            this.Pause.Location = new System.Drawing.Point(168, 45);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(75, 23);
            this.Pause.TabIndex = 0;
            this.Pause.Text = "pause";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Stop
            // 
            this.Stop.Enabled = false;
            this.Stop.Location = new System.Drawing.Point(87, 45);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 23);
            this.Stop.TabIndex = 4;
            this.Stop.Text = "stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(6, 45);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 3;
            this.Start.Text = "start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // ThreadNumericUpDown
            // 
            this.ThreadNumericUpDown.Location = new System.Drawing.Point(258, 19);
            this.ThreadNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ThreadNumericUpDown.Name = "ThreadNumericUpDown";
            this.ThreadNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.ThreadNumericUpDown.TabIndex = 2;
            this.ThreadNumericUpDownToolTip.SetToolTip(this.ThreadNumericUpDown, "-");
            this.ThreadNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // StartNumericUpDown
            // 
            this.StartNumericUpDown.Location = new System.Drawing.Point(6, 19);
            this.StartNumericUpDown.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.StartNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartNumericUpDown.Name = "StartNumericUpDown";
            this.StartNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.StartNumericUpDown.TabIndex = 1;
            this.StartNumericUpDownToolTip.SetToolTip(this.StartNumericUpDown, "http://www.livejournal.com/ratings/users/?page=1");
            this.StartNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.PreviewComment);
            this.groupBox3.Controls.Add(this.PreviewWebBrowser);
            this.groupBox3.Controls.Add(this.CommentList);
            this.groupBox3.Controls.Add(this.CommentText);
            this.groupBox3.Controls.Add(this.CommentRemove);
            this.groupBox3.Controls.Add(this.CommentAdd);
            this.groupBox3.Location = new System.Drawing.Point(229, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(754, 502);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "posting settings";
            // 
            // PreviewComment
            // 
            this.PreviewComment.Location = new System.Drawing.Point(166, 465);
            this.PreviewComment.Name = "PreviewComment";
            this.PreviewComment.Size = new System.Drawing.Size(75, 23);
            this.PreviewComment.TabIndex = 5;
            this.PreviewComment.Text = "preview";
            this.PreviewComment.UseVisualStyleBackColor = true;
            this.PreviewComment.Click += new System.EventHandler(this.PreviewComment_Click);
            // 
            // PreviewWebBrowser
            // 
            this.PreviewWebBrowser.Location = new System.Drawing.Point(7, 212);
            this.PreviewWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.PreviewWebBrowser.Name = "PreviewWebBrowser";
            this.PreviewWebBrowser.Size = new System.Drawing.Size(741, 247);
            this.PreviewWebBrowser.TabIndex = 6;
            // 
            // CommentList
            // 
            this.CommentList.FormattingEnabled = true;
            this.CommentList.HorizontalScrollbar = true;
            this.CommentList.Items.AddRange(new object[] {
            "Очень понравился пост, респект автору! И я вот <a href=\"http://sigil39.blogspot.c" +
                "om/2010/12/blog-post_6130.html\">тут</a> пишу всякие интересные посты.",
            "Очень понравился <a href=\"http://sigil39.blogspot.com/2010/12/blog-post_6130.html" +
                "\">пост</a>, респект автору!",
            "Замечательный дневник, пишите <a href=\"http://sigil39.blogspot.com/2010/12/blog-p" +
                "ost_6130.html\">еще</a>, читаю всегда.",
            "Привет! Круто пишите, мне очень понравилось, пишите еще. Я вот <a href=\"http://si" +
                "gil39.blogspot.com/2010/12/blog-post_6130.html\">тут</a> тоже много чего интересн" +
                "ого написал.",
            "Очень понравился пост, респект автору! И я вот <a href=\"http://sigil39.blogspot.c" +
                "om\">тут</a> пишу всякие интересные посты.",
            "Очень понравился <a href=\"http://sigil39.blogspot.com\">пост</a>, респект автору!",
            "Замечательный дневник, пишите <a href=\"http://sigil39.blogspot.com\">еще</a>, чита" +
                "ю всегда.",
            "Привет! Круто пишите, мне очень понравилось, пишите еще. Я вот <a href=\"http://si" +
                "gil39.blogspot.com\">тут</a> тоже много чего интересного написал."});
            this.CommentList.Location = new System.Drawing.Point(7, 19);
            this.CommentList.Name = "CommentList";
            this.CommentList.Size = new System.Drawing.Size(741, 82);
            this.CommentList.TabIndex = 5;
            this.CommentList.SelectedIndexChanged += new System.EventHandler(this.PostList_SelectedIndexChanged);
            // 
            // CommentText
            // 
            this.CommentText.Location = new System.Drawing.Point(7, 109);
            this.CommentText.Multiline = true;
            this.CommentText.Name = "CommentText";
            this.CommentText.Size = new System.Drawing.Size(741, 97);
            this.CommentText.TabIndex = 1;
            // 
            // CommentRemove
            // 
            this.CommentRemove.Location = new System.Drawing.Point(86, 465);
            this.CommentRemove.Name = "CommentRemove";
            this.CommentRemove.Size = new System.Drawing.Size(75, 23);
            this.CommentRemove.TabIndex = 3;
            this.CommentRemove.Text = "remove";
            this.CommentRemove.UseVisualStyleBackColor = true;
            this.CommentRemove.Click += new System.EventHandler(this.PostRemove_Click);
            // 
            // CommentAdd
            // 
            this.CommentAdd.Location = new System.Drawing.Point(5, 465);
            this.CommentAdd.Name = "CommentAdd";
            this.CommentAdd.Size = new System.Drawing.Size(75, 23);
            this.CommentAdd.TabIndex = 2;
            this.CommentAdd.Text = "add";
            this.CommentAdd.UseVisualStyleBackColor = true;
            this.CommentAdd.Click += new System.EventHandler(this.PostAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.AccountsRemove);
            this.groupBox2.Controls.Add(this.AccountsAdd);
            this.groupBox2.Controls.Add(this.AccountsList);
            this.groupBox2.Controls.Add(this.Accounts);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 248);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "accounts";
            // 
            // AccountsRemove
            // 
            this.AccountsRemove.Location = new System.Drawing.Point(87, 45);
            this.AccountsRemove.Name = "AccountsRemove";
            this.AccountsRemove.Size = new System.Drawing.Size(75, 23);
            this.AccountsRemove.TabIndex = 4;
            this.AccountsRemove.Text = "remove";
            this.AccountsRemove.UseVisualStyleBackColor = true;
            this.AccountsRemove.Click += new System.EventHandler(this.AccountsRemove_Click);
            // 
            // AccountsAdd
            // 
            this.AccountsAdd.Location = new System.Drawing.Point(6, 45);
            this.AccountsAdd.Name = "AccountsAdd";
            this.AccountsAdd.Size = new System.Drawing.Size(75, 23);
            this.AccountsAdd.TabIndex = 3;
            this.AccountsAdd.Text = "add";
            this.AccountsAdd.UseVisualStyleBackColor = true;
            this.AccountsAdd.Click += new System.EventHandler(this.AccountsAdd_Click);
            // 
            // AccountsList
            // 
            this.AccountsList.FormattingEnabled = true;
            this.AccountsList.Items.AddRange(new object[] {
            "sigil39:ljhjhjhg888hjhj",
            "iiwanttorock:dfvsdf55gg"});
            this.AccountsList.Location = new System.Drawing.Point(6, 74);
            this.AccountsList.Name = "AccountsList";
            this.AccountsList.Size = new System.Drawing.Size(206, 160);
            this.AccountsList.TabIndex = 2;
            this.AccountsList.SelectedIndexChanged += new System.EventHandler(this.AccountsList_SelectedIndexChanged);
            // 
            // Accounts
            // 
            this.Accounts.Location = new System.Drawing.Point(6, 19);
            this.Accounts.Name = "Accounts";
            this.Accounts.Size = new System.Drawing.Size(206, 20);
            this.Accounts.TabIndex = 0;
            this.AccountsToolTip.SetToolTip(this.Accounts, "login:password");
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.ProxyList);
            this.groupBox1.Controls.Add(this.ProxyRemove);
            this.groupBox1.Controls.Add(this.ProxyAdd);
            this.groupBox1.Controls.Add(this.Proxy);
            this.groupBox1.Location = new System.Drawing.Point(3, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "proxy";
            // 
            // ProxyList
            // 
            this.ProxyList.FormattingEnabled = true;
            this.ProxyList.Items.AddRange(new object[] {
            "109.87.125.55:8080",
            "70.38.48.244:3128",
            "113.53.244.67:8080"});
            this.ProxyList.Location = new System.Drawing.Point(5, 74);
            this.ProxyList.Name = "ProxyList";
            this.ProxyList.Size = new System.Drawing.Size(207, 160);
            this.ProxyList.TabIndex = 5;
            this.ProxyList.SelectedIndexChanged += new System.EventHandler(this.ProxyList_SelectedIndexChanged);
            // 
            // ProxyRemove
            // 
            this.ProxyRemove.Location = new System.Drawing.Point(87, 45);
            this.ProxyRemove.Name = "ProxyRemove";
            this.ProxyRemove.Size = new System.Drawing.Size(75, 23);
            this.ProxyRemove.TabIndex = 4;
            this.ProxyRemove.Text = "remove";
            this.ProxyRemove.UseVisualStyleBackColor = true;
            this.ProxyRemove.Click += new System.EventHandler(this.ProxyRemove_Click);
            // 
            // ProxyAdd
            // 
            this.ProxyAdd.Location = new System.Drawing.Point(6, 45);
            this.ProxyAdd.Name = "ProxyAdd";
            this.ProxyAdd.Size = new System.Drawing.Size(75, 23);
            this.ProxyAdd.TabIndex = 3;
            this.ProxyAdd.Text = "add";
            this.ProxyAdd.UseVisualStyleBackColor = true;
            this.ProxyAdd.Click += new System.EventHandler(this.ProxyAdd_Click);
            // 
            // Proxy
            // 
            this.Proxy.Location = new System.Drawing.Point(6, 19);
            this.Proxy.Name = "Proxy";
            this.Proxy.Size = new System.Drawing.Size(206, 20);
            this.Proxy.TabIndex = 0;
            this.ProxyToolTip.SetToolTip(this.Proxy, "ip:port, тут есть HTTP прокси http://xseo.in/freeproxy, проверка тут http://spys." +
                    "ru/proxy/");
            // 
            // AccountsToolTip
            // 
            this.AccountsToolTip.AutoPopDelay = 5000;
            this.AccountsToolTip.InitialDelay = 100;
            this.AccountsToolTip.ReshowDelay = 100;
            this.AccountsToolTip.Tag = "";
            this.AccountsToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.AccountsToolTip.ToolTipTitle = "Формат ввода:";
            // 
            // ProxyToolTip
            // 
            this.ProxyToolTip.AutoPopDelay = 5000;
            this.ProxyToolTip.InitialDelay = 100;
            this.ProxyToolTip.ReshowDelay = 100;
            this.ProxyToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ProxyToolTip.ToolTipTitle = "Формат ввода:";
            // 
            // StartNumericUpDownToolTip
            // 
            this.StartNumericUpDownToolTip.AutoPopDelay = 5000;
            this.StartNumericUpDownToolTip.InitialDelay = 100;
            this.StartNumericUpDownToolTip.ReshowDelay = 100;
            this.StartNumericUpDownToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.StartNumericUpDownToolTip.ToolTipTitle = "С этой страницы начнется комментирование:";
            // 
            // ThreadNumericUpDownToolTip
            // 
            this.ThreadNumericUpDownToolTip.AutoPopDelay = 5000;
            this.ThreadNumericUpDownToolTip.InitialDelay = 100;
            this.ThreadNumericUpDownToolTip.ReshowDelay = 100;
            this.ThreadNumericUpDownToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ThreadNumericUpDownToolTip.ToolTipTitle = "Количество потоков:";
            // 
            // SleepNumericUpDownToolTip
            // 
            this.SleepNumericUpDownToolTip.AutoPopDelay = 5000;
            this.SleepNumericUpDownToolTip.InitialDelay = 100;
            this.SleepNumericUpDownToolTip.ReshowDelay = 100;
            this.SleepNumericUpDownToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.SleepNumericUpDownToolTip.ToolTipTitle = "Задержка:";
            // 
            // LimitNumericUpDownToolTip
            // 
            this.LimitNumericUpDownToolTip.AutoPopDelay = 5000;
            this.LimitNumericUpDownToolTip.InitialDelay = 100;
            this.LimitNumericUpDownToolTip.ReshowDelay = 100;
            this.LimitNumericUpDownToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.LimitNumericUpDownToolTip.ToolTipTitle = "Лимит:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 823);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "quasar2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LimitNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SleepNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThreadNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartNumericUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AccountsRemove;
        private System.Windows.Forms.Button AccountsAdd;
        private System.Windows.Forms.ListBox AccountsList;
        private System.Windows.Forms.TextBox Accounts;
        private System.Windows.Forms.ListBox ProxyList;
        private System.Windows.Forms.Button ProxyRemove;
        private System.Windows.Forms.Button ProxyAdd;
        private System.Windows.Forms.TextBox Proxy;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button CommentRemove;
        private System.Windows.Forms.Button CommentAdd;
        private System.Windows.Forms.TextBox CommentText;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown ThreadNumericUpDown;
        private System.Windows.Forms.NumericUpDown StartNumericUpDown;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Resume;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.ListBox CommentList;
        private System.Windows.Forms.RichTextBox LogRichTextBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ToolTip AccountsToolTip;
        private System.Windows.Forms.ToolTip ProxyToolTip;
        private System.Windows.Forms.ToolTip StartNumericUpDownToolTip;
        private System.Windows.Forms.ToolTip ThreadNumericUpDownToolTip;
        private System.Windows.Forms.Button PreviewComment;
        private System.Windows.Forms.WebBrowser PreviewWebBrowser;
        private System.Windows.Forms.NumericUpDown SleepNumericUpDown;
        private System.Windows.Forms.ToolTip SleepNumericUpDownToolTip;
        private System.Windows.Forms.NumericUpDown LimitNumericUpDown;
        private System.Windows.Forms.ToolTip LimitNumericUpDownToolTip;
    }
}

