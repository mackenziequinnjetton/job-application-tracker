using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace JobApplicationTracker
{
    public partial class JobForm : Form
    {
        public JobForm()
        {
            InitializeComponent();
        }

        Excel.Application xlApp = new Excel.Application();
        Excel.Workbook xlWb;
        Excel.Worksheet xlWs;

        private void ReadExcel(string wbName, string wsName, 
            DataGridView targetDataGridView)
        {
            xlWb = xlApp.Workbooks.Open(wbName);
            xlWs = xlWb.Worksheets[wsName];

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
                    targetDataGridView.Columns.Add(col);
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
                    
                    targetDataGridView.Rows.Add(row);
                }
            }

            xlWb.Close();
            xlApp.Quit();

            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWb);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWs);
        }
        private void JobForm_Load(object sender, EventArgs e)
        {
            ReadExcel(@"C:\Users\macke\Documents\Otech\PROG2002\JobApplicationTracker\JobData.xlsx",
                "JobList", jobDataGridView);
        }
    }
}
