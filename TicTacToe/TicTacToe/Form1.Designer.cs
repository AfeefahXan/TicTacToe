namespace FTTTV1_Testpage_3
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.trackBarProgress = new System.Windows.Forms.TrackBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.btnstop = new System.Windows.Forms.Button();
            this.btnpause = new System.Windows.Forms.Button();
            this.btnfullscreen = new System.Windows.Forms.Button();
            this.btnplay = new System.Windows.Forms.Button();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblroundo = new System.Windows.Forms.Label();
            this.lblroundx = new System.Windows.Forms.Label();
            this.lblround = new System.Windows.Forms.Label();
            this.txtDraw = new System.Windows.Forms.TextBox();
            this.txtOscore = new System.Windows.Forms.TextBox();
            this.txtXscore = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lbldraw = new System.Windows.Forms.Label();
            this.lblplayero = new System.Windows.Forms.Label();
            this.lblplayerx = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsend = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnnewround = new System.Windows.Forms.Button();
            this.btnC3 = new System.Windows.Forms.Button();
            this.btnC2 = new System.Windows.Forms.Button();
            this.btnC1 = new System.Windows.Forms.Button();
            this.btnB3 = new System.Windows.Forms.Button();
            this.btnB2 = new System.Windows.Forms.Button();
            this.btnB1 = new System.Windows.Forms.Button();
            this.btnA3 = new System.Windows.Forms.Button();
            this.btnA2 = new System.Windows.Forms.Button();
            this.btnA1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.menuStrip3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 10;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.trackBarProgress);
            this.tabPage4.Controls.Add(this.progressBar1);
            this.tabPage4.Controls.Add(this.pictureBox1);
            this.tabPage4.Controls.Add(this.trackBarVolume);
            this.tabPage4.Controls.Add(this.btnstop);
            this.tabPage4.Controls.Add(this.btnpause);
            this.tabPage4.Controls.Add(this.btnfullscreen);
            this.tabPage4.Controls.Add(this.btnplay);
            this.tabPage4.Controls.Add(this.menuStrip3);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(762, 542);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Video";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // trackBarProgress
            // 
            this.trackBarProgress.Location = new System.Drawing.Point(20, 431);
            this.trackBarProgress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBarProgress.Maximum = 142;
            this.trackBarProgress.Name = "trackBarProgress";
            this.trackBarProgress.Size = new System.Drawing.Size(560, 69);
            this.trackBarProgress.TabIndex = 16;
            this.trackBarProgress.Scroll += new System.EventHandler(this.trackBarProgress_Scroll);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(20, 386);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar1.Maximum = 142;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(560, 35);
            this.progressBar1.TabIndex = 15;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(20, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(560, 335);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Location = new System.Drawing.Point(662, 240);
            this.trackBarVolume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBarVolume.Maximum = 1000;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarVolume.Size = new System.Drawing.Size(69, 208);
            this.trackBarVolume.TabIndex = 13;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            // 
            // btnstop
            // 
            this.btnstop.Location = new System.Drawing.Point(616, 195);
            this.btnstop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(112, 35);
            this.btnstop.TabIndex = 12;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // btnpause
            // 
            this.btnpause.Location = new System.Drawing.Point(616, 151);
            this.btnpause.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnpause.Name = "btnpause";
            this.btnpause.Size = new System.Drawing.Size(112, 35);
            this.btnpause.TabIndex = 11;
            this.btnpause.Text = "Pause";
            this.btnpause.UseVisualStyleBackColor = true;
            this.btnpause.Click += new System.EventHandler(this.btnpause_Click);
            // 
            // btnfullscreen
            // 
            this.btnfullscreen.Location = new System.Drawing.Point(616, 91);
            this.btnfullscreen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnfullscreen.Name = "btnfullscreen";
            this.btnfullscreen.Size = new System.Drawing.Size(112, 35);
            this.btnfullscreen.TabIndex = 10;
            this.btnfullscreen.Text = "Fullscreen";
            this.btnfullscreen.UseVisualStyleBackColor = true;
            this.btnfullscreen.Click += new System.EventHandler(this.btnfullscreen_Click);
            // 
            // btnplay
            // 
            this.btnplay.Location = new System.Drawing.Point(616, 48);
            this.btnplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(112, 35);
            this.btnplay.TabIndex = 9;
            this.btnplay.Text = "Play";
            this.btnplay.UseVisualStyleBackColor = true;
            this.btnplay.Click += new System.EventHandler(this.btnplay_Click);
            // 
            // menuStrip3
            // 
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem8});
            this.menuStrip3.Location = new System.Drawing.Point(3, 3);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(756, 33);
            this.menuStrip3.TabIndex = 3;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripMenuItem7});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(50, 29);
            this.toolStripMenuItem2.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(140, 30);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(140, 30);
            this.toolStripMenuItem7.Text = "Exit";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem9});
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(61, 29);
            this.toolStripMenuItem8.Text = "Help";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(146, 30);
            this.toolStripMenuItem9.Text = "About";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.webBrowser1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(762, 542);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Web";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(30, 31);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(756, 536);
            this.webBrowser1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.lblroundo);
            this.tabPage2.Controls.Add(this.lblroundx);
            this.tabPage2.Controls.Add(this.lblround);
            this.tabPage2.Controls.Add(this.txtDraw);
            this.tabPage2.Controls.Add(this.txtOscore);
            this.tabPage2.Controls.Add(this.txtXscore);
            this.tabPage2.Controls.Add(this.txtemail);
            this.tabPage2.Controls.Add(this.lbldraw);
            this.tabPage2.Controls.Add(this.lblplayero);
            this.tabPage2.Controls.Add(this.lblplayerx);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnsend);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btnnewround);
            this.tabPage2.Controls.Add(this.btnC3);
            this.tabPage2.Controls.Add(this.btnC2);
            this.tabPage2.Controls.Add(this.btnC1);
            this.tabPage2.Controls.Add(this.btnB3);
            this.tabPage2.Controls.Add(this.btnB2);
            this.tabPage2.Controls.Add(this.btnB1);
            this.tabPage2.Controls.Add(this.btnA3);
            this.tabPage2.Controls.Add(this.btnA2);
            this.tabPage2.Controls.Add(this.btnA1);
            this.tabPage2.Controls.Add(this.menuStrip1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(762, 542);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Game";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Name Type:";
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(609, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 30);
            this.button2.TabIndex = 46;
            this.button2.Text = "Select";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.selectbtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(435, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 28);
            this.comboBox1.TabIndex = 45;
            // 
            // lblroundo
            // 
            this.lblroundo.AutoSize = true;
            this.lblroundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblroundo.Location = new System.Drawing.Point(627, 280);
            this.lblroundo.Name = "lblroundo";
            this.lblroundo.Size = new System.Drawing.Size(62, 55);
            this.lblroundo.TabIndex = 44;
            this.lblroundo.Text = "O";
            // 
            // lblroundx
            // 
            this.lblroundx.AutoSize = true;
            this.lblroundx.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblroundx.Location = new System.Drawing.Point(627, 225);
            this.lblroundx.Name = "lblroundx";
            this.lblroundx.Size = new System.Drawing.Size(57, 55);
            this.lblroundx.TabIndex = 43;
            this.lblroundx.Text = "X";
            // 
            // lblround
            // 
            this.lblround.AutoSize = true;
            this.lblround.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblround.Location = new System.Drawing.Point(603, 186);
            this.lblround.Name = "lblround";
            this.lblround.Size = new System.Drawing.Size(113, 32);
            this.lblround.TabIndex = 42;
            this.lblround.Text = "Round:";
            // 
            // txtDraw
            // 
            this.txtDraw.Location = new System.Drawing.Point(508, 303);
            this.txtDraw.Name = "txtDraw";
            this.txtDraw.ReadOnly = true;
            this.txtDraw.Size = new System.Drawing.Size(37, 26);
            this.txtDraw.TabIndex = 41;
            // 
            // txtOscore
            // 
            this.txtOscore.Location = new System.Drawing.Point(508, 269);
            this.txtOscore.Name = "txtOscore";
            this.txtOscore.ReadOnly = true;
            this.txtOscore.Size = new System.Drawing.Size(37, 26);
            this.txtOscore.TabIndex = 40;
            // 
            // txtXscore
            // 
            this.txtXscore.Location = new System.Drawing.Point(508, 234);
            this.txtXscore.Name = "txtXscore";
            this.txtXscore.ReadOnly = true;
            this.txtXscore.Size = new System.Drawing.Size(37, 26);
            this.txtXscore.TabIndex = 39;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(448, 485);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(202, 26);
            this.txtemail.TabIndex = 26;
            // 
            // lbldraw
            // 
            this.lbldraw.AutoSize = true;
            this.lbldraw.Location = new System.Drawing.Point(446, 306);
            this.lbldraw.Name = "lbldraw";
            this.lbldraw.Size = new System.Drawing.Size(58, 20);
            this.lbldraw.TabIndex = 38;
            this.lbldraw.Text = "Draws:";
            // 
            // lblplayero
            // 
            this.lblplayero.AutoSize = true;
            this.lblplayero.Location = new System.Drawing.Point(430, 271);
            this.lblplayero.Name = "lblplayero";
            this.lblplayero.Size = new System.Drawing.Size(72, 20);
            this.lblplayero.TabIndex = 37;
            this.lblplayero.Text = "Player O:";
            // 
            // lblplayerx
            // 
            this.lblplayerx.AutoSize = true;
            this.lblplayerx.Location = new System.Drawing.Point(430, 237);
            this.lblplayerx.Name = "lblplayerx";
            this.lblplayerx.Size = new System.Drawing.Size(71, 20);
            this.lblplayerx.TabIndex = 36;
            this.lblplayerx.Text = "Player X:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(442, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 32);
            this.label1.TabIndex = 35;
            this.label1.Text = "Score:";
            // 
            // btnsend
            // 
            this.btnsend.AutoSize = true;
            this.btnsend.Location = new System.Drawing.Point(657, 483);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(86, 32);
            this.btnsend.TabIndex = 28;
            this.btnsend.Text = "Send";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Email Score To:";
            // 
            // btnnewround
            // 
            this.btnnewround.Location = new System.Drawing.Point(10, 480);
            this.btnnewround.Name = "btnnewround";
            this.btnnewround.Size = new System.Drawing.Size(146, 35);
            this.btnnewround.TabIndex = 21;
            this.btnnewround.Text = "New Round";
            this.btnnewround.UseVisualStyleBackColor = true;
            this.btnnewround.Click += new System.EventHandler(this.btnnewround_Click);
            // 
            // btnC3
            // 
            this.btnC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC3.Location = new System.Drawing.Point(262, 302);
            this.btnC3.Name = "btnC3";
            this.btnC3.Size = new System.Drawing.Size(120, 123);
            this.btnC3.TabIndex = 20;
            this.btnC3.UseVisualStyleBackColor = true;
            this.btnC3.Click += new System.EventHandler(this.btn_click);
            this.btnC3.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnC3.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnC2
            // 
            this.btnC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC2.Location = new System.Drawing.Point(136, 302);
            this.btnC2.Name = "btnC2";
            this.btnC2.Size = new System.Drawing.Size(120, 123);
            this.btnC2.TabIndex = 19;
            this.btnC2.UseVisualStyleBackColor = true;
            this.btnC2.Click += new System.EventHandler(this.btn_click);
            this.btnC2.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnC2.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnC1
            // 
            this.btnC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC1.Location = new System.Drawing.Point(10, 302);
            this.btnC1.Name = "btnC1";
            this.btnC1.Size = new System.Drawing.Size(120, 123);
            this.btnC1.TabIndex = 18;
            this.btnC1.UseVisualStyleBackColor = true;
            this.btnC1.Click += new System.EventHandler(this.btn_click);
            this.btnC1.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnC1.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnB3
            // 
            this.btnB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB3.Location = new System.Drawing.Point(262, 172);
            this.btnB3.Name = "btnB3";
            this.btnB3.Size = new System.Drawing.Size(120, 123);
            this.btnB3.TabIndex = 17;
            this.btnB3.UseVisualStyleBackColor = true;
            this.btnB3.Click += new System.EventHandler(this.btn_click);
            this.btnB3.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnB3.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnB2
            // 
            this.btnB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB2.Location = new System.Drawing.Point(136, 172);
            this.btnB2.Name = "btnB2";
            this.btnB2.Size = new System.Drawing.Size(120, 123);
            this.btnB2.TabIndex = 16;
            this.btnB2.UseVisualStyleBackColor = true;
            this.btnB2.Click += new System.EventHandler(this.btn_click);
            this.btnB2.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnB2.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnB1
            // 
            this.btnB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB1.Location = new System.Drawing.Point(10, 172);
            this.btnB1.Name = "btnB1";
            this.btnB1.Size = new System.Drawing.Size(120, 123);
            this.btnB1.TabIndex = 15;
            this.btnB1.UseVisualStyleBackColor = true;
            this.btnB1.Click += new System.EventHandler(this.btn_click);
            this.btnB1.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnB1.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnA3
            // 
            this.btnA3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA3.Location = new System.Drawing.Point(262, 45);
            this.btnA3.Name = "btnA3";
            this.btnA3.Size = new System.Drawing.Size(120, 123);
            this.btnA3.TabIndex = 14;
            this.btnA3.UseVisualStyleBackColor = true;
            this.btnA3.Click += new System.EventHandler(this.btn_click);
            this.btnA3.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnA3.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnA2
            // 
            this.btnA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA2.Location = new System.Drawing.Point(136, 45);
            this.btnA2.Name = "btnA2";
            this.btnA2.Size = new System.Drawing.Size(120, 123);
            this.btnA2.TabIndex = 13;
            this.btnA2.UseVisualStyleBackColor = true;
            this.btnA2.Click += new System.EventHandler(this.btn_click);
            this.btnA2.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnA2.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnA1
            // 
            this.btnA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA1.Location = new System.Drawing.Point(10, 45);
            this.btnA1.Name = "btnA1";
            this.btnA1.Size = new System.Drawing.Size(120, 123);
            this.btnA1.TabIndex = 12;
            this.btnA1.UseVisualStyleBackColor = true;
            this.btnA1.Click += new System.EventHandler(this.btn_click);
            this.btnA1.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnA1.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(756, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(182, 30);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(182, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(770, 575);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 597);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TrackBar trackBarProgress;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Button btnpause;
        private System.Windows.Forms.Button btnfullscreen;
        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblroundo;
        private System.Windows.Forms.Label lblroundx;
        private System.Windows.Forms.Label lblround;
        private System.Windows.Forms.TextBox txtDraw;
        private System.Windows.Forms.TextBox txtOscore;
        private System.Windows.Forms.TextBox txtXscore;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lbldraw;
        private System.Windows.Forms.Label lblplayero;
        private System.Windows.Forms.Label lblplayerx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnnewround;
        private System.Windows.Forms.Button btnC3;
        private System.Windows.Forms.Button btnC2;
        private System.Windows.Forms.Button btnC1;
        private System.Windows.Forms.Button btnB3;
        private System.Windows.Forms.Button btnB2;
        private System.Windows.Forms.Button btnB1;
        private System.Windows.Forms.Button btnA3;
        private System.Windows.Forms.Button btnA2;
        private System.Windows.Forms.Button btnA1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

