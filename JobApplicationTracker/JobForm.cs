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
        }

        BindingList<Job> jobsBindingList = new BindingList<Job>();
        const string JobsFileName = @"C:\Users\macke\Documents\Otech\PROG2002\JobApplicationTracker\JobData.bin";

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

            jobDataGridView.AutoGenerateColumns = false;
            // jobBindingSource.DataSource = null;
            // jobBindingSource.DataSource = jobsBindingList;
            jobDataGridView.DataSource = jobBindingSource;

            jobDataGridView.Update();

            var valuesForm = new ValuesForm();
            valuesForm.ShowDialog();
        }

        private void JobForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*jobsList = new List<Job>();

            int cellIndex = 0;

            foreach(DataGridViewRow row in jobDataGridView.Rows)
            {
                Job job = new Job("", "", "", "");

                foreach (DataGridViewCell cell in row.Cells)
                {
                    PropertyInfo[] jobProperties = job.GetType().GetProperties();
                    
                    jobProperties[cellIndex].SetValue(job, cell.Value, null);

                    cellIndex++;
                }

                jobsList.Add(job);

                cellIndex = 0;
            }*/

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

        private void jobDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            jobsBindingList.Clear();

            foreach (DataGridViewRow row in jobDataGridView.Rows)
            {
                jobsBindingList.Add(new Job(
                    row.Cells[0].ToString(),
                    row.Cells[1].ToString(),
                    row.Cells[2].ToString(),
                    row.Cells[3].ToString()
                ));
            }
        }
    }
}
