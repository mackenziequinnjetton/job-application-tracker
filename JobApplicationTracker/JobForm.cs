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
            public string PositionTitle { get; set; }
            public string Employer { get; set; }
            public string FtPt { get; set; }
            public string EmpCon { get; set; }

            public Job(string positionTitle, 
                string employer, 
                string ftPt, 
                string empCon)
            {
                PositionTitle = positionTitle;
                Employer = employer;
                FtPt = ftPt;
                EmpCon = empCon;
            }

            public Job() { }
        }

        BindingList<Job> jobsBindingList = new BindingList<Job>();
        BindingSource jobBindingSource;
        const string JobsFileName = @"C:\Users\macke\Documents\Otech\PROG2002\JobApplicationTracker\JobData.bin";
        public static int ftPtSurveyTrackBarValue;
        public static int empConSurveyTrackBarValue;
        string ftPtFilterValue;
        string empConFilterValue;

        private void JobForm_Load(object sender, EventArgs e)
        {
            // BindingSource jobBindingSource = new BindingSource();
            
            // jobDataGridView.DataSource = jobBindingSource;
            
            
            if (File.Exists(JobsFileName))
            {
                FileStream openFileStream = File.OpenRead(JobsFileName);
                BinaryFormatter deserializer = new BinaryFormatter();
                jobsBindingList = (BindingList<Job>)deserializer.Deserialize(openFileStream);
                openFileStream.Close();
            }

            // jobDataGridView.AutoGenerateColumns = false;
            jobBindingSource = new BindingSource(jobsBindingList, null);
            jobBindingSource.AllowNew = true;
            jobDataGridView.DataSource = jobBindingSource;

            jobDataGridView.Update();

            var valuesForm = new ValuesForm();
            valuesForm.ShowDialog();

            ftPtSurveyTrackBarValue = valuesForm.ftPtSurveyTrackBar.Value;
            empConSurveyTrackBarValue = valuesForm.empConSurveyTrackBar.Value;
        }

        private void JobForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           FileStream saveFileStream;

            if (File.Exists(JobsFileName))
            {
                saveFileStream = File.Create(JobsFileName);
            }
            else
            {
                saveFileStream = File.OpenWrite(JobsFileName);
            }
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(saveFileStream, jobsBindingList);
            saveFileStream.Close();
        }

        private int IncrementJobScore(DataGridViewRow job, string filterValue,
            int cellIndex, int trackBarValue)
        {
            if (filterValue == job.Cells[cellIndex].Value.ToString())
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
            
            foreach (DataGridViewRow job in jobDataGridView.Rows)
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
                (from entry in jobScoreDict
                orderby entry.Value descending
                select entry).Take(3);

            recommendedDataGridView.Rows.Clear();

            if (jobScoreDict.Count > 3)
            {
                foreach (var entry in highestScores)
                {
                    recommendedDataGridView.Rows.Add(entry);
                }
            }
        }
        
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 2)
            {
                RecommendJobs();
            }
        }

        private void ftPtFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ftPtFilterValue = ftPtFilterComboBox.SelectedValue.ToString();
        }

        private void empConFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            empConFilterValue = empConFilterComboBox.SelectedValue.ToString();
        }
    }
}
