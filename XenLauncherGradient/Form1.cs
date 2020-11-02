using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using XenLauncherGradient.Properties;
using System.Net;
using System.Web.Script.Serialization;
using Newtonsoft.Json.Linq;
using System.Drawing;
using System.Linq;

namespace XenLauncherGradient
{
    public partial class XEN : Form
    {

        string IP = "YOUR SERVER IP+port";
        string discordLink = "https://discord.gg/8JHtRPm";
        string websiteLink = "https://google.com";
        int mov;
        int movY;
        int movX;
        string messageReturn = "Cache was cleared";
        string captionReturn = "Cache cleared succesfully!";
        string cacheLocation = Settings.Default["CacheLocation"].ToString();
        bool changed = false;
        
       
        MessageBoxButtons buttons = MessageBoxButtons.OK;
        public XEN()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void dragBorder_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;

        }

        private void dragBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void dragBorder_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(discordLink);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!getServerStatus())
            {
                messageReturn = "Server is offline.";
                captionReturn = "Failed to reach server";
                MessageBox.Show(messageReturn, captionReturn, buttons);
            }
            try
            {
                System.Diagnostics.Process.Start("fivem://connect/" + IP);
                this.Close();
            } catch(Exception error)
            {
                captionReturn = "Failed to open FiveM";
                messageReturn = "Make sure FiveM is installed";
                MessageBox.Show(messageReturn, captionReturn, buttons);
            }
            
        }

        private void websiteButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(websiteLink);
        }

        private void XenLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(discordLink);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool cacheFound = Directory.Exists(cacheLocation);
            if (cacheFound == true)
            {
                try
                {
                    Directory.Delete(cacheLocation, true);
                    MessageBox.Show(messageReturn, captionReturn, buttons);
                } catch(Exception err)
                {
                    messageReturn = "Most likely failed to delete due to permission";
                    captionReturn = "Failed to delete cache";
                    MessageBox.Show(messageReturn, captionReturn, buttons);
                }
            } else
            {
                messageReturn = "Make sure the cache location is set";
                captionReturn = "Cache Not found";
                MessageBox.Show(messageReturn, captionReturn, buttons);
            }


        }

        private void minmizeButton_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.25;
            } else
            {
                timer1.Stop();
                Application.Exit();
            }
        }

        private void websiteLauncher_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(websiteLink);
        }

        private void XEN_Load(object sender, EventArgs e)
        {
            curOnline.Text = getPlayerCount();
            onlinePlayers.Visible = false;
            if (!getServerStatus())
            {
                button4.Visible = false;

                button2.Text = "Server Offline";
                button2.BackColor = Color.FromName("DimGray");

                serverHeader.Text = "Server Unreachable";
                serverHeader.Size = new Size(320, serverHeader.Size.Height);

                serverName.Text = "Server Unreachable";
            }
            if (cacheLocation == "No Location Specified")
            {
                textBox1.Text = "Paste cache location here and click set cache location";
            }
            else
            {
                textBox1.Text = cacheLocation;
            }

            

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                captionReturn = "No file path specified";
                messageReturn = "Please supply a path then click set cache location.";
                MessageBox.Show(messageReturn, captionReturn, buttons);
                return;
            } else if(textBox1.Text == "Paste cache location here and click set cache location")
            {
                captionReturn = "Improper file path specified";
                messageReturn = "Please supply a path then click set cache location.";
                MessageBox.Show(messageReturn, captionReturn, buttons);
                return;
            } else if(!Directory.Exists(textBox1.Text))
            {
                captionReturn = "Improper file path specified";
                messageReturn = "Please supply a path then click set cache location.";
                MessageBox.Show(messageReturn, captionReturn, buttons);
                return;
            }
            {
                captionReturn = "Cache location saved!";
                messageReturn = "The new location was saved, the program will reboot";
                Settings.Default["CacheLocation"] = textBox1.Text;
                Settings.Default.Save();
                if (MessageBox.Show(messageReturn, captionReturn, buttons) == DialogResult.OK)
                {
                    Application.Restart();
                } else
                {
                    Application.Restart();
                }

            }
            
        }

        public class TimedWebClient : WebClient
        {
            public int Timeout { get; set; }

            public TimedWebClient()
            {
                this.Timeout = 1000;
            }

            protected override WebRequest GetWebRequest(Uri address)
            {
                var objWebRequest = base.GetWebRequest(address);
                objWebRequest.Timeout = this.Timeout;
                return objWebRequest;
            }
        }

        public string getPlayerCount()
        { 
            string infoURL = "http://" + IP + "/info.json";
            string playerURL = "http://" + IP + "/players.json";
            var infoClient = new TimedWebClient();
            var playerClient = new TimedWebClient();
            infoClient.Timeout = 2000;
            playerClient.Timeout = 2000;
            try
            {
                int playerCount;
                var playerResponse = playerClient.DownloadString(playerURL);
                var infoResponse = infoClient.DownloadString(infoURL);
                
                    dynamic infoData = JObject.Parse(infoResponse);
                try
                {
                    JavaScriptSerializer serializer = new JavaScriptSerializer();
                    dynamic playerData = serializer.Deserialize<dynamic>(playerResponse);
                    playerCount = playerData.Length;
                } catch( Exception error)
                {
                     playerCount = 0;
                }
                    string maxPlayerCount = infoData.vars.sv_maxClients;
                        
                        return playerCount + "/" + maxPlayerCount;
            } catch (Exception Error)
            {
                return "Offline";
            }
        } 

        public class ServerData
        {
           public string icon { get; set; }
           public ServerVars vars { get; set; }
            
        }

        public class ServerVars
        {
            public string sv_maxClients { get; set; }
            public string sv_scriptHookAllowed { get; set; }

            public string banner_connecting { get; set; }
            public string banner_detail { get; set; }
        }
        public class PlayerData
        {
            public string name { get; set; }
            public string id { get; set; }
            public string ping { get; set; }
        }

        public string retPlayers()
        {
            string playerURL = "http://" + IP + "/players.json";
            var playerClient = new TimedWebClient();
            playerClient.Timeout = 2000;
            var playerResponse = playerClient.DownloadString(playerURL);
            if (playerResponse.ToString() == "[]") return "No Players Online";
            string ret = "Showing first 30 Players Online:\n";
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List <PlayerData> playerData = serializer.Deserialize<List<PlayerData>>(playerResponse);

            foreach(var player in playerData.Take(30))
            {
                ret = ret + "\n" + player.name + " | Id: " + player.id + " | Ping:" + player.ping;
            }
            
            return ret;

        }

        public bool getServerStatus()
        {
            string serverURL = "http://" + IP;
            var playerClient = new TimedWebClient();
            playerClient.Timeout = 2000;
            try
            {
                var data = playerClient.DownloadData(serverURL);
                if (data != null) return true;
            } catch(Exception Error)
            {
                return false;
            }
            return false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(onlinePlayers.Visible) { onlinePlayers.Visible = false;
                button4.Text = "Show Online Players";
            } else { onlinePlayers.Visible = true;
                button4.Text = "Online Players Shown";
            }
            this.Hide();
            var scoreBoard = new Form2();
            var scoreBoardPanel = new Panel();
            scoreBoard.AutoSize = true;
            scoreBoardPanel.AutoSize = true;
            scoreBoardPanel.BackColor = Color.Transparent;
            scoreBoardPanel.Size = new Size(834, 439);

            Label playerMenu = new Label();
            playerMenu.Font = new System.Drawing.Font(playerMenu.Font.Name, 8, FontStyle.Bold);
            playerMenu.TextAlign = ContentAlignment.MiddleCenter;
            playerMenu.Dock = DockStyle.Fill;


            Size txtSize = TextRenderer.MeasureText(retPlayers(), playerMenu.Font);
            scoreBoard.Size = new Size(txtSize.Width, txtSize.Height);
            playerMenu.Text = retPlayers();
            playerMenu.AutoSize = false;
            playerMenu.Location = new Point(100, 100);
            playerMenu.BorderStyle = BorderStyle.None;
            playerMenu.FlatStyle = FlatStyle.Flat;
            scoreBoardPanel.Controls.Add(playerMenu);
            scoreBoard.Controls.Add(scoreBoardPanel);
            scoreBoard.Show();

        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            if (changed = false)
            {
                textBox1.Text = "";
            } else
            {
                textBox1.Text = Settings.Default["CacheLocation"].ToString();
            }
            
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            
            if (changed = false)
            {
                textBox1.Text = "Paste cache location here and click set cache location";
            } else if (textBox1.Text != "Paste cache location here and click set cache location")
            {
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            changed = true;
        }
    }
}
