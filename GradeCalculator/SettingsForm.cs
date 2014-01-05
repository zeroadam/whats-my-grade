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
    public partial class SettingsForm : Form
    {
        private int letterA;
        private int letterB;
        private int letterC;
        private int letterD;

        public ApplicationSettings Settings { get; set; }

        public SettingsForm(ApplicationSettings settings)
        {
            InitializeComponent();
            this.Settings = settings;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            if (this.Settings.GradingMethod == GradingMethods.Points)
            {
                this.radGradingPoints.Checked = true;
            }

            if (this.Settings.GradingMethod == GradingMethods.Percent)
            {
                this.radGradingPercent.Checked = true;
            }

            this.letterA = this.Settings.LetterGradeA;
            this.letterB = this.Settings.LetterGradeB;
            this.letterC = this.Settings.LetterGradeC;
            this.letterD = this.Settings.LetterGradeD;

            this.txtLetterValueA.Text = this.letterA.ToString();
            this.txtLetterValueB.Text = this.letterB.ToString();
            this.txtLetterValueC.Text = this.letterC.ToString();
            this.txtLetterValueD.Text = this.letterD.ToString();

            this.chkSettingsProject.Checked = this.Settings.Projects;
            this.txtSettingsProjectPoints.Text = this.Settings.ProjectMax.ToString();
            this.txtSettingsNumberOfProjects.Text = this.Settings.NumberOfProjects.ToString();
            this.chkSettingsExam.Checked = this.Settings.Exams;
            this.txtSettingsExamPoints.Text = this.Settings.ExamMax.ToString();
            this.txtSettingsNumberOfExams.Text = this.Settings.NumberOfExams.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Settings.LetterGradeA = int.Parse(txtLetterValueA.Text);
            this.Settings.LetterGradeB = int.Parse(txtLetterValueB.Text);
            this.Settings.LetterGradeC = int.Parse(txtLetterValueC.Text);
            this.Settings.LetterGradeD = int.Parse(txtLetterValueD.Text);

            this.Settings.ProjectMax = int.Parse(this.txtSettingsProjectPoints.Text);
            this.Settings.NumberOfProjects = int.Parse(this.txtSettingsNumberOfProjects.Text);
            this.Settings.ExamMax = int.Parse(this.txtSettingsExamPoints.Text);
            this.Settings.NumberOfExams = int.Parse(this.txtSettingsNumberOfExams.Text);

            this.Settings.Serialize();
            this.Close();
        }

        private void radGradingPoints_CheckedChanged(object sender, EventArgs e)
        {
            this.Settings.GradingMethod = GradingMethods.Points;

            if (this.letterA < 100)
            {
                this.letterA *= 10;
                this.letterB *= 10;
                this.letterC *= 10;
                this.letterD *= 10;

                this.txtLetterValueA.Text = this.letterA.ToString();
                this.txtLetterValueB.Text = this.letterB.ToString();
                this.txtLetterValueC.Text = this.letterC.ToString();
                this.txtLetterValueD.Text = this.letterD.ToString();
            }
            
        }

        private void radGradingPercent_CheckedChanged(object sender, EventArgs e)
        {
            this.Settings.GradingMethod = GradingMethods.Percent;

            if (this.letterA > 100)
            {
                this.letterA /= 10;
                this.letterB /= 10;
                this.letterC /= 10;
                this.letterD /= 10;

                this.txtLetterValueA.Text = this.letterA.ToString();
                this.txtLetterValueB.Text = this.letterB.ToString();
                this.txtLetterValueC.Text = this.letterC.ToString();
                this.txtLetterValueD.Text = this.letterD.ToString();
            }
        }

        private void chkSettingsProjectPoints_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSettingsProject.Checked)
            {
                this.txtSettingsProjectPoints.Enabled = true;
                this.txtSettingsNumberOfProjects.Enabled = true;
                this.Settings.Projects = true;
            }
            else
            {
                this.txtSettingsProjectPoints.Enabled = false;
                this.txtSettingsNumberOfProjects.Enabled = false;
                this.Settings.Projects = false;
            }
        }

        private void chkSettingsExamPoints_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSettingsExam.Checked)
            {
                this.txtSettingsExamPoints.Enabled = true;
                this.txtSettingsNumberOfExams.Enabled = true;
                this.Settings.Exams = true;
            }
            else
            {
                this.txtSettingsExamPoints.Enabled = false;
                this.txtSettingsNumberOfExams.Enabled = false;
                this.Settings.Exams = false;
            }
        }

    }
}
