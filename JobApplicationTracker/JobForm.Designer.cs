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
            this.filterTabPage = new System.Windows.Forms.TabPage();
            this.filterApplyButton = new System.Windows.Forms.Button();
            this.filterTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ftPtFilterLabel = new System.Windows.Forms.Label();
            this.ftPtFilterComboBox = new System.Windows.Forms.ComboBox();
            this.empConFilterLabel = new System.Windows.Forms.Label();
            this.empConFilterComboBox = new System.Windows.Forms.ComboBox();
            this.jobTabPage = new System.Windows.Forms.TabPage();
            this.jobDataGridView = new System.Windows.Forms.DataGridView();
            this.recommendedTabPage = new System.Windows.Forms.TabPage();
            this.recommendedDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionTabPage = new System.Windows.Forms.TabPage();
            this.actionCheckBox5 = new System.Windows.Forms.CheckBox();
            this.actionCheckBox4 = new System.Windows.Forms.CheckBox();
            this.actionCheckBox3 = new System.Windows.Forms.CheckBox();
            this.actionCheckBox2 = new System.Windows.Forms.CheckBox();
            this.actionCheckBox1 = new System.Windows.Forms.CheckBox();
            this.actionListView = new System.Windows.Forms.ListView();
            this.positionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ftPtColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.empConColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabControl.SuspendLayout();
            this.filterTabPage.SuspendLayout();
            this.filterTableLayoutPanel.SuspendLayout();
            this.jobTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobDataGridView)).BeginInit();
            this.recommendedTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recommendedDataGridView)).BeginInit();
            this.actionTabPage.SuspendLayout();
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
            // 
            // filterTabPage
            // 
            this.filterTabPage.Controls.Add(this.filterApplyButton);
            this.filterTabPage.Controls.Add(this.filterTableLayoutPanel);
            this.filterTabPage.Location = new System.Drawing.Point(4, 22);
            this.filterTabPage.Name = "filterTabPage";
            this.filterTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.filterTabPage.Size = new System.Drawing.Size(792, 424);
            this.filterTabPage.TabIndex = 3;
            this.filterTabPage.Text = "Filters";
            this.filterTabPage.UseVisualStyleBackColor = true;
            // 
            // filterApplyButton
            // 
            this.filterApplyButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.filterApplyButton.Location = new System.Drawing.Point(3, 398);
            this.filterApplyButton.Name = "filterApplyButton";
            this.filterApplyButton.Size = new System.Drawing.Size(786, 23);
            this.filterApplyButton.TabIndex = 1;
            this.filterApplyButton.Text = "Apply";
            this.filterApplyButton.UseVisualStyleBackColor = true;
            // 
            // filterTableLayoutPanel
            // 
            this.filterTableLayoutPanel.AutoSize = true;
            this.filterTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.filterTableLayoutPanel.ColumnCount = 2;
            this.filterTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.filterTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.filterTableLayoutPanel.Controls.Add(this.ftPtFilterLabel, 0, 0);
            this.filterTableLayoutPanel.Controls.Add(this.ftPtFilterComboBox, 1, 0);
            this.filterTableLayoutPanel.Controls.Add(this.empConFilterLabel, 0, 1);
            this.filterTableLayoutPanel.Controls.Add(this.empConFilterComboBox, 1, 1);
            this.filterTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.filterTableLayoutPanel.Name = "filterTableLayoutPanel";
            this.filterTableLayoutPanel.RowCount = 2;
            this.filterTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.510638F));
            this.filterTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.48936F));
            this.filterTableLayoutPanel.Size = new System.Drawing.Size(786, 418);
            this.filterTableLayoutPanel.TabIndex = 0;
            // 
            // ftPtFilterLabel
            // 
            this.ftPtFilterLabel.AutoSize = true;
            this.ftPtFilterLabel.Location = new System.Drawing.Point(3, 0);
            this.ftPtFilterLabel.Name = "ftPtFilterLabel";
            this.ftPtFilterLabel.Size = new System.Drawing.Size(99, 13);
            this.ftPtFilterLabel.TabIndex = 0;
            this.ftPtFilterLabel.Text = "Full Time/Part Time";
            // 
            // ftPtFilterComboBox
            // 
            this.ftPtFilterComboBox.FormattingEnabled = true;
            this.ftPtFilterComboBox.Items.AddRange(new object[] {
            "Full Time",
            "Part Time"});
            this.ftPtFilterComboBox.Location = new System.Drawing.Point(116, 3);
            this.ftPtFilterComboBox.Name = "ftPtFilterComboBox";
            this.ftPtFilterComboBox.Size = new System.Drawing.Size(121, 21);
            this.ftPtFilterComboBox.TabIndex = 1;
            // 
            // empConFilterLabel
            // 
            this.empConFilterLabel.AutoSize = true;
            this.empConFilterLabel.Location = new System.Drawing.Point(3, 35);
            this.empConFilterLabel.Name = "empConFilterLabel";
            this.empConFilterLabel.Size = new System.Drawing.Size(107, 13);
            this.empConFilterLabel.TabIndex = 2;
            this.empConFilterLabel.Text = "Employee/Contractor";
            // 
            // empConFilterComboBox
            // 
            this.empConFilterComboBox.FormattingEnabled = true;
            this.empConFilterComboBox.Items.AddRange(new object[] {
            "Employee",
            "Contractor"});
            this.empConFilterComboBox.Location = new System.Drawing.Point(116, 38);
            this.empConFilterComboBox.Name = "empConFilterComboBox";
            this.empConFilterComboBox.Size = new System.Drawing.Size(121, 21);
            this.empConFilterComboBox.TabIndex = 3;
            // 
            // jobTabPage
            // 
            this.jobTabPage.Controls.Add(this.jobDataGridView);
            this.jobTabPage.Location = new System.Drawing.Point(4, 22);
            this.jobTabPage.Name = "jobTabPage";
            this.jobTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.jobTabPage.Size = new System.Drawing.Size(792, 424);
            this.jobTabPage.TabIndex = 0;
            this.jobTabPage.Text = "Job List";
            this.jobTabPage.UseVisualStyleBackColor = true;
            // 
            // jobDataGridView
            // 
            this.jobDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.jobDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jobDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.positionColumn,
            this.employerColumn,
            this.ftPtColumn,
            this.empConColumn});
            this.jobDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobDataGridView.Location = new System.Drawing.Point(3, 3);
            this.jobDataGridView.Name = "jobDataGridView";
            this.jobDataGridView.RowHeadersWidth = 51;
            this.jobDataGridView.Size = new System.Drawing.Size(786, 418);
            this.jobDataGridView.TabIndex = 0;
            // 
            // recommendedTabPage
            // 
            this.recommendedTabPage.Controls.Add(this.recommendedDataGridView);
            this.recommendedTabPage.Location = new System.Drawing.Point(4, 22);
            this.recommendedTabPage.Name = "recommendedTabPage";
            this.recommendedTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.recommendedTabPage.Size = new System.Drawing.Size(792, 424);
            this.recommendedTabPage.TabIndex = 1;
            this.recommendedTabPage.Text = "Recommended Jobs";
            this.recommendedTabPage.UseVisualStyleBackColor = true;
            // 
            // recommendedDataGridView
            // 
            this.recommendedDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.recommendedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recommendedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.recommendedDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recommendedDataGridView.Location = new System.Drawing.Point(3, 3);
            this.recommendedDataGridView.Name = "recommendedDataGridView";
            this.recommendedDataGridView.RowHeadersWidth = 51;
            this.recommendedDataGridView.Size = new System.Drawing.Size(786, 418);
            this.recommendedDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Position Title";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Employer";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // actionTabPage
            // 
            this.actionTabPage.Controls.Add(this.actionCheckBox5);
            this.actionTabPage.Controls.Add(this.actionCheckBox4);
            this.actionTabPage.Controls.Add(this.actionCheckBox3);
            this.actionTabPage.Controls.Add(this.actionCheckBox2);
            this.actionTabPage.Controls.Add(this.actionCheckBox1);
            this.actionTabPage.Controls.Add(this.actionListView);
            this.actionTabPage.Location = new System.Drawing.Point(4, 22);
            this.actionTabPage.Name = "actionTabPage";
            this.actionTabPage.Size = new System.Drawing.Size(792, 424);
            this.actionTabPage.TabIndex = 2;
            this.actionTabPage.Text = "Action Items";
            this.actionTabPage.UseVisualStyleBackColor = true;
            // 
            // actionCheckBox5
            // 
            this.actionCheckBox5.AutoSize = true;
            this.actionCheckBox5.Location = new System.Drawing.Point(3, 99);
            this.actionCheckBox5.Name = "actionCheckBox5";
            this.actionCheckBox5.Size = new System.Drawing.Size(88, 17);
            this.actionCheckBox5.TabIndex = 6;
            this.actionCheckBox5.Text = "Action Item 5";
            this.actionCheckBox5.UseVisualStyleBackColor = true;
            // 
            // actionCheckBox4
            // 
            this.actionCheckBox4.AutoSize = true;
            this.actionCheckBox4.Location = new System.Drawing.Point(3, 75);
            this.actionCheckBox4.Name = "actionCheckBox4";
            this.actionCheckBox4.Size = new System.Drawing.Size(88, 17);
            this.actionCheckBox4.TabIndex = 5;
            this.actionCheckBox4.Text = "Action Item 4";
            this.actionCheckBox4.UseVisualStyleBackColor = true;
            // 
            // actionCheckBox3
            // 
            this.actionCheckBox3.AutoSize = true;
            this.actionCheckBox3.Location = new System.Drawing.Point(3, 51);
            this.actionCheckBox3.Name = "actionCheckBox3";
            this.actionCheckBox3.Size = new System.Drawing.Size(88, 17);
            this.actionCheckBox3.TabIndex = 4;
            this.actionCheckBox3.Text = "Action Item 3";
            this.actionCheckBox3.UseVisualStyleBackColor = true;
            // 
            // actionCheckBox2
            // 
            this.actionCheckBox2.AutoSize = true;
            this.actionCheckBox2.Location = new System.Drawing.Point(3, 27);
            this.actionCheckBox2.Name = "actionCheckBox2";
            this.actionCheckBox2.Size = new System.Drawing.Size(88, 17);
            this.actionCheckBox2.TabIndex = 3;
            this.actionCheckBox2.Text = "Action Item 2";
            this.actionCheckBox2.UseVisualStyleBackColor = true;
            // 
            // actionCheckBox1
            // 
            this.actionCheckBox1.AutoSize = true;
            this.actionCheckBox1.Location = new System.Drawing.Point(3, 3);
            this.actionCheckBox1.Name = "actionCheckBox1";
            this.actionCheckBox1.Size = new System.Drawing.Size(88, 17);
            this.actionCheckBox1.TabIndex = 2;
            this.actionCheckBox1.Text = "Action Item 1";
            this.actionCheckBox1.UseVisualStyleBackColor = true;
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
            // positionColumn
            // 
            this.positionColumn.HeaderText = "Position Title";
            this.positionColumn.MinimumWidth = 6;
            this.positionColumn.Name = "positionColumn";
            // 
            // employerColumn
            // 
            this.employerColumn.HeaderText = "Employer";
            this.employerColumn.MinimumWidth = 6;
            this.employerColumn.Name = "employerColumn";
            // 
            // ftPtColumn
            // 
            this.ftPtColumn.HeaderText = "Full Time/Part Time";
            this.ftPtColumn.Items.AddRange(new object[] {
            "Full Time",
            "Part Time"});
            this.ftPtColumn.MinimumWidth = 6;
            this.ftPtColumn.Name = "ftPtColumn";
            // 
            // empConColumn
            // 
            this.empConColumn.HeaderText = "Employee/Contractor";
            this.empConColumn.Items.AddRange(new object[] {
            "Employee",
            "Contractor"});
            this.empConColumn.Name = "empConColumn";
            this.empConColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.empConColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // JobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "JobForm";
            this.Text = "Job Application Tracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JobForm_FormClosing);
            this.Load += new System.EventHandler(this.JobForm_Load);
            this.tabControl.ResumeLayout(false);
            this.filterTabPage.ResumeLayout(false);
            this.filterTabPage.PerformLayout();
            this.filterTableLayoutPanel.ResumeLayout(false);
            this.filterTableLayoutPanel.PerformLayout();
            this.jobTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.jobDataGridView)).EndInit();
            this.recommendedTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recommendedDataGridView)).EndInit();
            this.actionTabPage.ResumeLayout(false);
            this.actionTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage jobTabPage;
        private System.Windows.Forms.TabPage recommendedTabPage;
        private System.Windows.Forms.TabPage actionTabPage;
        private System.Windows.Forms.ListView actionListView;
        private System.Windows.Forms.TabPage filterTabPage;
        private System.Windows.Forms.CheckBox actionCheckBox1;
        private System.Windows.Forms.DataGridView jobDataGridView;
        private System.Windows.Forms.TableLayoutPanel filterTableLayoutPanel;
        private System.Windows.Forms.Label ftPtFilterLabel;
        private System.Windows.Forms.Button filterApplyButton;
        private System.Windows.Forms.ComboBox ftPtFilterComboBox;
        private System.Windows.Forms.Label empConFilterLabel;
        private System.Windows.Forms.ComboBox empConFilterComboBox;
        private System.Windows.Forms.CheckBox actionCheckBox3;
        private System.Windows.Forms.CheckBox actionCheckBox2;
        private System.Windows.Forms.CheckBox actionCheckBox5;
        private System.Windows.Forms.CheckBox actionCheckBox4;
        private System.Windows.Forms.DataGridView recommendedDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employerColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ftPtColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn empConColumn;
    }
}

