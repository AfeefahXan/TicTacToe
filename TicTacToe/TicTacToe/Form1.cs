using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;
using MyVideo;


namespace FTTTV1_Testpage_3
{
    public partial class Form1 : Form
    {
        // Instantiate the Media class
        Media myMedia = new Media();

        //create a file dialog window
        OpenFileDialog file = new OpenFileDialog();


        //combobox names
        string[] addressBook = new string[100];
        string[] names = new string[100];

        bool XorO = true; //true = X, false = O
        int turnCount = 0; //number of turns
        double scoreX = 0;
        double scoreO = 0;
        double scoreDraw = 0;

        //Scoring System
        double dblA = 2;
        double dblB = 2.5;
        double dblC = 5;
        double dblD = 1;

        //fade animation
        int[] targetColor = { 0, 0, 0 };
        int[] fadeRGB = new int[3];

        public Form1()
        {
            InitializeComponent();

            string strWeb = "https://www.google.com/";
            webBrowser1.Url = new Uri(strWeb);

                
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programmed by Afeefah Ali", "Information");
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_click(object sender, EventArgs e)
        {
            Button boardbutton = (Button)sender;

            if (XorO)
            {

                boardbutton.Text = "X";
            }
            else
            {
                boardbutton.Text = "O";
            }

            XorO = !XorO; //flips the turn
            boardbutton.Enabled = false; //disables button once pressed
            turnCount++;
            CheckForWinner();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Video Settings
            trackBarVolume.Value = 500;
            myMedia.Volume = trackBarVolume.Value;

            //Calculate Scoring
            scoreO = ((dblA * dblB) / dblC) - dblD;
            scoreX = ((dblA * dblB) / dblC) - dblD;
            scoreDraw = ((dblA * dblB) / dblC) - dblD;


            StreamReader txtReader = new StreamReader("playernames.txt");

            //Counter
            int j = 0;

            //Reads text file
            while (txtReader.Peek() != -1)
            {
                addressBook[j] = txtReader.ReadLine();
                j++;
            }

            j = 0; //reset counter

            //names for loop
            for (int i = 0; i < addressBook.Length; i += 3)
            {
                names[j] = addressBook[i];

                //Catches null statements
                if (names[j] != null)
                {
                    comboBox1.Items.Add(names[j]);
                    j++;
                }
            }
        }

        private void CheckForWinner()
        {

            bool visibleWin = false;

            //Checks Left-Right win
            if ((btnA1.Text == btnA2.Text) && (btnA2.Text == btnA3.Text) && (!btnA1.Enabled))
            {
                visibleWin = true;
            }
            else if ((btnB1.Text == btnB2.Text) && (btnB2.Text == btnB3.Text) && (!btnB1.Enabled))
            {
                visibleWin = true;
            }
            else if ((btnC1.Text == btnC2.Text) && (btnC2.Text == btnC3.Text) && (!btnC1.Enabled))
            {
                visibleWin = true;
            }

            //Checks Top-Bottom win
            else if ((btnA1.Text == btnB1.Text) && (btnB1.Text == btnC1.Text) && (!btnA1.Enabled))
            {
                visibleWin = true;
            }
            else if ((btnA2.Text == btnB2.Text) && (btnB2.Text == btnC2.Text) && (!btnA2.Enabled))
            {
                visibleWin = true;
            }
            else if ((btnA3.Text == btnB3.Text) && (btnB3.Text == btnC3.Text) && (!btnA3.Enabled))
            {
                visibleWin = true;
            }

            //Diagonal checks
            else if ((btnA1.Text == btnB2.Text) && (btnB2.Text == btnC3.Text) && (!btnA1.Enabled))
            {
                visibleWin = true;
            }
            else if ((btnA3.Text == btnB2.Text) && (btnB2.Text == btnC1.Text) && (!btnC1.Enabled))
            {
                visibleWin = true;
            }

            if (visibleWin)
            {
                disableB();
                timer1.Enabled = true;

                if (XorO)
                {
                    txtOscore.Text = Convert.ToString(scoreO += 1);
                    MessageBox.Show(lblplayero.Text + " Wins!", "Game Over!");
                }
                else
                {
                    txtXscore.Text = Convert.ToString(scoreX += 1);
                    MessageBox.Show(lblplayerx.Text + " Wins!", "Game Over!");
                }

            }
            else
            {
                if (turnCount == 9)
                {
                    txtDraw.Text = Convert.ToString(scoreDraw += 1);
                    MessageBox.Show("It's a Draw!", "Game Over!");
                }
            }
        }

        private void disableB()
        {
            btnA1.Enabled = false;
            btnA2.Enabled = false;
            btnA3.Enabled = false;
            btnB1.Enabled = false;
            btnB2.Enabled = false;
            btnB3.Enabled = false;
            btnC1.Enabled = false;
            btnC2.Enabled = false;
            btnC3.Enabled = false;

        }

        private void newGameToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //resets entire new game, including score count

            XorO = true;
            turnCount = 0;

            timer2.Enabled = true;

            btnA1.Enabled = true;
            btnA1.Text = "";
            btnA2.Enabled = true;
            btnA2.Text = "";
            btnA3.Enabled = true;
            btnA3.Text = "";
            btnB1.Enabled = true;
            btnB1.Text = "";
            btnB2.Enabled = true;
            btnB2.Text = "";
            btnB3.Enabled = true;
            btnB3.Text = "";
            btnC1.Enabled = true;
            btnC1.Text = "";
            btnC2.Enabled = true;
            btnC2.Text = "";
            btnC3.Enabled = true;
            btnC3.Text = "";

            txtXscore.Clear();
            txtOscore.Clear();
            txtDraw.Clear();

            scoreO = 0;
            scoreX = 0;
            scoreDraw = 0;
               

            
        }

