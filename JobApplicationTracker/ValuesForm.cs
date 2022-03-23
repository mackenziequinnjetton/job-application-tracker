using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobApplicationTracker
{
    public partial class ValuesForm : Form
    {
        public ValuesForm()
        {
            InitializeComponent();
        }

        int ftPtSurveyTrackBarValue;
        int empConSurveyTrackBarValue;

        private void submitSurveyButton_Click(object sender, EventArgs e)
        {
            ftPtSurveyTrackBarValue = ftPtSurveyTrackBar.Value;
            empConSurveyTrackBarValue = empConSurveyTrackBar.Value;

            Close();
        }
    }
}
