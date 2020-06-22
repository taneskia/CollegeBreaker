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
            this.LabelSemester = new System.Windows.Forms.Label();
            this.LabelMeanGrade = new System.Windows.Forms.Label();
            this.PanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.LightBlue;
            this.PanelMain.CausesValidation = false;
            this.PanelMain.Controls.Add(this.LabelSemester);
            this.PanelMain.Controls.Add(this.LabelMeanGrade);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(2, 2);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(620, 51);
            this.PanelMain.TabIndex = 0;
            // 
            // LabelSemester
            // 
            this.LabelSemester.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelSemester.AutoSize = true;
            this.LabelSemester.CausesValidation = false;
            this.LabelSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSemester.Location = new System.Drawing.Point(474, 13);
            this.LabelSemester.Margin = new System.Windows.Forms.Padding(10);
            this.LabelSemester.Name = "LabelSemester";
            this.LabelSemester.Size = new System.Drawing.Size(130, 26);
            this.LabelSemester.TabIndex = 2;
            this.LabelSemester.Text = "Semester: 0";
            // 
            // LabelMeanGrade
            // 
            this.LabelMeanGrade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelMeanGrade.AutoSize = true;
            this.LabelMeanGrade.CausesValidation = false;
            this.LabelMeanGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMeanGrade.Location = new System.Drawing.Point(19, 13);
            this.LabelMeanGrade.Margin = new System.Windows.Forms.Padding(10);
            this.LabelMeanGrade.Name = "LabelMeanGrade";
            this.LabelMeanGrade.Size = new System.Drawing.Size(156, 26);
            this.LabelMeanGrade.TabIndex = 0;
            this.LabelMeanGrade.Text = "Mean Grade: 0";
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
        private System.Windows.Forms.Label LabelMeanGrade;
        private System.Windows.Forms.Label LabelSemester;
    }
}