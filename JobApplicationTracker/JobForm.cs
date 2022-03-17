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

        private void JobForm_Load(object sender, EventArgs e)
        {

        }
    }
}
