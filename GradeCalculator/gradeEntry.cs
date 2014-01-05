///
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalculator
{
    /// <summary>
    /// Grade entry class
    /// </summary>
    class gradeEntry
    {
        public System.Windows.Forms.Label lblEntry; //= new System.Windows.Forms.Label();
        public System.Windows.Forms.TextBox txtEntry; // = new System.Windows.Forms.TextBox();
        public string Name { get; set; }

        public gradeEntry()
        {
            lblEntry = new System.Windows.Forms.Label();
            txtEntry = new System.Windows.Forms.TextBox();
        }
    }
}
