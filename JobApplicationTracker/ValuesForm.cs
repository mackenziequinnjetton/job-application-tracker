using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace JobApplicationTracker
{
    public partial class ValuesForm : Form
    {
        public ValuesForm()
        {
            InitializeComponent();
        }

        string ValuesFileName = Application.StartupPath + @"\ValuesData.bin";
        List<int> valuesList = new List<int>();

        private void submitSurveyButton_Click(object sender, EventArgs e)
        {
            valuesList.Add(ftPtSurveyTrackBar.Value);
            valuesList.Add(empConSurveyTrackBar.Value);

            FileStream saveFileStream;
            BinaryFormatter serializer = new BinaryFormatter();

            if (File.Exists(ValuesFileName))
            {
                saveFileStream = File.Create(ValuesFileName);
            }
            else
            {
                saveFileStream = File.OpenWrite(ValuesFileName);
            }

            serializer.Serialize(saveFileStream, valuesList);
            saveFileStream.Close();

            Close();
        }
    }
}
