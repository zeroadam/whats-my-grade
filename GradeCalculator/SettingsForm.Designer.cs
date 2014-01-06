namespace GradeCalculator
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpGradingMethod = new System.Windows.Forms.GroupBox();
            this.radGradingPercent = new System.Windows.Forms.RadioButton();
            this.radGradingPoints = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLetterValueD = new System.Windows.Forms.TextBox();
            this.lblLetterValueD = new System.Windows.Forms.Label();
            this.txtLetterValueC = new System.Windows.Forms.TextBox();
            this.lblLetterValueC = new System.Windows.Forms.Label();
            this.txtLetterValueB = new System.Windows.Forms.TextBox();
            this.lblLetterValueB = new System.Windows.Forms.Label();
            this.txtLetterValueA = new System.Windows.Forms.TextBox();
            this.lblLetterValueA = new System.Windows.Forms.Label();
            this.grpExamValues = new System.Windows.Forms.GroupBox();
            this.txtSettingsNumberOfExams = new System.Windows.Forms.TextBox();
            this.txtSettingsNumberOfProjects = new System.Windows.Forms.TextBox();
            this.lblSettingsNumberOfExams = new System.Windows.Forms.Label();
            this.lblSettingsNumberOfProjects = new System.Windows.Forms.Label();
            this.lblSettingsExamPoints = new System.Windows.Forms.Label();
            this.lblSettingsProjectPoints = new System.Windows.Forms.Label();
            this.txtSettingsExamPoints = new System.Windows.Forms.TextBox();
            this.chkSettingsExam = new System.Windows.Forms.CheckBox();
            this.chkSettingsProject = new System.Windows.Forms.CheckBox();
            this.txtSettingsProjectPoints = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.grpGradingMethod.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpExamValues.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGradingMethod
            // 
            this.grpGradingMethod.AutoSize = true;
            this.grpGradingMethod.Controls.Add(this.radGradingPercent);
            this.grpGradingMethod.Controls.Add(this.radGradingPoints);
            this.grpGradingMethod.Location = new System.Drawing.Point(12, 12);
            this.grpGradingMethod.Name = "grpGradingMethod";
            this.grpGradingMethod.Size = new System.Drawing.Size(121, 79);
            this.grpGradingMethod.TabIndex = 0;
            this.grpGradingMethod.TabStop = false;
            this.grpGradingMethod.Text = "Grading Method";
            // 
            // radGradingPercent
            // 
            this.radGradingPercent.AutoSize = true;
            this.radGradingPercent.Location = new System.Drawing.Point(12, 42);
            this.radGradingPercent.Name = "radGradingPercent";
            this.radGradingPercent.Size = new System.Drawing.Size(99, 17);
            this.radGradingPercent.TabIndex = 1;
            this.radGradingPercent.Text = "Percent System";
            this.radGradingPercent.UseVisualStyleBackColor = true;
            this.radGradingPercent.CheckedChanged += new System.EventHandler(this.radGradingPercent_CheckedChanged);
            // 
            // radGradingPoints
            // 
            this.radGradingPoints.AutoSize = true;
            this.radGradingPoints.Location = new System.Drawing.Point(12, 19);
            this.radGradingPoints.Name = "radGradingPoints";
            this.radGradingPoints.Size = new System.Drawing.Size(86, 17);
            this.radGradingPoints.TabIndex = 0;
            this.radGradingPoints.Text = "Point System";
            this.radGradingPoints.UseVisualStyleBackColor = true;
            this.radGradingPoints.CheckedChanged += new System.EventHandler(this.radGradingPoints_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLetterValueD);
            this.groupBox1.Controls.Add(this.lblLetterValueD);
            this.groupBox1.Controls.Add(this.txtLetterValueC);
            this.groupBox1.Controls.Add(this.lblLetterValueC);
            this.groupBox1.Controls.Add(this.txtLetterValueB);
            this.groupBox1.Controls.Add(this.lblLetterValueB);
            this.groupBox1.Controls.Add(this.txtLetterValueA);
            this.groupBox1.Controls.Add(this.lblLetterValueA);
            this.groupBox1.Location = new System.Drawing.Point(12, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 126);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Letter Grade Values";
            // 
            // txtLetterValueD
            // 
            this.txtLetterValueD.Location = new System.Drawing.Point(27, 96);
            this.txtLetterValueD.Name = "txtLetterValueD";
            this.txtLetterValueD.Size = new System.Drawing.Size(84, 20);
            this.txtLetterValueD.TabIndex = 7;
            // 
            // lblLetterValueD
            // 
            this.lblLetterValueD.AutoSize = true;
            this.lblLetterValueD.Location = new System.Drawing.Point(7, 98);
            this.lblLetterValueD.Name = "lblLetterValueD";
            this.lblLetterValueD.Size = new System.Drawing.Size(15, 13);
            this.lblLetterValueD.TabIndex = 6;
            this.lblLetterValueD.Text = "D";
            // 
            // txtLetterValueC
            // 
            this.txtLetterValueC.Location = new System.Drawing.Point(27, 70);
            this.txtLetterValueC.Name = "txtLetterValueC";
            this.txtLetterValueC.Size = new System.Drawing.Size(84, 20);
            this.txtLetterValueC.TabIndex = 5;
            // 
            // lblLetterValueC
            // 
            this.lblLetterValueC.AutoSize = true;
            this.lblLetterValueC.Location = new System.Drawing.Point(7, 72);
            this.lblLetterValueC.Name = "lblLetterValueC";
            this.lblLetterValueC.Size = new System.Drawing.Size(14, 13);
            this.lblLetterValueC.TabIndex = 4;
            this.lblLetterValueC.Text = "C";
            // 
            // txtLetterValueB
            // 
            this.txtLetterValueB.Location = new System.Drawing.Point(27, 44);
            this.txtLetterValueB.Name = "txtLetterValueB";
            this.txtLetterValueB.Size = new System.Drawing.Size(84, 20);
            this.txtLetterValueB.TabIndex = 3;
            // 
            // lblLetterValueB
            // 
            this.lblLetterValueB.AutoSize = true;
            this.lblLetterValueB.Location = new System.Drawing.Point(7, 46);
            this.lblLetterValueB.Name = "lblLetterValueB";
            this.lblLetterValueB.Size = new System.Drawing.Size(14, 13);
            this.lblLetterValueB.TabIndex = 2;
            this.lblLetterValueB.Text = "B";
            // 
            // txtLetterValueA
            // 
            this.txtLetterValueA.Location = new System.Drawing.Point(27, 18);
            this.txtLetterValueA.Name = "txtLetterValueA";
            this.txtLetterValueA.Size = new System.Drawing.Size(84, 20);
            this.txtLetterValueA.TabIndex = 1;
            // 
            // lblLetterValueA
            // 
            this.lblLetterValueA.AutoSize = true;
            this.lblLetterValueA.Location = new System.Drawing.Point(7, 20);
            this.lblLetterValueA.Name = "lblLetterValueA";
            this.lblLetterValueA.Size = new System.Drawing.Size(14, 13);
            this.lblLetterValueA.TabIndex = 0;
            this.lblLetterValueA.Text = "A";
            // 
            // grpExamValues
            // 
            this.grpExamValues.AutoSize = true;
            this.grpExamValues.Controls.Add(this.txtSettingsNumberOfExams);
            this.grpExamValues.Controls.Add(this.txtSettingsNumberOfProjects);
            this.grpExamValues.Controls.Add(this.lblSettingsNumberOfExams);
            this.grpExamValues.Controls.Add(this.lblSettingsNumberOfProjects);
            this.grpExamValues.Controls.Add(this.lblSettingsExamPoints);
            this.grpExamValues.Controls.Add(this.lblSettingsProjectPoints);
            this.grpExamValues.Controls.Add(this.txtSettingsExamPoints);
            this.grpExamValues.Controls.Add(this.chkSettingsExam);
            this.grpExamValues.Controls.Add(this.chkSettingsProject);
            this.grpExamValues.Controls.Add(this.txtSettingsProjectPoints);
            this.grpExamValues.Location = new System.Drawing.Point(139, 12);
            this.grpExamValues.Name = "grpExamValues";
            this.grpExamValues.Size = new System.Drawing.Size(230, 140);
            this.grpExamValues.TabIndex = 2;
            this.grpExamValues.TabStop = false;
            this.grpExamValues.Text = "Course Assignments";
            // 
            // txtSettingsNumberOfExams
            // 
            this.txtSettingsNumberOfExams.Enabled = false;
            this.txtSettingsNumberOfExams.Location = new System.Drawing.Point(121, 59);
            this.txtSettingsNumberOfExams.Name = "txtSettingsNumberOfExams";
            this.txtSettingsNumberOfExams.Size = new System.Drawing.Size(100, 20);
            this.txtSettingsNumberOfExams.TabIndex = 10;
            // 
            // txtSettingsNumberOfProjects
            // 
            this.txtSettingsNumberOfProjects.Enabled = false;
            this.txtSettingsNumberOfProjects.Location = new System.Drawing.Point(9, 59);
            this.txtSettingsNumberOfProjects.Name = "txtSettingsNumberOfProjects";
            this.txtSettingsNumberOfProjects.Size = new System.Drawing.Size(100, 20);
            this.txtSettingsNumberOfProjects.TabIndex = 9;
            // 
            // lblSettingsNumberOfExams
            // 
            this.lblSettingsNumberOfExams.AutoSize = true;
            this.lblSettingsNumberOfExams.Location = new System.Drawing.Point(118, 42);
            this.lblSettingsNumberOfExams.Name = "lblSettingsNumberOfExams";
            this.lblSettingsNumberOfExams.Size = new System.Drawing.Size(90, 13);
            this.lblSettingsNumberOfExams.TabIndex = 8;
            this.lblSettingsNumberOfExams.Text = "Number of Exams";
            // 
            // lblSettingsNumberOfProjects
            // 
            this.lblSettingsNumberOfProjects.AutoSize = true;
            this.lblSettingsNumberOfProjects.Location = new System.Drawing.Point(6, 42);
            this.lblSettingsNumberOfProjects.Name = "lblSettingsNumberOfProjects";
            this.lblSettingsNumberOfProjects.Size = new System.Drawing.Size(97, 13);
            this.lblSettingsNumberOfProjects.TabIndex = 7;
            this.lblSettingsNumberOfProjects.Text = "Number of Projects";
            // 
            // lblSettingsExamPoints
            // 
            this.lblSettingsExamPoints.AutoSize = true;
            this.lblSettingsExamPoints.Location = new System.Drawing.Point(118, 82);
            this.lblSettingsExamPoints.Name = "lblSettingsExamPoints";
            this.lblSettingsExamPoints.Size = new System.Drawing.Size(74, 13);
            this.lblSettingsExamPoints.TabIndex = 6;
            this.lblSettingsExamPoints.Text = "Highest Score";
            // 
            // lblSettingsProjectPoints
            // 
            this.lblSettingsProjectPoints.AutoSize = true;
            this.lblSettingsProjectPoints.Location = new System.Drawing.Point(6, 82);
            this.lblSettingsProjectPoints.Name = "lblSettingsProjectPoints";
            this.lblSettingsProjectPoints.Size = new System.Drawing.Size(74, 13);
            this.lblSettingsProjectPoints.TabIndex = 5;
            this.lblSettingsProjectPoints.Text = "Highest Score";
            // 
            // txtSettingsExamPoints
            // 
            this.txtSettingsExamPoints.Enabled = false;
            this.txtSettingsExamPoints.Location = new System.Drawing.Point(121, 101);
            this.txtSettingsExamPoints.Name = "txtSettingsExamPoints";
            this.txtSettingsExamPoints.Size = new System.Drawing.Size(100, 20);
            this.txtSettingsExamPoints.TabIndex = 4;
            // 
            // chkSettingsExam
            // 
            this.chkSettingsExam.AutoSize = true;
            this.chkSettingsExam.Location = new System.Drawing.Point(121, 19);
            this.chkSettingsExam.Name = "chkSettingsExam";
            this.chkSettingsExam.Size = new System.Drawing.Size(57, 17);
            this.chkSettingsExam.TabIndex = 3;
            this.chkSettingsExam.Text = "Exams";
            this.chkSettingsExam.UseVisualStyleBackColor = true;
            this.chkSettingsExam.CheckedChanged += new System.EventHandler(this.chkSettingsExamPoints_CheckedChanged);
            // 
            // chkSettingsProject
            // 
            this.chkSettingsProject.AutoSize = true;
            this.chkSettingsProject.Location = new System.Drawing.Point(9, 19);
            this.chkSettingsProject.Name = "chkSettingsProject";
            this.chkSettingsProject.Size = new System.Drawing.Size(64, 17);
            this.chkSettingsProject.TabIndex = 2;
            this.chkSettingsProject.Text = "Projects";
            this.chkSettingsProject.UseVisualStyleBackColor = true;
            this.chkSettingsProject.CheckedChanged += new System.EventHandler(this.chkSettingsProjectPoints_CheckedChanged);
            // 
            // txtSettingsProjectPoints
            // 
            this.txtSettingsProjectPoints.Enabled = false;
            this.txtSettingsProjectPoints.Location = new System.Drawing.Point(9, 101);
            this.txtSettingsProjectPoints.Name = "txtSettingsProjectPoints";
            this.txtSettingsProjectPoints.Size = new System.Drawing.Size(100, 20);
            this.txtSettingsProjectPoints.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(242, 320);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(323, 320);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(139, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 122);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Advanced Calculations";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(205, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Exam average is a percentage of total";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 355);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpExamValues);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpGradingMethod);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.grpGradingMethod.ResumeLayout(false);
            this.grpGradingMethod.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpExamValues.ResumeLayout(false);
            this.grpExamValues.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGradingMethod;
        private System.Windows.Forms.RadioButton radGradingPercent;
        private System.Windows.Forms.RadioButton radGradingPoints;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLetterValueD;
        private System.Windows.Forms.Label lblLetterValueD;
        private System.Windows.Forms.TextBox txtLetterValueC;
        private System.Windows.Forms.Label lblLetterValueC;
        private System.Windows.Forms.TextBox txtLetterValueB;
        private System.Windows.Forms.Label lblLetterValueB;
        private System.Windows.Forms.TextBox txtLetterValueA;
        private System.Windows.Forms.Label lblLetterValueA;
        private System.Windows.Forms.GroupBox grpExamValues;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSettingsProjectPoints;
        private System.Windows.Forms.CheckBox chkSettingsProject;
        private System.Windows.Forms.CheckBox chkSettingsExam;
        private System.Windows.Forms.TextBox txtSettingsExamPoints;
        private System.Windows.Forms.Label lblSettingsExamPoints;
        private System.Windows.Forms.Label lblSettingsProjectPoints;
        private System.Windows.Forms.TextBox txtSettingsNumberOfExams;
        private System.Windows.Forms.TextBox txtSettingsNumberOfProjects;
        private System.Windows.Forms.Label lblSettingsNumberOfExams;
        private System.Windows.Forms.Label lblSettingsNumberOfProjects;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}