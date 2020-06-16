
using CollegeBreaker.Properties;
using System.Drawing;
using System.IO;

namespace CollegeBreaker
{
    partial class MainForm
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
            this.PanelMain = new System.Windows.Forms.Panel();
            this.ButtonPlay = new System.Windows.Forms.Button();
            this.LabelTop3 = new System.Windows.Forms.Label();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.LabelTop2 = new System.Windows.Forms.Label();
            this.LabelTop1 = new System.Windows.Forms.Label();
            this.LabelScoreboard = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.PanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PanelMain.Controls.Add(this.ButtonPlay);
            this.PanelMain.Controls.Add(this.LabelTop3);
            this.PanelMain.Controls.Add(this.ButtonExit);
            this.PanelMain.Controls.Add(this.LabelTop2);
            this.PanelMain.Controls.Add(this.LabelTop1);
            this.PanelMain.Controls.Add(this.LabelScoreboard);
            this.PanelMain.Controls.Add(this.LabelTitle);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(2, 2);
            this.PanelMain.Margin = new System.Windows.Forms.Padding(0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(366, 496);
            this.PanelMain.TabIndex = 0;
            // 
            // ButtonPlay
            // 
            this.ButtonPlay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonPlay.BackColor = System.Drawing.Color.LawnGreen;
            this.ButtonPlay.BackgroundImage = global::CollegeBreaker.Properties.Resources.Play_Clean;
            this.ButtonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonPlay.FlatAppearance.BorderSize = 0;
            this.ButtonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPlay.ForeColor = System.Drawing.Color.Black;
            this.ButtonPlay.Location = new System.Drawing.Point(85, 342);
            this.ButtonPlay.Margin = new System.Windows.Forms.Padding(30, 40, 30, 20);
            this.ButtonPlay.Name = "ButtonPlay";
            this.ButtonPlay.Size = new System.Drawing.Size(200, 41);
            this.ButtonPlay.TabIndex = 5;
            this.ButtonPlay.Text = "Play";
            this.ButtonPlay.UseVisualStyleBackColor = false;
            this.ButtonPlay.Click += new System.EventHandler(this.ButtonPlay_Click);
            // 
            // LabelTop3
            // 
            this.LabelTop3.AutoSize = true;
            this.LabelTop3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTop3.ForeColor = System.Drawing.Color.White;
            this.LabelTop3.Location = new System.Drawing.Point(128, 266);
            this.LabelTop3.Name = "LabelTop3";
            this.LabelTop3.Size = new System.Drawing.Size(115, 26);
            this.LabelTop3.TabIndex = 4;
            this.LabelTop3.Text = "Blazhe: 89";
            // 
            // ButtonExit
            // 
            this.ButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonExit.BackColor = System.Drawing.Color.OrangeRed;
            this.ButtonExit.BackgroundImage = global::CollegeBreaker.Properties.Resources.Exit_Clean;
            this.ButtonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonExit.FlatAppearance.BorderSize = 0;
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.ForeColor = System.Drawing.Color.Black;
            this.ButtonExit.Location = new System.Drawing.Point(85, 417);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(10);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(200, 41);
            this.ButtonExit.TabIndex = 0;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = false;
            // 
            // LabelTop2
            // 
            this.LabelTop2.AutoSize = true;
            this.LabelTop2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTop2.ForeColor = System.Drawing.Color.White;
            this.LabelTop2.Location = new System.Drawing.Point(135, 240);
            this.LabelTop2.Name = "LabelTop2";
            this.LabelTop2.Size = new System.Drawing.Size(100, 26);
            this.LabelTop2.TabIndex = 3;
            this.LabelTop2.Text = "Goce: 92";
            // 
            // LabelTop1
            // 
            this.LabelTop1.AutoSize = true;
            this.LabelTop1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTop1.ForeColor = System.Drawing.Color.White;
            this.LabelTop1.Location = new System.Drawing.Point(142, 214);
            this.LabelTop1.Name = "LabelTop1";
            this.LabelTop1.Size = new System.Drawing.Size(87, 26);
            this.LabelTop1.TabIndex = 2;
            this.LabelTop1.Text = "Kire: 98";
            // 
            // LabelScoreboard
            // 
            this.LabelScoreboard.AutoSize = true;
            this.LabelScoreboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScoreboard.ForeColor = System.Drawing.Color.White;
            this.LabelScoreboard.Location = new System.Drawing.Point(112, 178);
            this.LabelScoreboard.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.LabelScoreboard.Name = "LabelScoreboard";
            this.LabelScoreboard.Size = new System.Drawing.Size(146, 29);
            this.LabelScoreboard.TabIndex = 1;
            this.LabelScoreboard.Text = "Scoreboard:";
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.ForeColor = System.Drawing.Color.Gold;
            this.LabelTitle.Location = new System.Drawing.Point(79, 33);
            this.LabelTitle.Margin = new System.Windows.Forms.Padding(30);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(212, 63);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "College";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(370, 500);
            this.Controls.Add(this.PanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "College Breaker";
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Label LabelScoreboard;
        private System.Windows.Forms.Label LabelTop2;
        private System.Windows.Forms.Label LabelTop1;
        private System.Windows.Forms.Button ButtonPlay;
        private System.Windows.Forms.Label LabelTop3;
    }
}