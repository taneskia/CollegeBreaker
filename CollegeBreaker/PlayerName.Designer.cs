namespace CollegeBreaker
{
    partial class PlayerName
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
            this.LabelPlayerName = new System.Windows.Forms.Label();
            this.TextboxName = new System.Windows.Forms.TextBox();
            this.ButtonChoose = new System.Windows.Forms.Button();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.PanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelPlayerName
            // 
            this.LabelPlayerName.AutoSize = true;
            this.LabelPlayerName.ForeColor = System.Drawing.Color.White;
            this.LabelPlayerName.Location = new System.Drawing.Point(92, 20);
            this.LabelPlayerName.Margin = new System.Windows.Forms.Padding(10, 17, 10, 10);
            this.LabelPlayerName.Name = "LabelPlayerName";
            this.LabelPlayerName.Size = new System.Drawing.Size(70, 13);
            this.LabelPlayerName.TabIndex = 0;
            this.LabelPlayerName.Text = "Player Name:";
            // 
            // TextboxName
            // 
            this.TextboxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxName.Location = new System.Drawing.Point(19, 53);
            this.TextboxName.Margin = new System.Windows.Forms.Padding(10);
            this.TextboxName.Name = "TextboxName";
            this.TextboxName.Size = new System.Drawing.Size(212, 23);
            this.TextboxName.TabIndex = 1;
            this.TextboxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ButtonChoose
            // 
            this.ButtonChoose.BackColor = System.Drawing.Color.LawnGreen;
            this.ButtonChoose.BackgroundImage = global::CollegeBreaker.Properties.Resources.Play_Clean;
            this.ButtonChoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonChoose.FlatAppearance.BorderSize = 0;
            this.ButtonChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonChoose.Location = new System.Drawing.Point(35, 89);
            this.ButtonChoose.Name = "ButtonChoose";
            this.ButtonChoose.Size = new System.Drawing.Size(180, 40);
            this.ButtonChoose.TabIndex = 2;
            this.ButtonChoose.Text = "Choose Name";
            this.ButtonChoose.UseVisualStyleBackColor = false;
            this.ButtonChoose.Click += new System.EventHandler(this.ButtonChoose_Click);
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PanelMain.Controls.Add(this.TextboxName);
            this.PanelMain.Controls.Add(this.ButtonChoose);
            this.PanelMain.Controls.Add(this.LabelPlayerName);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(2, 2);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(246, 146);
            this.PanelMain.TabIndex = 3;
            // 
            // PlayerName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(250, 150);
            this.Controls.Add(this.PanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlayerName";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Player Name";
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelPlayerName;
        private System.Windows.Forms.TextBox TextboxName;
        private System.Windows.Forms.Button ButtonChoose;
        private System.Windows.Forms.Panel PanelMain;
    }
}