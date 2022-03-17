namespace JobApplicationTracker
{
    partial class ValuesForm
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
            this.valuesPanel = new System.Windows.Forms.Panel();
            this.ftPtSurveyTrackBar = new System.Windows.Forms.TrackBar();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ftPtSurveyLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ftPtSurveyZeroLabel = new System.Windows.Forms.Label();
            this.ftPtSurveyTenLabel = new System.Windows.Forms.Label();
            this.valuesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ftPtSurveyTrackBar)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // valuesPanel
            // 
            this.valuesPanel.Controls.Add(this.tableLayoutPanel1);
            this.valuesPanel.Controls.Add(this.welcomeLabel);
            this.valuesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valuesPanel.Location = new System.Drawing.Point(0, 0);
            this.valuesPanel.Name = "valuesPanel";
            this.valuesPanel.Size = new System.Drawing.Size(800, 450);
            this.valuesPanel.TabIndex = 0;
            // 
            // ftPtSurveyTrackBar
            // 
            this.ftPtSurveyTrackBar.Location = new System.Drawing.Point(19, 0);
            this.ftPtSurveyTrackBar.Name = "ftPtSurveyTrackBar";
            this.ftPtSurveyTrackBar.Size = new System.Drawing.Size(369, 45);
            this.ftPtSurveyTrackBar.TabIndex = 1;
            this.ftPtSurveyTrackBar.Value = 5;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.welcomeLabel.Location = new System.Drawing.Point(0, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(641, 13);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome! So we can give you appropriate job recommendations, please fill out this" +
    " form indicating your career preferences and values.";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.375F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.625F));
            this.tableLayoutPanel1.Controls.Add(this.ftPtSurveyLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.59447F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.40553F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 434);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // ftPtSurveyLabel
            // 
            this.ftPtSurveyLabel.AutoSize = true;
            this.ftPtSurveyLabel.Location = new System.Drawing.Point(3, 0);
            this.ftPtSurveyLabel.Name = "ftPtSurveyLabel";
            this.ftPtSurveyLabel.Size = new System.Drawing.Size(274, 13);
            this.ftPtSurveyLabel.TabIndex = 2;
            this.ftPtSurveyLabel.Text = "How important is position type (full time/part time) to you?";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ftPtSurveyTenLabel);
            this.panel1.Controls.Add(this.ftPtSurveyZeroLabel);
            this.panel1.Controls.Add(this.ftPtSurveyTrackBar);
            this.panel1.Location = new System.Drawing.Point(310, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 53);
            this.panel1.TabIndex = 3;
            // 
            // ftPtSurveyZeroLabel
            // 
            this.ftPtSurveyZeroLabel.AutoSize = true;
            this.ftPtSurveyZeroLabel.Location = new System.Drawing.Point(0, 4);
            this.ftPtSurveyZeroLabel.Name = "ftPtSurveyZeroLabel";
            this.ftPtSurveyZeroLabel.Size = new System.Drawing.Size(13, 13);
            this.ftPtSurveyZeroLabel.TabIndex = 2;
            this.ftPtSurveyZeroLabel.Text = "0";
            // 
            // ftPtSurveyTenLabel
            // 
            this.ftPtSurveyTenLabel.AutoSize = true;
            this.ftPtSurveyTenLabel.Location = new System.Drawing.Point(391, 4);
            this.ftPtSurveyTenLabel.Name = "ftPtSurveyTenLabel";
            this.ftPtSurveyTenLabel.Size = new System.Drawing.Size(19, 13);
            this.ftPtSurveyTenLabel.TabIndex = 3;
            this.ftPtSurveyTenLabel.Text = "10";
            // 
            // ValuesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.valuesPanel);
            this.Name = "ValuesForm";
            this.Text = "Career Values";
            this.valuesPanel.ResumeLayout(false);
            this.valuesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ftPtSurveyTrackBar)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel valuesPanel;
        private System.Windows.Forms.TrackBar ftPtSurveyTrackBar;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ftPtSurveyLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ftPtSurveyZeroLabel;
        private System.Windows.Forms.Label ftPtSurveyTenLabel;
    }
}