using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;

namespace JobApplicationTracker
{
    public partial class JobForm : Form
    {
        public JobForm()
        {
            InitializeComponent();
        }

        /*Excel.Application xlApp = new Excel.Application();
        Excel.Workbook xlWb;
        Excel.Worksheet xlWs;

        private void ReadExcel(string wbName, DataGridView dgv)
        {
            xlWb = xlApp.Workbooks.Open(wbName);
            xlWs = xlWb.Worksheets["Sheet1"];

            for (int iCol = 1; iCol <= xlWs.Columns.Count; iCol++)
            {
                if (xlWs.Cells[1, iCol].value == null)
                {
                    break;
                }
                else
                {
                    DataGridViewColumn col = new DataGridViewTextBoxColumn();
                    col.HeaderText = xlWs.Cells[1, iCol].Value;
                    dgv.Columns.Add(col);
                }
            }

            for (int iRow = 2; iRow <= xlWs.Rows.Count; iRow++)
            {
                if (xlWs.Cells[iRow, 1].value == null)
                {
                    break;
                }
                else
                {
                    string[] row = new string[] {
                        xlWs.Cells[iRow, 1].Value,
                        xlWs.Cells[iRow, 2].Value,
                        xlWs.Cells[iRow, 3].Value,
                        xlWs.Cells[iRow, 4].Value,
                    };
                    
                    dgv.Rows.Add(row);
                }
            }

            xlWb.Close();
            xlApp.Quit();

            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWb);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWs);
        }

        private void SaveToExcel(DataGridView dgv, string xlWb)
        {
            StreamWriter wr = new StreamWriter(xlWb);

            int cols = dgv.Columns.Count;
        }*/

        [Serializable()]
        public class Job
        {
            public int IdNumber { get; set; }
            public string PositionTitle { get; set; }
            public string Employer { get; set; }
            public string FtPt { get; set; }
            public string EmpCon { get; set; }
            public bool Applied { get; set; }

            public Job(
                int idNumber,
                string positionTitle, 
                string employer, 
                string ftPt, 
                string empCon,
                bool applied
                )
            {
                IdNumber = idNumber;
                PositionTitle = positionTitle;
                Employer = employer;
                FtPt = ftPt;
                EmpCon = empCon;
                Applied = applied;
            }

            public Job() { }
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
            // BindingSource jobBindingSource = new BindingSource();

            // jobDataGridView.DataSource = jobBindingSource;

            // FileStream openFileStream;
            // BinaryFormatter deserializer = new BinaryFormatter();

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
            string positionTitle = "";
            string employer = "";
            var FollowUpActionItem = $"Follow up with {positionTitle} at {employer}";

            actionDataGridView.Rows.Clear();

            actionDataGridView.Rows.Add(FollowUpActionItem);
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
            if (e.ColumnIndex == appliedColumn.Index)
            {
                if (jobDataGridView.CurrentCell != null 
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
