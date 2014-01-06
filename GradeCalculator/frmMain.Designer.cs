///
namespace GradeCalculator
{
    /// <summary>
    /// 
    /// </summary>
    partial class frmMain
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
            this.grpBoxScores = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.grpBoxResults = new System.Windows.Forms.GroupBox();
            this.lblPercentNeeded = new System.Windows.Forms.Label();
            this.lblPointsNeeded = new System.Windows.Forms.Label();
            this.lblGradeDesired = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.txtPointsD = new System.Windows.Forms.TextBox();
            this.txtGradeD = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.txtPointsC = new System.Windows.Forms.TextBox();
            this.txtGradeC = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtPointsB = new System.Windows.Forms.TextBox();
            this.txtGradeB = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtPointsA = new System.Windows.Forms.TextBox();
            this.txtGradeA = new System.Windows.Forms.TextBox();
            this.txtTotalPoints = new System.Windows.Forms.TextBox();
            this.lblTotalPoints = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grpBoxResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxScores
            // 
            this.grpBoxScores.Location = new System.Drawing.Point(12, 27);
            this.grpBoxScores.Name = "grpBoxScores";
            this.grpBoxScores.Size = new System.Drawing.Size(337, 148);
            this.grpBoxScores.TabIndex = 0;
            this.grpBoxScores.TabStop = false;
            this.grpBoxScores.Text = "Scores";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(708, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(89, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.toolStripSeparator2});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(113, 6);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 411);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(708, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // grpBoxResults
            // 
            this.grpBoxResults.Controls.Add(this.lblPercentNeeded);
            this.grpBoxResults.Controls.Add(this.lblPointsNeeded);
            this.grpBoxResults.Controls.Add(this.lblGradeDesired);
            this.grpBoxResults.Controls.Add(this.textBox11);
            this.grpBoxResults.Controls.Add(this.txtPointsD);
            this.grpBoxResults.Controls.Add(this.txtGradeD);
            this.grpBoxResults.Controls.Add(this.textBox8);
            this.grpBoxResults.Controls.Add(this.txtPointsC);
            this.grpBoxResults.Controls.Add(this.txtGradeC);
            this.grpBoxResults.Controls.Add(this.textBox5);
            this.grpBoxResults.Controls.Add(this.txtPointsB);
            this.grpBoxResults.Controls.Add(this.txtGradeB);
            this.grpBoxResults.Controls.Add(this.textBox4);
            this.grpBoxResults.Controls.Add(this.txtPointsA);
            this.grpBoxResults.Controls.Add(this.txtGradeA);
            this.grpBoxResults.Controls.Add(this.txtTotalPoints);
            this.grpBoxResults.Controls.Add(this.lblTotalPoints);
            this.grpBoxResults.Location = new System.Drawing.Point(369, 27);
            this.grpBoxResults.Name = "grpBoxResults";
            this.grpBoxResults.Size = new System.Drawing.Size(327, 196);
            this.grpBoxResults.TabIndex = 10;
            this.grpBoxResults.TabStop = false;
            this.grpBoxResults.Text = "Results";
            // 
            // lblPercentNeeded
            // 
            this.lblPercentNeeded.AutoSize = true;
            this.lblPercentNeeded.Location = new System.Drawing.Point(240, 75);
            this.lblPercentNeeded.Name = "lblPercentNeeded";
            this.lblPercentNeeded.Size = new System.Drawing.Size(56, 13);
            this.lblPercentNeeded.TabIndex = 16;
            this.lblPercentNeeded.Text = "% Needed";
            // 
            // lblPointsNeeded
            // 
            this.lblPointsNeeded.AutoSize = true;
            this.lblPointsNeeded.Location = new System.Drawing.Point(123, 75);
            this.lblPointsNeeded.Name = "lblPointsNeeded";
            this.lblPointsNeeded.Size = new System.Drawing.Size(77, 13);
            this.lblPointsNeeded.TabIndex = 15;
            this.lblPointsNeeded.Text = "Points Needed";
            // 
            // lblGradeDesired
            // 
            this.lblGradeDesired.AutoSize = true;
            this.lblGradeDesired.Location = new System.Drawing.Point(21, 75);
            this.lblGradeDesired.Name = "lblGradeDesired";
            this.lblGradeDesired.Size = new System.Drawing.Size(66, 13);
            this.lblGradeDesired.TabIndex = 14;
            this.lblGradeDesired.Text = "Letter Grade";
            // 
            // textBox11
            // 
            this.textBox11.Enabled = false;
            this.textBox11.Location = new System.Drawing.Point(218, 167);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 13;
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPointsD
            // 
            this.txtPointsD.Enabled = false;
            this.txtPointsD.Location = new System.Drawing.Point(112, 167);
            this.txtPointsD.Name = "txtPointsD";
            this.txtPointsD.Size = new System.Drawing.Size(100, 20);
            this.txtPointsD.TabIndex = 12;
            this.txtPointsD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGradeD
            // 
            this.txtGradeD.Enabled = false;
            this.txtGradeD.Location = new System.Drawing.Point(6, 167);
            this.txtGradeD.Name = "txtGradeD";
            this.txtGradeD.Size = new System.Drawing.Size(100, 20);
            this.txtGradeD.TabIndex = 11;
            this.txtGradeD.Text = "D";
            this.txtGradeD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(218, 143);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 10;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPointsC
            // 
            this.txtPointsC.Enabled = false;
            this.txtPointsC.Location = new System.Drawing.Point(112, 143);
            this.txtPointsC.Name = "txtPointsC";
            this.txtPointsC.Size = new System.Drawing.Size(100, 20);
            this.txtPointsC.TabIndex = 9;
            this.txtPointsC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGradeC
            // 
            this.txtGradeC.Enabled = false;
            this.txtGradeC.Location = new System.Drawing.Point(6, 143);
            this.txtGradeC.Name = "txtGradeC";
            this.txtGradeC.Size = new System.Drawing.Size(100, 20);
            this.txtGradeC.TabIndex = 8;
            this.txtGradeC.Text = "C";
            this.txtGradeC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(218, 117);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 7;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPointsB
            // 
            this.txtPointsB.Enabled = false;
            this.txtPointsB.Location = new System.Drawing.Point(112, 117);
            this.txtPointsB.Name = "txtPointsB";
            this.txtPointsB.Size = new System.Drawing.Size(100, 20);
            this.txtPointsB.TabIndex = 6;
            this.txtPointsB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGradeB
            // 
            this.txtGradeB.Enabled = false;
            this.txtGradeB.Location = new System.Drawing.Point(6, 117);
            this.txtGradeB.Name = "txtGradeB";
            this.txtGradeB.Size = new System.Drawing.Size(100, 20);
            this.txtGradeB.TabIndex = 5;
            this.txtGradeB.Text = "B";
            this.txtGradeB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(218, 91);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 4;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPointsA
            // 
            this.txtPointsA.Enabled = false;
            this.txtPointsA.Location = new System.Drawing.Point(112, 91);
            this.txtPointsA.Name = "txtPointsA";
            this.txtPointsA.Size = new System.Drawing.Size(100, 20);
            this.txtPointsA.TabIndex = 3;
            this.txtPointsA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGradeA
            // 
            this.txtGradeA.Enabled = false;
            this.txtGradeA.Location = new System.Drawing.Point(6, 91);
            this.txtGradeA.Name = "txtGradeA";
            this.txtGradeA.Size = new System.Drawing.Size(100, 20);
            this.txtGradeA.TabIndex = 2;
            this.txtGradeA.Text = "A";
            this.txtGradeA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalPoints
            // 
            this.txtTotalPoints.Enabled = false;
            this.txtTotalPoints.Location = new System.Drawing.Point(145, 19);
            this.txtTotalPoints.Name = "txtTotalPoints";
            this.txtTotalPoints.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPoints.TabIndex = 1;
            this.txtTotalPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotalPoints
            // 
            this.lblTotalPoints.AutoSize = true;
            this.lblTotalPoints.Location = new System.Drawing.Point(76, 22);
            this.lblTotalPoints.Name = "lblTotalPoints";
            this.lblTotalPoints.Size = new System.Drawing.Size(63, 13);
            this.lblTotalPoints.TabIndex = 0;
            this.lblTotalPoints.Text = "Total Grade";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(537, 372);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 433);
            this.Controls.Add(this.grpBoxResults);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpBoxScores);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMain";
            this.Text = "What\'s My Grade";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpBoxResults.ResumeLayout(false);
            this.grpBoxResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxScores;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox grpBoxResults;
        private System.Windows.Forms.Label lblPercentNeeded;
        private System.Windows.Forms.Label lblPointsNeeded;
        private System.Windows.Forms.Label lblGradeDesired;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox txtPointsD;
        private System.Windows.Forms.TextBox txtGradeD;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox txtPointsC;
        private System.Windows.Forms.TextBox txtGradeC;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtPointsB;
        private System.Windows.Forms.TextBox txtGradeB;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtPointsA;
        private System.Windows.Forms.TextBox txtGradeA;
        private System.Windows.Forms.TextBox txtTotalPoints;
        private System.Windows.Forms.Label lblTotalPoints;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}
