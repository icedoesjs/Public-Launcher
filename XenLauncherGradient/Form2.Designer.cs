namespace XenLauncherGradient
{
    partial class Form2
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
            this.closeBoard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeBoard
            // 
            this.closeBoard.BackColor = System.Drawing.Color.Maroon;
            this.closeBoard.FlatAppearance.BorderSize = 0;
            this.closeBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBoard.ForeColor = System.Drawing.Color.White;
            this.closeBoard.Location = new System.Drawing.Point(760, 444);
            this.closeBoard.Name = "closeBoard";
            this.closeBoard.Size = new System.Drawing.Size(75, 25);
            this.closeBoard.TabIndex = 0;
            this.closeBoard.Text = "Close";
            this.closeBoard.UseVisualStyleBackColor = false;
            this.closeBoard.Click += new System.EventHandler(this.closeBoard_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::XenLauncherGradient.Properties.Resources.d1b596_Clear;
            this.ClientSize = new System.Drawing.Size(837, 470);
            this.Controls.Add(this.closeBoard);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Players Online";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeBoard;
    }
}