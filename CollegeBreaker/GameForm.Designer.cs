namespace CollegeBreaker
{
    partial class GameForm
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
            this.StatsPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // StatsPanel
            // 
            this.StatsPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StatsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.StatsPanel.Location = new System.Drawing.Point(0, 0);
            this.StatsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StatsPanel.Name = "StatsPanel";
            this.StatsPanel.Size = new System.Drawing.Size(624, 45);
            this.StatsPanel.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 17;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(624, 550);
            this.Controls.Add(this.StatsPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GameForm";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameForm_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel StatsPanel;
        private System.Windows.Forms.Timer timer1;
    }
}

