using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace JobApplicationTracker
{
    public partial class JobForm : Form
    {
        public JobForm()
        {
            InitializeComponent();
        }

        BindingList<Job> jobsBindingList = new BindingList<Job>();
        List<int> valuesList;
        BindingSource jobBindingSource;

        string JobsFileName = Application.StartupPath 
            + @"\JobData.bin";
        string ValuesFileName = Application.StartupPath
            + @"\ValuesData.bin";
        string AppDatesFileName = Application.StartupPath
            + @"\AppDatesData.bin";

        public static int ftPtSurveyTrackBarValue;
        public static int empConSurveyTrackBarValue;
        string ftPtFilterValue;
        string empConFilterValue;

        // Stored as the job's unique ID as the key and the datatime applied
        // as the value
        Dictionary<int, DateTime> jobApplicationDates =
            new Dictionary<int, DateTime>();

        private void GetJobsBindingList()
        {
            FileStream openFileStream = File.OpenRead(JobsFileName);
            BinaryFormatter deserializer = new BinaryFormatter();
            jobsBindingList =
                (BindingList<Job>)deserializer
                .Deserialize(openFileStream);
            openFileStream.Close();
        }
        
        private void GetValuesList()
        {
            FileStream openFileStream = File.OpenRead(ValuesFileName);
            BinaryFormatter deserializer = new BinaryFormatter();
            valuesList = (List<int>)deserializer.Deserialize(openFileStream);
            openFileStream.Close();
        }

        private void GetAppDatesDict()
        {
            FileStream openFileStream = File.OpenRead(AppDatesFileName);
            BinaryFormatter deserializer = new BinaryFormatter();
            jobApplicationDates = (Dictionary<int, DateTime>)deserializer.Deserialize(openFileStream);
            openFileStream.Close();
        }
        
        private void JobForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(JobsFileName))
            {
                GetJobsBindingList();
            }

            jobBindingSource = new BindingSource(jobsBindingList, null);
            jobBindingSource.AllowNew = true;
            jobDataGridView.DataSource = jobBindingSource;

            jobDataGridView.Update();

            if (File.Exists(ValuesFileName))
            {
                GetValuesList();
            }
            else
            {
                var valuesForm = new ValuesForm();
                valuesForm.ShowDialog();

                GetValuesList();
            }

            ftPtSurveyTrackBarValue = valuesList[0];
            empConSurveyTrackBarValue = valuesList[1];

            if (File.Exists(AppDatesFileName))
            {
                GetAppDatesDict();
            }
        }

        private void AddJobIds()
        {
            var jobsWithoutIds =
                from DataGridViewRow row in jobDataGridView.Rows
                where !row.IsNewRow && (row.Cells[0] == null 
                || (int)row.Cells[0].Value == 0)
                select row;

            var jobsWithIds =
                from DataGridViewRow row in jobDataGridView.Rows
                where !row.IsNewRow && row.Cells[0] != null 
                && (int)row.Cells[0].Value != 0
                select row;

            var random = new Random();

            foreach (var job in jobsWithoutIds)
            {
                int rnum;
                bool rnumFound;

                do
                {
                    rnum = random.Next(1, 999);
                    rnumFound = false;

                    foreach (DataGridViewRow row in jobsWithIds)
                    {
                        var rowIdValue = (int)row.Cells[0].Value;

                        if (rowIdValue == rnum)
                        {
                            rnumFound = true;
                            break;
                        }
                    }
                }
                while (rnumFound);

                job.Cells[0].Value = rnum;
            }
        }

        private FileStream CheckFileExistence(string filePath)
        {
            if (File.Exists(filePath))
            {
                return File.Create(filePath);
            }
            else
            {
                return File.OpenWrite(filePath);
            }
        }
        
        private void JobForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AddJobIds();

            FileStream saveFileStream;
            BinaryFormatter serializer = new BinaryFormatter();

            saveFileStream = CheckFileExistence(JobsFileName);
            serializer.Serialize(saveFileStream, jobsBindingList);

            saveFileStream = CheckFileExistence(AppDatesFileName);
            serializer.Serialize(saveFileStream, jobApplicationDates);

            saveFileStream.Close();
        }

        // USed internally for scoring jobs for recommendation purposes
        private int IncrementJobScore(DataGridViewRow job, string filterValue,
            int cellIndex, int trackBarValue)
        {
            var cellValue = job.Cells[cellIndex].Value;
            
            if (cellValue != null && filterValue == cellValue.ToString())
            {
                return trackBarValue;
            }
            else
            {
                return 0;
            }
        }
        
        private void RecommendJobs()
        {
            var jobScoreDict = new Dictionary<DataGridViewRow, int> { };

            int jobIndex = 0;

            var unappliedJobs =
                from DataGridViewRow row in jobDataGridView.Rows
                where row.Cells[5].Value != null 
                && (bool)row.Cells[5].Value == false
                select row;
            
            foreach (DataGridViewRow job in unappliedJobs)
            {
                var jobScore = 0;

                jobScore += IncrementJobScore(job, ftPtFilterValue, 2, 
                    ftPtSurveyTrackBarValue);

                jobScore += IncrementJobScore(job, empConFilterValue, 3,
                    empConSurveyTrackBarValue);

                jobScoreDict.Add(job, jobScore);

                jobIndex++;
            }

            var highestScores = 
                from entry in jobScoreDict
                orderby entry.Value descending
                select entry;

            recommendedDataGridView.Rows.Clear();

            if (jobScoreDict.Count > 3)
            {
                foreach (var entry in highestScores.Take(3))
                {
                    recommendedDataGridView.Rows.Add(
                        entry.Key.Cells[1].Value.ToString(), 
                        entry.Key.Cells[2].Value.ToString());
                }
            } 
            else
            {
                foreach (var entry in highestScores)
                {
                    recommendedDataGridView.Rows.Add(
                        entry.Key.Cells[1].Value.ToString(),
                        entry.Key.Cells[2].Value.ToString());
                }
            }
        }
        
        private void GetActionItems()
        {
            actionDataGridView.Rows.Clear();

            foreach (var entry in jobApplicationDates)
            {
                var applicationTime = entry.Value;
                var currentTime = DateTime.UtcNow;
                int daysPassed = (currentTime - applicationTime).Days;

                if (daysPassed >= 10)
                {
                    var GetMatchingJob =
                        from DataGridViewRow row in jobDataGridView.Rows
                        where !row.IsNewRow && (int)row.Cells[0].Value == entry.Key
                        select row;

                    foreach (var job in GetMatchingJob)
                    {
                        string positionTitle = (string)job.Cells[1].Value;
                        string employer = (string)job.Cells[2].Value;

                        var followUpActionItem = $"Follow up with {positionTitle} at {employer}";

                        actionDataGridView.Rows.Add(null, followUpActionItem);
                    }
                }
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 2)
            {
                RecommendJobs();
            }
            else if (tabControl.SelectedIndex == 3)
            {
                GetActionItems();
            }
        }

        private void ftPtFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ftPtFilterValue = ftPtFilterComboBox.SelectedItem.ToString();
        }

        private void empConFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            empConFilterValue = empConFilterComboBox.SelectedItem.ToString();
        }

        private void redoCareerValuesButton_Click(object sender, EventArgs e)
        {
            var valuesForm = new ValuesForm();
            valuesForm.ShowDialog();

            GetValuesList();

            ftPtSurveyTrackBarValue = valuesList[0];
            empConSurveyTrackBarValue = valuesList[1];
        }

        private void jobDataGridView_Leave(object sender, EventArgs e)
        {
            AddJobIds();
        }

        private void jobDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == jobDataGridView.Columns.IndexOf(appliedColumn))
            {
                if (jobDataGridView.CurrentRow != null
                    && jobDataGridView.CurrentCell != null 
                    && (bool)jobDataGridView.CurrentCell.Value == true)
                {
                    var jobId =
                        (int)jobDataGridView.Rows[e.RowIndex].Cells[0].Value;
                    var currentDateTime = DateTime.UtcNow;

                    if (jobApplicationDates.ContainsKey(jobId))
                    {
                        jobApplicationDates[jobId] = currentDateTime;
                    }
                    else
                    {
                        jobApplicationDates.Add(jobId, currentDateTime);
                    }

                }
            }
        }
    }
}
