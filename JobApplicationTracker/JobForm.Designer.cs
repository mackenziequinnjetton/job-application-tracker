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
            this.redoCareerValuesButton = new System.Windows.Forms.Button();
            this.filterTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ftPtFilterLabel = new System.Windows.Forms.Label();
            this.ftPtFilterComboBox = new System.Windows.Forms.ComboBox();
            this.empConFilterLabel = new System.Windows.Forms.Label();
            this.empConFilterComboBox = new System.Windows.Forms.ComboBox();
            this.jobTabPage = new System.Windows.Forms.TabPage();
            this.jobDataGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ftPtColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.empConColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.appliedColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.recommendedTabPage = new System.Windows.Forms.TabPage();
            this.recommendedDataGridView = new System.Windows.Forms.DataGridView();
            this.recPositionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recEmployerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionTabPage = new System.Windows.Forms.TabPage();
            this.actionDataGridView = new System.Windows.Forms.DataGridView();
            this.completedColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.actionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.filterTabPage.SuspendLayout();
            this.filterTableLayoutPanel.SuspendLayout();
            this.jobTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobDataGridView)).BeginInit();
            this.recommendedTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recommendedDataGridView)).BeginInit();
            this.actionTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actionDataGridView)).BeginInit();
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
            // filterTabPage
            // 
            this.filterTabPage.Controls.Add(this.redoCareerValuesButton);
            this.filterTabPage.Controls.Add(this.filterTableLayoutPanel);
            this.filterTabPage.Location = new System.Drawing.Point(4, 22);
            this.filterTabPage.Name = "filterTabPage";
            this.filterTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.filterTabPage.Size = new System.Drawing.Size(792, 424);
            this.filterTabPage.TabIndex = 3;
            this.filterTabPage.Text = "Filters";
            this.filterTabPage.UseVisualStyleBackColor = true;
            // 
            // redoCareerValuesButton
            // 
            this.redoCareerValuesButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.redoCareerValuesButton.Location = new System.Drawing.Point(3, 398);
            this.redoCareerValuesButton.Name = "redoCareerValuesButton";
            this.redoCareerValuesButton.Size = new System.Drawing.Size(786, 23);
            this.redoCareerValuesButton.TabIndex = 1;
            this.redoCareerValuesButton.Text = "Reselect Career Values";
            this.redoCareerValuesButton.UseVisualStyleBackColor = true;
            this.redoCareerValuesButton.Click += new System.EventHandler(this.redoCareerValuesButton_Click);
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
            this.ftPtFilterComboBox.SelectedIndexChanged += new System.EventHandler(this.ftPtFilterComboBox_SelectedIndexChanged);
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
            this.empConFilterComboBox.SelectedIndexChanged += new System.EventHandler(this.empConFilterComboBox_SelectedIndexChanged);
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
            this.idColumn,
            this.positionColumn,
            this.employerColumn,
            this.ftPtColumn,
            this.empConColumn,
            this.appliedColumn});
            this.jobDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobDataGridView.Location = new System.Drawing.Point(3, 3);
            this.jobDataGridView.Name = "jobDataGridView";
            this.jobDataGridView.RowHeadersWidth = 51;
            this.jobDataGridView.Size = new System.Drawing.Size(786, 418);
            this.jobDataGridView.TabIndex = 0;
            this.jobDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.jobDataGridView_CellValueChanged);
            this.jobDataGridView.Leave += new System.EventHandler(this.jobDataGridView_Leave);
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "IdNumber";
            this.idColumn.HeaderText = "Job ID#";
            this.idColumn.Name = "idColumn";
            // 
            // positionColumn
            // 
            this.positionColumn.DataPropertyName = "PositionTitle";
            this.positionColumn.HeaderText = "Position Title";
            this.positionColumn.MinimumWidth = 6;
            this.positionColumn.Name = "positionColumn";
            // 
            // employerColumn
            // 
            this.employerColumn.DataPropertyName = "Employer";
            this.employerColumn.HeaderText = "Employer";
            this.employerColumn.MinimumWidth = 6;
            this.employerColumn.Name = "employerColumn";
            // 
            // ftPtColumn
            // 
            this.ftPtColumn.DataPropertyName = "FtPt";
            this.ftPtColumn.HeaderText = "Full Time/Part Time";
            this.ftPtColumn.Items.AddRange(new object[] {
            "Full Time",
            "Part Time"});
            this.ftPtColumn.MinimumWidth = 6;
            this.ftPtColumn.Name = "ftPtColumn";
            // 
            // empConColumn
            // 
            this.empConColumn.DataPropertyName = "EmpCon";
            this.empConColumn.HeaderText = "Employee/Contractor";
            this.empConColumn.Items.AddRange(new object[] {
            "Employee",
            "Contractor"});
            this.empConColumn.MinimumWidth = 6;
            this.empConColumn.Name = "empConColumn";
            this.empConColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.empConColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // appliedColumn
            // 
            this.appliedColumn.DataPropertyName = "Applied";
            this.appliedColumn.HeaderText = "Applied";
            this.appliedColumn.Name = "appliedColumn";
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
            this.recPositionColumn,
            this.recEmployerColumn});
            this.recommendedDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recommendedDataGridView.Location = new System.Drawing.Point(3, 3);
            this.recommendedDataGridView.Name = "recommendedDataGridView";
            this.recommendedDataGridView.ReadOnly = true;
            this.recommendedDataGridView.RowHeadersWidth = 51;
            this.recommendedDataGridView.Size = new System.Drawing.Size(786, 418);
            this.recommendedDataGridView.TabIndex = 1;
            // 
            // recPositionColumn
            // 
            this.recPositionColumn.HeaderText = "Position Title";
            this.recPositionColumn.MinimumWidth = 6;
            this.recPositionColumn.Name = "recPositionColumn";
            this.recPositionColumn.ReadOnly = true;
            // 
            // recEmployerColumn
            // 
            this.recEmployerColumn.HeaderText = "Employer";
            this.recEmployerColumn.MinimumWidth = 6;
            this.recEmployerColumn.Name = "recEmployerColumn";
            this.recEmployerColumn.ReadOnly = true;
            // 
            // actionTabPage
            // 
            this.actionTabPage.Controls.Add(this.actionDataGridView);
            this.actionTabPage.Location = new System.Drawing.Point(4, 22);
            this.actionTabPage.Name = "actionTabPage";
            this.actionTabPage.Size = new System.Drawing.Size(792, 424);
            this.actionTabPage.TabIndex = 2;
            this.actionTabPage.Text = "Action Items";
            this.actionTabPage.UseVisualStyleBackColor = true;
            // 
            // actionDataGridView
            // 
            this.actionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.actionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.actionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.completedColumn,
            this.actionColumn});
            this.actionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionDataGridView.Location = new System.Drawing.Point(0, 0);
            this.actionDataGridView.Name = "actionDataGridView";
            this.actionDataGridView.ReadOnly = true;
            this.actionDataGridView.Size = new System.Drawing.Size(792, 424);
            this.actionDataGridView.TabIndex = 0;
            // 
            // completedColumn
            // 
            this.completedColumn.FillWeight = 5.076143F;
            this.completedColumn.HeaderText = "";
            this.completedColumn.Name = "completedColumn";
            this.completedColumn.ReadOnly = true;
            // 
            // actionColumn
            // 
            this.actionColumn.FillWeight = 194.9239F;
            this.actionColumn.HeaderText = "Action Items";
            this.actionColumn.MinimumWidth = 730;
            this.actionColumn.Name = "actionColumn";
            this.actionColumn.ReadOnly = true;
            this.actionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.actionColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            ((System.ComponentModel.ISupportInitialize)(this.actionDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage jobTabPage;
        private System.Windows.Forms.TabPage recommendedTabPage;
        private System.Windows.Forms.TabPage actionTabPage;
        private System.Windows.Forms.TabPage filterTabPage;
        private System.Windows.Forms.DataGridView jobDataGridView;
        private System.Windows.Forms.TableLayoutPanel filterTableLayoutPanel;
        private System.Windows.Forms.Label ftPtFilterLabel;
        private System.Windows.Forms.Button redoCareerValuesButton;
        private System.Windows.Forms.ComboBox ftPtFilterComboBox;
        private System.Windows.Forms.Label empConFilterLabel;
        private System.Windows.Forms.ComboBox empConFilterComboBox;
        private System.Windows.Forms.DataGridView recommendedDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn recPositionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recEmployerColumn;
        private System.Windows.Forms.DataGridView actionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employerColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ftPtColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn empConColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn appliedColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn completedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionColumn;
    }
}

