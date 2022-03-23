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
            this.surveyTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.empConSurveyPanel = new System.Windows.Forms.Panel();
            this.empConSurveyTenLabel = new System.Windows.Forms.Label();
            this.empConSurveyZeroLabel = new System.Windows.Forms.Label();
            this.empConSurveyTrackBar = new System.Windows.Forms.TrackBar();
            this.ftPtSurveyLabel = new System.Windows.Forms.Label();
            this.ftPtSurveyPanel = new System.Windows.Forms.Panel();
            this.ftPtSurveyTenLabel = new System.Windows.Forms.Label();
            this.ftPtSurveyZeroLabel = new System.Windows.Forms.Label();
            this.ftPtSurveyTrackBar = new System.Windows.Forms.TrackBar();
            this.empConSurveyLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.submitSurveyButton = new System.Windows.Forms.Button();
            this.valuesPanel.SuspendLayout();
            this.surveyTableLayoutPanel.SuspendLayout();
            this.empConSurveyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empConSurveyTrackBar)).BeginInit();
            this.ftPtSurveyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ftPtSurveyTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // valuesPanel
            // 
            this.valuesPanel.Controls.Add(this.submitSurveyButton);
            this.valuesPanel.Controls.Add(this.surveyTableLayoutPanel);
            this.valuesPanel.Controls.Add(this.welcomeLabel);
            this.valuesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valuesPanel.Location = new System.Drawing.Point(0, 0);
            this.valuesPanel.Name = "valuesPanel";
            this.valuesPanel.Size = new System.Drawing.Size(800, 450);
            this.valuesPanel.TabIndex = 0;
            // 
            // surveyTableLayoutPanel
            // 
            this.surveyTableLayoutPanel.ColumnCount = 2;
            this.surveyTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.125F));
            this.surveyTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.875F));
            this.surveyTableLayoutPanel.Controls.Add(this.empConSurveyPanel, 1, 1);
            this.surveyTableLayoutPanel.Controls.Add(this.ftPtSurveyLabel, 0, 0);
            this.surveyTableLayoutPanel.Controls.Add(this.ftPtSurveyPanel, 1, 0);
            this.surveyTableLayoutPanel.Controls.Add(this.empConSurveyLabel, 0, 1);
            this.surveyTableLayoutPanel.Location = new System.Drawing.Point(0, 16);
            this.surveyTableLayoutPanel.Name = "surveyTableLayoutPanel";
            this.surveyTableLayoutPanel.RowCount = 2;
            this.surveyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.59447F));
            this.surveyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.40553F));
            this.surveyTableLayoutPanel.Size = new System.Drawing.Size(800, 405);
            this.surveyTableLayoutPanel.TabIndex = 2;
            // 
            // empConSurveyPanel
            // 
            this.empConSurveyPanel.Controls.Add(this.empConSurveyTenLabel);
            this.empConSurveyPanel.Controls.Add(this.empConSurveyZeroLabel);
            this.empConSurveyPanel.Controls.Add(this.empConSurveyTrackBar);
            this.empConSurveyPanel.Location = new System.Drawing.Point(364, 58);
            this.empConSurveyPanel.Name = "empConSurveyPanel";
            this.empConSurveyPanel.Size = new System.Drawing.Size(419, 53);
            this.empConSurveyPanel.TabIndex = 5;
            // 
            // empConSurveyTenLabel
            // 
            this.empConSurveyTenLabel.AutoSize = true;
            this.empConSurveyTenLabel.Location = new System.Drawing.Point(391, 4);
            this.empConSurveyTenLabel.Name = "empConSurveyTenLabel";
            this.empConSurveyTenLabel.Size = new System.Drawing.Size(19, 13);
            this.empConSurveyTenLabel.TabIndex = 3;
            this.empConSurveyTenLabel.Text = "10";
            // 
            // empConSurveyZeroLabel
            // 
            this.empConSurveyZeroLabel.AutoSize = true;
            this.empConSurveyZeroLabel.Location = new System.Drawing.Point(0, 4);
            this.empConSurveyZeroLabel.Name = "empConSurveyZeroLabel";
            this.empConSurveyZeroLabel.Size = new System.Drawing.Size(13, 13);
            this.empConSurveyZeroLabel.TabIndex = 2;
            this.empConSurveyZeroLabel.Text = "0";
            // 
            // empConSurveyTrackBar
            // 
            this.empConSurveyTrackBar.Location = new System.Drawing.Point(19, 0);
            this.empConSurveyTrackBar.Name = "empConSurveyTrackBar";
            this.empConSurveyTrackBar.Size = new System.Drawing.Size(369, 45);
            this.empConSurveyTrackBar.TabIndex = 1;
            this.empConSurveyTrackBar.Value = 5;
            // 
            // ftPtSurveyLabel
            // 
            this.ftPtSurveyLabel.AutoSize = true;
            this.ftPtSurveyLabel.Location = new System.Drawing.Point(3, 0);
            this.ftPtSurveyLabel.Name = "ftPtSurveyLabel";
            this.ftPtSurveyLabel.Size = new System.Drawing.Size(335, 13);
            this.ftPtSurveyLabel.TabIndex = 2;
            this.ftPtSurveyLabel.Text = "How important is your chosen position type (full time/part time) to you?";
            // 
            // ftPtSurveyPanel
            // 
            this.ftPtSurveyPanel.Controls.Add(this.ftPtSurveyTenLabel);
            this.ftPtSurveyPanel.Controls.Add(this.ftPtSurveyZeroLabel);
            this.ftPtSurveyPanel.Controls.Add(this.ftPtSurveyTrackBar);
            this.ftPtSurveyPanel.Location = new System.Drawing.Point(364, 3);
            this.ftPtSurveyPanel.Name = "ftPtSurveyPanel";
            this.ftPtSurveyPanel.Size = new System.Drawing.Size(419, 49);
            this.ftPtSurveyPanel.TabIndex = 3;
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
            // ftPtSurveyZeroLabel
            // 
            this.ftPtSurveyZeroLabel.AutoSize = true;
            this.ftPtSurveyZeroLabel.Location = new System.Drawing.Point(0, 4);
            this.ftPtSurveyZeroLabel.Name = "ftPtSurveyZeroLabel";
            this.ftPtSurveyZeroLabel.Size = new System.Drawing.Size(13, 13);
            this.ftPtSurveyZeroLabel.TabIndex = 2;
            this.ftPtSurveyZeroLabel.Text = "0";
            // 
            // ftPtSurveyTrackBar
            // 
            this.ftPtSurveyTrackBar.Location = new System.Drawing.Point(19, 0);
            this.ftPtSurveyTrackBar.Name = "ftPtSurveyTrackBar";
            this.ftPtSurveyTrackBar.Size = new System.Drawing.Size(369, 45);
            this.ftPtSurveyTrackBar.TabIndex = 1;
            this.ftPtSurveyTrackBar.Value = 5;
            this.ftPtSurveyTrackBar.Scroll += new System.EventHandler(this.ftPtSurveyTrackBar_Scroll);
            // 
            // empConSurveyLabel
            // 
            this.empConSurveyLabel.AutoSize = true;
            this.empConSurveyLabel.Location = new System.Drawing.Point(3, 55);
            this.empConSurveyLabel.Name = "empConSurveyLabel";
            this.empConSurveyLabel.Size = new System.Drawing.Size(353, 13);
            this.empConSurveyLabel.TabIndex = 4;
            this.empConSurveyLabel.Text = "How important is your chosen position type (employee/contractor) to you?";
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
            // submitSurveyButton
            // 
            this.submitSurveyButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.submitSurveyButton.Location = new System.Drawing.Point(0, 427);
            this.submitSurveyButton.Name = "submitSurveyButton";
            this.submitSurveyButton.Size = new System.Drawing.Size(800, 23);
            this.submitSurveyButton.TabIndex = 3;
            this.submitSurveyButton.Text = "Submit";
            this.submitSurveyButton.UseVisualStyleBackColor = true;
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
            this.surveyTableLayoutPanel.ResumeLayout(false);
            this.surveyTableLayoutPanel.PerformLayout();
            this.empConSurveyPanel.ResumeLayout(false);
            this.empConSurveyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empConSurveyTrackBar)).EndInit();
            this.ftPtSurveyPanel.ResumeLayout(false);
            this.ftPtSurveyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ftPtSurveyTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel valuesPanel;
        private System.Windows.Forms.TrackBar ftPtSurveyTrackBar;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.TableLayoutPanel surveyTableLayoutPanel;
        private System.Windows.Forms.Label ftPtSurveyLabel;
        private System.Windows.Forms.Panel ftPtSurveyPanel;
        private System.Windows.Forms.Label ftPtSurveyZeroLabel;
        private System.Windows.Forms.Label ftPtSurveyTenLabel;
        private System.Windows.Forms.Panel empConSurveyPanel;
        private System.Windows.Forms.Label empConSurveyTenLabel;
        private System.Windows.Forms.Label empConSurveyZeroLabel;
        private System.Windows.Forms.TrackBar empConSurveyTrackBar;
        private System.Windows.Forms.Label empConSurveyLabel;
        private System.Windows.Forms.Button submitSurveyButton;
    }
}