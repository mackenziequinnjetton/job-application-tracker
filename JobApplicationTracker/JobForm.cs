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
        List<int> valuesList;
        BindingSource jobBindingSource;
        const string JobsFileName = @"C:\Users\macke\Documents\Otech\PROG2002\JobApplicationTracker\JobData.bin";
        const string ValuesFileName = @"C:\Users\macke\Documents\Otech\PROG2002\JobApplicationTracker\ValuesData.bin";
        public static int ftPtSurveyTrackBarValue;
        public static int empConSurveyTrackBarValue;
        string ftPtFilterValue;
        string empConFilterValue;

        private List<int> GetValuesList()
        {
            FileStream openFileStream = File.OpenRead(ValuesFileName);
            BinaryFormatter deserializer = new BinaryFormatter();
            valuesList = (List<int>)deserializer.Deserialize(openFileStream);
            openFileStream.Close();
            return valuesList;
        }
        
        private void JobForm_Load(object sender, EventArgs e)
        {
            // BindingSource jobBindingSource = new BindingSource();

            // jobDataGridView.DataSource = jobBindingSource;

            FileStream openFileStream;
            BinaryFormatter deserializer = new BinaryFormatter();

            if (File.Exists(JobsFileName))
            {
                openFileStream = File.OpenRead(JobsFileName);
                jobsBindingList = (BindingList<Job>)deserializer.Deserialize(openFileStream);
                openFileStream.Close();
            }

            jobBindingSource = new BindingSource(jobsBindingList, null);
            jobBindingSource.AllowNew = true;
            jobDataGridView.DataSource = jobBindingSource;

            jobDataGridView.Update();

            if (File.Exists(ValuesFileName))
            {
                valuesList = GetValuesList();
            }
            else
            {
                var valuesForm = new ValuesForm();
                valuesForm.ShowDialog();

                valuesList = GetValuesList();
            }

            ftPtSurveyTrackBarValue = valuesList[0];
            empConSurveyTrackBarValue = valuesList[1];
        }

        private void JobForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream saveFileStream;
            BinaryFormatter serializer = new BinaryFormatter();

            if (File.Exists(JobsFileName))
            {
                saveFileStream = File.Create(JobsFileName);
            }
            else
            {
                saveFileStream = File.OpenWrite(JobsFileName);
            }

            serializer.Serialize(saveFileStream, jobsBindingList);
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
                from entry in jobScoreDict
                orderby entry.Value descending
                select entry;

            recommendedDataGridView.Rows.Clear();

            if (jobScoreDict.Count > 3)
            {
                foreach (var entry in highestScores.Take(3))
                {
                    recommendedDataGridView.Rows.Add(
                        entry.Key.Cells[0].Value.ToString(), 
                        entry.Key.Cells[1].Value.ToString());
                }
            } 
            else
            {
                foreach (var entry in highestScores)
                {
                    recommendedDataGridView.Rows.Add(entry.Key.Clone());
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
            ftPtFilterValue = ftPtFilterComboBox.SelectedItem.ToString();
        }

        private void empConFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            empConFilterValue = empConFilterComboBox.SelectedItem.ToString();
        }
    }
}
