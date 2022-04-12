using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplicationTracker
{
    [Serializable]
    internal class Job
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
}
