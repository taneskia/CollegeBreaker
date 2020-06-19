namespace CollegeBreaker
{
    partial class ToolsForm
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
            this.PanelMain = new System.Windows.Forms.Panel();
            this.LabelTime = new System.Windows.Forms.Label();
            this.ButtonPause = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.TimerCount = new System.Windows.Forms.Timer(this.components);
            this.ButtonRetry = new System.Windows.Forms.Button();
            this.PanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PanelMain.Controls.Add(this.ButtonRetry);
            this.PanelMain.Controls.Add(this.LabelTime);
            this.PanelMain.Controls.Add(this.ButtonPause);
            this.PanelMain.Controls.Add(this.ButtonExit);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(3, 2);
            this.PanelMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(261, 753);
            this.PanelMain.TabIndex = 0;
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTime.ForeColor = System.Drawing.Color.White;
            this.LabelTime.Location = new System.Drawing.Point(71, 47);
            this.LabelTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(119, 46);
            this.LabelTime.TabIndex = 2;
            this.LabelTime.Text = "01:15";
            // 
            // ButtonPause
            // 
            this.ButtonPause.BackColor = System.Drawing.Color.OrangeRed;
            this.ButtonPause.BackgroundImage = global::CollegeBreaker.Properties.Resources.Play_Clean;
            this.ButtonPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPause.Location = new System.Drawing.Point(27, 567);
            this.ButtonPause.Margin = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.ButtonPause.Name = "ButtonPause";
            this.ButtonPause.Size = new System.Drawing.Size(208, 55);
            this.ButtonPause.TabIndex = 1;
            this.ButtonPause.Text = "Pause";
            this.ButtonPause.UseVisualStyleBackColor = false;
            this.ButtonPause.Click += new System.EventHandler(this.ButtonPause_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.OrangeRed;
            this.ButtonExit.BackgroundImage = global::CollegeBreaker.Properties.Resources.Exit_Clean;
            this.ButtonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExit.Location = new System.Drawing.Point(27, 672);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(208, 55);
            this.ButtonExit.TabIndex = 0;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = false;
            // 
            // TimerCount
            // 
            this.TimerCount.Enabled = true;
            this.TimerCount.Interval = 1000;
            this.TimerCount.Tick += new System.EventHandler(this.TimerCount_Tick);
            // 
            // ButtonRetry
            // 
            this.ButtonRetry.BackColor = System.Drawing.Color.OrangeRed;
            this.ButtonRetry.BackgroundImage = global::CollegeBreaker.Properties.Resources.Play_Clean;
            this.ButtonRetry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonRetry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRetry.Location = new System.Drawing.Point(27, 462);
            this.ButtonRetry.Margin = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.ButtonRetry.Name = "ButtonRetry";
            this.ButtonRetry.Size = new System.Drawing.Size(208, 55);
            this.ButtonRetry.TabIndex = 3;
            this.ButtonRetry.Text = "Retry";
            this.ButtonRetry.UseVisualStyleBackColor = false;
            // 
            // ToolsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(267, 757);
            this.Controls.Add(this.PanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ToolsForm";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Text = "`";
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Timer TimerCount;
        public System.Windows.Forms.Button ButtonPause;
        public System.Windows.Forms.Button ButtonRetry;
    }
}