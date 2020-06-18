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
            this.TimerFPS = new System.Windows.Forms.Timer(this.components);
            this.PanelPaused = new System.Windows.Forms.Panel();
            this.LabelPaused = new System.Windows.Forms.Label();
            this.TimerPlayerMove = new System.Windows.Forms.Timer(this.components);
            this.PanelPaused.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerFPS
            // 
            this.TimerFPS.Interval = 17;
            this.TimerFPS.Tick += new System.EventHandler(this.TimerFPS_Tick);
            // 
            // PanelPaused
            // 
            this.PanelPaused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PanelPaused.Controls.Add(this.LabelPaused);
            this.PanelPaused.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPaused.Location = new System.Drawing.Point(2, 2);
            this.PanelPaused.Margin = new System.Windows.Forms.Padding(0);
            this.PanelPaused.Name = "PanelPaused";
            this.PanelPaused.Size = new System.Drawing.Size(620, 546);
            this.PanelPaused.TabIndex = 0;
            this.PanelPaused.Visible = false;
            // 
            // LabelPaused
            // 
            this.LabelPaused.AutoSize = true;
            this.LabelPaused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LabelPaused.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPaused.ForeColor = System.Drawing.Color.Gold;
            this.LabelPaused.Location = new System.Drawing.Point(228, 250);
            this.LabelPaused.Name = "LabelPaused";
            this.LabelPaused.Size = new System.Drawing.Size(169, 51);
            this.LabelPaused.TabIndex = 0;
            this.LabelPaused.Text = "Paused";
            this.LabelPaused.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerPlayerMove
            // 
            this.TimerPlayerMove.Interval = 15;
            this.TimerPlayerMove.Tick += new System.EventHandler(this.TimerPlayerMove_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(624, 550);
            this.Controls.Add(this.PanelPaused);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "College Breaker";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyUp);
            this.PanelPaused.ResumeLayout(false);
            this.PanelPaused.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Timer TimerFPS;
        private System.Windows.Forms.Label LabelPaused;
        public System.Windows.Forms.Panel PanelPaused;
        public System.Windows.Forms.Timer TimerPlayerMove;
    }
}

