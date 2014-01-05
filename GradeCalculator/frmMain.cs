
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeCalculator
{
    public partial class frmMain : Form
    {
        static int projectNumber = 1;
        static int previousTextTop = 17;
        static int previousLabelTop = 20;
        IDictionary<string, gradeEntry> col = new Dictionary<string, gradeEntry>();
        string settingsPath = "gradecalculator.xml";

        public frmMain()
        {
            InitializeComponent();
        }

        public ApplicationSettings Settings { set; get; }

        private void resetDisplay()
        {
            grpBoxScores.Controls.Clear();
            col.Clear();
            previousLabelTop = 20;
            previousTextTop = 17;

            if (this.Settings.GradingMethod == GradingMethods.Points)
                this.lblPointsNeeded.Text = "Points Needed";

            if (this.Settings.GradingMethod == GradingMethods.Percent)
                this.lblPointsNeeded.Text = "Percent Needed";
        }

        private void calculate()
        {
            int total = 0;
            int maxScore = 0;

            foreach (var x in col.Values)
            {
                char nameType = x.Name[0];

                if (nameType == 'P')
                {
                    maxScore = this.Settings.ProjectMax;
                }
                else if (nameType == 'E')
                {
                    maxScore = this.Settings.ExamMax;
                }

                if (int.Parse(x.txtEntry.Text) > maxScore)
                {
                    total = total + maxScore;
                }
                else if (int.Parse(x.txtEntry.Text) < 1)
                {
                    // Do nothing.. same as adding 0
                }
                else
                {
                    total = total + int.Parse(x.txtEntry.Text);
                }
            }

            txtTotalPoints.Text = total.ToString();
            txtPointsA.Text = (this.Settings.LetterGradeA - total).ToString();
            txtPointsB.Text = (this.Settings.LetterGradeB - total).ToString();
            txtPointsC.Text = (this.Settings.LetterGradeC - total).ToString();
            txtPointsD.Text = (this.Settings.LetterGradeD - total).ToString();
        }

        private void drawCalculator()
        {
            resetDisplay();
            string[] calcProjects;
            string[] calcExams;
            int totalEntries = 0;

            if (this.Settings.Projects)
            {
                int projects = this.Settings.NumberOfProjects;
                calcProjects = new string[projects];

                for (int i = 0; i < projects; i++)
                {
                    calcProjects[i] = "Project " + (i + 1);
                    totalEntries++;
                }
                
                foreach (string name in calcProjects)
                {
                    col[name] = new gradeEntry { Name = name };
                }
            }

            if (this.Settings.Exams)
            {
                int exams = this.Settings.NumberOfExams;
                calcExams = new string[exams];

                for (int i = 0; i < exams; i++)
                {
                    calcExams[i] = "Exam " + (i + 1);
                    totalEntries++;
                }

                foreach (string name in calcExams)
                {
                    col[name] = new gradeEntry { Name = name };
                }
            }

            foreach (var x in col.Values)
            {
                int projectLeft = 20;
                int examLeft = 26;
                x.lblEntry.AutoSize = true;
                x.lblEntry.Text = x.Name;
                grpBoxScores.Controls.Add(x.lblEntry);
                grpBoxScores.Controls.Add(x.txtEntry);
                x.lblEntry.Top = previousLabelTop;
                x.lblEntry.Left = 7;
                x.txtEntry.Top = previousTextTop;
                if (x.Name[0] == 'P')
                {
                    x.txtEntry.Left = x.lblEntry.Width + projectLeft;
                }

                if (x.Name[0] == 'E')
                {
                    x.txtEntry.Left = x.lblEntry.Width + examLeft;
                }

                previousTextTop += 25;
                previousLabelTop += 25;
                projectNumber++;
            }

            grpBoxScores.Height = previousTextTop + 10;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(this.Settings);
            settingsForm.ShowDialog(this);
            drawCalculator();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Settings = (ApplicationSettings)ApplicationSettings.Deserialize(settingsPath, typeof(ApplicationSettings));
            if (this.Settings.GradingMethod == GradingMethods.Points)
                this.lblPointsNeeded.Text = "Points Needed";

            if (this.Settings.GradingMethod == GradingMethods.Percent)
                this.lblPointsNeeded.Text = "Percent Needed";

            drawCalculator();
        }
    }
}