        private void btnnewround_Click(object sender, EventArgs e)
        {
            //resets board for new round

            XorO = true;
            turnCount = 0;

            timer2.Enabled = true;

            btnA1.Enabled = true;
            btnA1.Text = "";
            btnA2.Enabled = true;
            btnA2.Text = "";
            btnA3.Enabled = true;
            btnA3.Text = "";
            btnB1.Enabled = true;
            btnB1.Text = "";
            btnB2.Enabled = true;
            btnB2.Text = "";
            btnB3.Enabled = true;
            btnB3.Text = "";
            btnC1.Enabled = true;
            btnC1.Text = "";
            btnC2.Enabled = true;
            btnC2.Text = "";
            btnC3.Enabled = true;
            btnC3.Text = "";
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mymail = new MailMessage();
                mymail.To.Add(new MailAddress(txtemail.ToString()));


                mymail.From = new MailAddress("pittcist2019@gmail.com ", "Afeefah Ali");
                mymail.Subject = "The total score count is:";
                mymail.Body = lblplayerx.Text + " " + txtXscore.Text + Environment.NewLine + lblplayero.Text + " " + txtOscore.Text + Environment.NewLine + lbldraw.Text + " " + txtDraw.Text;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("pittcist2019@gmail.com ", "pittcist0265");

                try
                {
                    smtp.Send(mymail);
                    MessageBox.Show("Your email is sent");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch
            {
                MessageBox.Show("Please enter an email address:", "Enter Email Address");
            }
        }

        private void selectbtn_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < addressBook.Length; i++)
                {
                    //Displays the selected name's corresponding text
                    if (addressBook[i] == comboBox1.SelectedItem.ToString())
                    {
                        //ShowNameLbl.Text = NameBox.SelectedItem.ToString();
                        lblplayerx.Text = addressBook[i + 1];
                        lblplayero.Text = addressBook[i + 2];
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please select a name from the dropbox:", "Select Name Type");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fadeout();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            fadein();
        }

        public void fadeout() //round letter fading out animation
        {

            if (XorO)
            {
                fadeRGB[0] = lblroundx.ForeColor.R;
                fadeRGB[1] = lblroundx.ForeColor.G;
                fadeRGB[2] = lblroundx.ForeColor.B;

                if (fadeRGB[0] > this.BackColor.R)
                {
                    fadeRGB[0]--;
                }
                else if (fadeRGB[0] < this.BackColor.R)
                {
                    fadeRGB[0]++;
                }

                if (fadeRGB[1] > this.BackColor.G)
                {
                    fadeRGB[1]--;
                }
                else if (fadeRGB[1] < this.BackColor.G)
                {
                    fadeRGB[1]++;
                }

                if (fadeRGB[2] > this.BackColor.B)
                {
                    fadeRGB[2]--;
                }
                else if (fadeRGB[2] < this.BackColor.B)
                {
                    fadeRGB[2]++;
                }

                if (fadeRGB[0] == this.BackColor.R && fadeRGB[1] == this.BackColor.G && fadeRGB[2] == this.BackColor.B)
                {
                    timer1.Stop();
                }

                lblroundx.ForeColor = Color.FromArgb(fadeRGB[0], fadeRGB[1], fadeRGB[2]);
            }
            else
            {
                fadeRGB[0] = lblroundo.ForeColor.R;
                fadeRGB[1] = lblroundo.ForeColor.G;
                fadeRGB[2] = lblroundo.ForeColor.B;

                if (fadeRGB[0] > this.BackColor.R)
                {
                    fadeRGB[0]--;
                }
                else if (fadeRGB[0] < this.BackColor.R)
                {
                    fadeRGB[0]++;
                }

                if (fadeRGB[1] > this.BackColor.G)
                {
                    fadeRGB[1]--;
                }
                else if (fadeRGB[1] < this.BackColor.G)
                {
                    fadeRGB[1]++;
                }

                if (fadeRGB[2] > this.BackColor.B)
                {
                    fadeRGB[2]--;
                }
                else if (fadeRGB[2] < this.BackColor.B)
                {
                    fadeRGB[2]++;
                }

                if (fadeRGB[0] == this.BackColor.R && fadeRGB[1] == this.BackColor.G && fadeRGB[2] == this.BackColor.B)
                {
                    timer1.Stop();
                }

                lblroundo.ForeColor = Color.FromArgb(fadeRGB[0], fadeRGB[1], fadeRGB[2]);
            }
        }

        public void fadein() //round letter fading in animation
        {
            fadeRGB[0] = lblroundx.ForeColor.R;
            fadeRGB[1] = lblroundx.ForeColor.G;
            fadeRGB[2] = lblroundx.ForeColor.B;

            fadeRGB[0] = lblroundo.ForeColor.R;
            fadeRGB[1] = lblroundo.ForeColor.G;
            fadeRGB[2] = lblroundo.ForeColor.B;

            if (fadeRGB[0] > targetColor[0])
            {
                fadeRGB[0]--;
            }
            else if (fadeRGB[0] < targetColor[0])
            {
                fadeRGB[0]++;
            }

            if (fadeRGB[1] > targetColor[1])
            {
                fadeRGB[1]--;
            }
            else if (fadeRGB[1] < targetColor[1])
            {
                fadeRGB[1]++;
            }

            if (fadeRGB[2] > targetColor[2])
            {
                fadeRGB[2]--;
            }
            else if (fadeRGB[2] < targetColor[2])
            {
                fadeRGB[2]++;
            }

            if (fadeRGB[0] == targetColor[0] && fadeRGB[1] == targetColor[1] && fadeRGB[2] == targetColor[2])
            {
                timer2.Stop();
            }

            lblroundx.ForeColor = Color.FromArgb(fadeRGB[0], fadeRGB[1], fadeRGB[2]);
            lblroundo.ForeColor = Color.FromArgb(fadeRGB[0], fadeRGB[1], fadeRGB[2]);
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button boardbutton = (Button)sender;

            if (XorO)
            {
                boardbutton.Text = "X";
            }
            else
            {
                boardbutton.Text = "O";
            }
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button boardbutton = (Button)sender;

            if (boardbutton.Enabled)
            {
                boardbutton.Text = "";
            }
        }

        private void trackBarProgress_Scroll(object sender, EventArgs e)
        {
            //Slide the trackbar to fast forward or back
            myMedia.Position = trackBarProgress.Value;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create a file filter - only show the .wmv files
            file.Filter = "Windows Media Files | *.wmv; *.wav; *.mp4; *.ve; *.mkv; *.MOV";

            //Set the current directory to the initial directory
            file.InitialDirectory = Directory.GetCurrentDirectory();

            //Show the OpenFileDialog
            file.ShowDialog();

            myMedia.Open(file.FileName, pictureBox1);
            myMedia.Stop();
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            myMedia.Play();
            timer3.Enabled = true;
        }

        private void btnfullscreen_Click(object sender, EventArgs e)
        {
            myMedia.FullScreen();
        }

        private void btnpause_Click(object sender, EventArgs e)
        {
            //! == not: it flips the status of a boolean value
            myMedia.Pause = !myMedia.Pause;
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            myMedia.Stop();
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            myMedia.Volume = trackBarVolume.Value;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = myMedia.Position;
            trackBarProgress.Value = myMedia.Position;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
