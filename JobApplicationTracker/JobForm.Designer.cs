namespace JobApplicationTracker
{
    partial class JobForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.jobTabPage = new System.Windows.Forms.TabPage();
            this.recommendedTabPage = new System.Windows.Forms.TabPage();
            this.actionTabPage = new System.Windows.Forms.TabPage();
            this.actionListView = new System.Windows.Forms.ListView();
            this.filterTabPage = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.jobDataGridView = new System.Windows.Forms.DataGridView();
            this.positionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ftPtColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.filterDataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.jobTabPage.SuspendLayout();
            this.actionTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.filterTabPage);
            this.tabControl.Controls.Add(this.jobTabPage);
            this.tabControl.Controls.Add(this.recommendedTabPage);
            this.tabControl.Controls.Add(this.actionTabPage);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 450);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // jobTabPage
            // 
            this.jobTabPage.Controls.Add(this.filterDataGridView);
            this.jobTabPage.Controls.Add(this.jobDataGridView);
            this.jobTabPage.Location = new System.Drawing.Point(4, 22);
            this.jobTabPage.Name = "jobTabPage";
            this.jobTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.jobTabPage.Size = new System.Drawing.Size(792, 424);
            this.jobTabPage.TabIndex = 0;
            this.jobTabPage.Text = "Job List";
            this.jobTabPage.UseVisualStyleBackColor = true;
            // 
            // recommendedTabPage
            // 
            this.recommendedTabPage.Location = new System.Drawing.Point(4, 22);
            this.recommendedTabPage.Name = "recommendedTabPage";
            this.recommendedTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.recommendedTabPage.Size = new System.Drawing.Size(792, 424);
            this.recommendedTabPage.TabIndex = 1;
            this.recommendedTabPage.Text = "Recommended Jobs";
            this.recommendedTabPage.UseVisualStyleBackColor = true;
            // 
            // actionTabPage
            // 
            this.actionTabPage.Controls.Add(this.checkBox1);
            this.actionTabPage.Controls.Add(this.actionListView);
            this.actionTabPage.Location = new System.Drawing.Point(4, 22);
            this.actionTabPage.Name = "actionTabPage";
            this.actionTabPage.Size = new System.Drawing.Size(792, 424);
            this.actionTabPage.TabIndex = 2;
            this.actionTabPage.Text = "Action Items";
            this.actionTabPage.UseVisualStyleBackColor = true;
            // 
            // actionListView
            // 
            this.actionListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionListView.HideSelection = false;
            this.actionListView.Location = new System.Drawing.Point(0, 0);
            this.actionListView.Name = "actionListView";
            this.actionListView.Size = new System.Drawing.Size(792, 424);
            this.actionListView.TabIndex = 0;
            this.actionListView.UseCompatibleStateImageBehavior = false;
            // 
            // filterTabPage
            // 
            this.filterTabPage.Location = new System.Drawing.Point(4, 22);
            this.filterTabPage.Name = "filterTabPage";
            this.filterTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.filterTabPage.Size = new System.Drawing.Size(792, 424);
            this.filterTabPage.TabIndex = 3;
            this.filterTabPage.Text = "Filters";
            this.filterTabPage.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // jobDataGridView
            // 
            this.jobDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.jobDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jobDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.positionColumn,
            this.employerColumn,
            this.ftPtColumn});
            this.jobDataGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.jobDataGridView.Location = new System.Drawing.Point(213, 3);
            this.jobDataGridView.Name = "jobDataGridView";
            this.jobDataGridView.Size = new System.Drawing.Size(576, 418);
            this.jobDataGridView.TabIndex = 0;
            // 
            // positionColumn
            // 
            this.positionColumn.HeaderText = "Position Title";
            this.positionColumn.Name = "positionColumn";
            // 
            // employerColumn
            // 
            this.employerColumn.HeaderText = "Employer";
            this.employerColumn.Name = "employerColumn";
            // 
            // ftPtColumn
            // 
            this.ftPtColumn.HeaderText = "Full Time/Part Time";
            this.ftPtColumn.Items.AddRange(new object[] {
            "Full Time",
            "Part Time"});
            this.ftPtColumn.Name = "ftPtColumn";
            // 
            // filterDataGridView
            // 
            this.filterDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.filterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filterDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.filterDataGridView.Location = new System.Drawing.Point(3, 3);
            this.filterDataGridView.Name = "filterDataGridView";
            this.filterDataGridView.Size = new System.Drawing.Size(204, 418);
            this.filterDataGridView.TabIndex = 1;
            // 
            // JobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "JobForm";
            this.Text = "Job Application Tracker";
            this.tabControl.ResumeLayout(false);
            this.jobTabPage.ResumeLayout(false);
            this.actionTabPage.ResumeLayout(false);
            this.actionTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage jobTabPage;
        private System.Windows.Forms.TabPage recommendedTabPage;
        private System.Windows.Forms.TabPage actionTabPage;
        private System.Windows.Forms.ListView actionListView;
        private System.Windows.Forms.TabPage filterTabPage;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView jobDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employerColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ftPtColumn;
        private System.Windows.Forms.DataGridView filterDataGridView;
    }
}

