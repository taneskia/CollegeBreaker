namespace CollegeBreaker
{
    partial class ScoreForm
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
            this.LabelScoreValue = new System.Windows.Forms.Label();
            this.LabelScoreText = new System.Windows.Forms.Label();
            this.LabelTotalScoreValue = new System.Windows.Forms.Label();
            this.LabelTotalScoreText = new System.Windows.Forms.Label();
            this.PanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelMain.BackColor = System.Drawing.Color.LightBlue;
            this.PanelMain.CausesValidation = false;
            this.PanelMain.Controls.Add(this.LabelScoreValue);
            this.PanelMain.Controls.Add(this.LabelScoreText);
            this.PanelMain.Controls.Add(this.LabelTotalScoreValue);
            this.PanelMain.Controls.Add(this.LabelTotalScoreText);
            this.PanelMain.Location = new System.Drawing.Point(2, 2);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(620, 51);
            this.PanelMain.TabIndex = 0;
            // 
            // LabelScoreValue
            // 
            this.LabelScoreValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelScoreValue.AutoSize = true;
            this.LabelScoreValue.CausesValidation = false;
            this.LabelScoreValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScoreValue.Location = new System.Drawing.Point(524, 13);
            this.LabelScoreValue.Margin = new System.Windows.Forms.Padding(10);
            this.LabelScoreValue.Name = "LabelScoreValue";
            this.LabelScoreValue.Size = new System.Drawing.Size(24, 26);
            this.LabelScoreValue.TabIndex = 3;
            this.LabelScoreValue.Text = "0";
            // 
            // LabelScoreText
            // 
            this.LabelScoreText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelScoreText.AutoSize = true;
            this.LabelScoreText.CausesValidation = false;
            this.LabelScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScoreText.Location = new System.Drawing.Point(324, 13);
            this.LabelScoreText.Margin = new System.Windows.Forms.Padding(10);
            this.LabelScoreText.Name = "LabelScoreText";
            this.LabelScoreText.Size = new System.Drawing.Size(133, 26);
            this.LabelScoreText.TabIndex = 2;
            this.LabelScoreText.Text = "Level Score:";
            // 
            // LabelTotalScoreValue
            // 
            this.LabelTotalScoreValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelTotalScoreValue.AutoSize = true;
            this.LabelTotalScoreValue.CausesValidation = false;
            this.LabelTotalScoreValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalScoreValue.Location = new System.Drawing.Point(219, 13);
            this.LabelTotalScoreValue.Margin = new System.Windows.Forms.Padding(10);
            this.LabelTotalScoreValue.Name = "LabelTotalScoreValue";
            this.LabelTotalScoreValue.Size = new System.Drawing.Size(24, 26);
            this.LabelTotalScoreValue.TabIndex = 1;
            this.LabelTotalScoreValue.Text = "0";
            // 
            // LabelTotalScoreText
            // 
            this.LabelTotalScoreText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelTotalScoreText.AutoSize = true;
            this.LabelTotalScoreText.CausesValidation = false;
            this.LabelTotalScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalScoreText.Location = new System.Drawing.Point(19, 13);
            this.LabelTotalScoreText.Margin = new System.Windows.Forms.Padding(10);
            this.LabelTotalScoreText.Name = "LabelTotalScoreText";
            this.LabelTotalScoreText.Size = new System.Drawing.Size(128, 26);
            this.LabelTotalScoreText.TabIndex = 0;
            this.LabelTotalScoreText.Text = "Total Score:";
            // 
            // ScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Black;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(624, 55);
            this.Controls.Add(this.PanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScoreForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "College Breaker Score";
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Label LabelTotalScoreText;
        private System.Windows.Forms.Label LabelTotalScoreValue;
        private System.Windows.Forms.Label LabelScoreValue;
        private System.Windows.Forms.Label LabelScoreText;
    }
}