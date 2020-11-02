using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XenLauncherGradient
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void closeBoard_Click(object sender, EventArgs e)
        {
            this.Close();
            var mainUI = new XEN();
            mainUI.Show();


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);

            this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            this.AutoSize = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            this.ShowInTaskbar = false;
        }
    }
}
