namespace XenLauncherGradient
{
    partial class XEN
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
            this.closeButton = new System.Windows.Forms.Button();
            this.dragBorder = new System.Windows.Forms.Panel();
            this.minmizeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.curOnline = new System.Windows.Forms.Label();
            this.serverName = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.XenLink = new System.Windows.Forms.Button();
            this.serverHeader = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.onlinePlayers = new System.Windows.Forms.Label();
            this.dragBorder.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.Transparent;
            this.closeButton.Location = new System.Drawing.Point(868, -3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(42, 28);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // dragBorder
            // 
            this.dragBorder.BackColor = System.Drawing.Color.Transparent;
            this.dragBorder.Controls.Add(this.minmizeButton);
            this.dragBorder.Controls.Add(this.closeButton);
            this.dragBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.dragBorder.Location = new System.Drawing.Point(0, 0);
            this.dragBorder.Name = "dragBorder";
            this.dragBorder.Size = new System.Drawing.Size(910, 28);
            this.dragBorder.TabIndex = 1;
            this.dragBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragBorder_MouseDown);
            this.dragBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dragBorder_MouseMove);
            this.dragBorder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dragBorder_MouseUp);
            // 
            // minmizeButton
            // 
            this.minmizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minmizeButton.FlatAppearance.BorderSize = 0;
            this.minmizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.minmizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.minmizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minmizeButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minmizeButton.ForeColor = System.Drawing.Color.White;
            this.minmizeButton.Location = new System.Drawing.Point(831, -3);
            this.minmizeButton.Name = "minmizeButton";
            this.minmizeButton.Size = new System.Drawing.Size(38, 28);
            this.minmizeButton.TabIndex = 7;
            this.minmizeButton.Text = "-";
            this.minmizeButton.UseVisualStyleBackColor = false;
            this.minmizeButton.Click += new System.EventHandler(this.minmizeButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.curOnline);
            this.panel1.Controls.Add(this.serverName);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(78, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 54);
            this.panel1.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(299, 14);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 27);
            this.button4.TabIndex = 10;
            this.button4.Text = "Show Players Online";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // curOnline
            // 
            this.curOnline.AutoSize = true;
            this.curOnline.BackColor = System.Drawing.Color.Transparent;
            this.curOnline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.curOnline.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curOnline.ForeColor = System.Drawing.Color.White;
            this.curOnline.Location = new System.Drawing.Point(96, 24);
            this.curOnline.Name = "curOnline";
            this.curOnline.Size = new System.Drawing.Size(90, 17);
            this.curOnline.TabIndex = 10;
            this.curOnline.Text = "Player Count";
            // 
            // serverName
            // 
            this.serverName.BackColor = System.Drawing.Color.Transparent;
            this.serverName.FlatAppearance.BorderSize = 0;
            this.serverName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.serverName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.serverName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serverName.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverName.ForeColor = System.Drawing.Color.White;
            this.serverName.Location = new System.Drawing.Point(0, -13);
            this.serverName.Name = "serverName";
            this.serverName.Size = new System.Drawing.Size(258, 54);
            this.serverName.TabIndex = 3;
            this.serverName.Text = "Xen Dev";
            this.serverName.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(463, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 27);
            this.button2.TabIndex = 3;
            this.button2.Text = "Connect";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(578, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Clear Cache";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // XenLink
            // 
            this.XenLink.BackColor = System.Drawing.Color.Transparent;
            this.XenLink.FlatAppearance.BorderSize = 0;
            this.XenLink.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.XenLink.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.XenLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XenLink.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XenLink.ForeColor = System.Drawing.Color.White;
            this.XenLink.Location = new System.Drawing.Point(-103, 442);
            this.XenLink.Name = "XenLink";
            this.XenLink.Size = new System.Drawing.Size(344, 23);
            this.XenLink.TabIndex = 5;
            this.XenLink.Text = "Made by IceyyM8";
            this.XenLink.UseVisualStyleBackColor = false;
            this.XenLink.Click += new System.EventHandler(this.XenLink_Click);
            // 
            // serverHeader
            // 
            this.serverHeader.BackColor = System.Drawing.Color.Transparent;
            this.serverHeader.FlatAppearance.BorderSize = 0;
            this.serverHeader.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.serverHeader.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.serverHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serverHeader.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverHeader.ForeColor = System.Drawing.Color.White;
            this.serverHeader.Location = new System.Drawing.Point(336, 68);
            this.serverHeader.Name = "serverHeader";
            this.serverHeader.Size = new System.Drawing.Size(240, 49);
            this.serverHeader.TabIndex = 6;
            this.serverHeader.Text = "Xen Development";
            this.serverHeader.UseVisualStyleBackColor = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Maroon;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 22);
            this.button3.TabIndex = 8;
            this.button3.Text = "Set Cache Location";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(185, 5);
            this.textBox1.MaxLength = 500;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(463, 15);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Paste cache location here and click set cache location";
            this.textBox1.WordWrap = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.MouseEnter += new System.EventHandler(this.textBox1_MouseEnter);
            this.textBox1.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(105, 261);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 28);
            this.panel2.TabIndex = 9;
            // 
            // onlinePlayers
            // 
            this.onlinePlayers.AutoSize = true;
            this.onlinePlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.onlinePlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onlinePlayers.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlinePlayers.ForeColor = System.Drawing.Color.White;
            this.onlinePlayers.Location = new System.Drawing.Point(104, 303);
            this.onlinePlayers.Name = "onlinePlayers";
            this.onlinePlayers.Size = new System.Drawing.Size(121, 20);
            this.onlinePlayers.TabIndex = 10;
            this.onlinePlayers.Text = "Players Online:";
            this.onlinePlayers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // XEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::XenLauncherGradient.Properties.Resources.d1b596_Clear;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(910, 465);
            this.Controls.Add(this.onlinePlayers);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.serverHeader);
            this.Controls.Add(this.XenLink);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dragBorder);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "XEN";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.XEN_Load);
            this.dragBorder.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel dragBorder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button XenLink;
        private System.Windows.Forms.Button serverHeader;
        private System.Windows.Forms.Button serverName;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button minmizeButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label curOnline;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label onlinePlayers;
    }
}

