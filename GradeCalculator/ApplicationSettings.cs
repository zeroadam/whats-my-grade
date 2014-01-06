
namespace GradeCalculator
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// Enumeration for grading methods
    /// </summary>
    public enum GradingMethods : int
    {
        /// <summary>
        /// Defines the value for Points method
        /// </summary>
        Points = 0,

        /// <summary>
        /// Defines the value for Percent method
        /// </summary>
        Percent = 1
    }

    /// <summary>
    /// Represents the serializable application settings file object
    /// </summary>
    public class ApplicationSettings : ConfigurationFile
    {
        #region Public Constructors
        /// <summary>
        /// Initializes a new instance of the ApplicationSettings class
        /// </summary>
        public ApplicationSettings() 
            : this(string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationSettings class
        /// </summary>
        /// <param name="configurationFilePath">Contains the configuration file path to load</param>
        public ApplicationSettings(string configurationFilePath)
            : base(configurationFilePath)
        {            
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the Grading Method setting value
        /// </summary>
        public GradingMethods GradingMethod { get; set; }

        /// <summary>
        /// Gets or sets the value to achieve grade A
        /// </summary>
        public int LetterGradeA { get; set; }

        /// <summary>
        /// Gets or sets the value to achieve grade B
        /// </summary>
        public int LetterGradeB { get; set; }

        /// <summary>
        /// Gets or sets the value to achieve grade C
        /// </summary>
        public int LetterGradeC { get; set; }

        /// <summary>
        /// Gets or sets the value to achieve grade D
        /// </summary>
        public int LetterGradeD { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether projects are used
        /// </summary>
        public bool Projects { get; set; }

        /// <summary>
        /// Gets or sets the maximum value for Projects
        /// </summary>
        public int ProjectMax { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether exams are used
        /// </summary>
        public bool Exams { get; set; }

        /// <summary>
        /// Gets or sets the maximum value for Exams
        /// </summary>
        public int ExamMax { get; set; }

        /// <summary>
        /// Gets or sets number of Projects
        /// </summary>
        public int NumberOfProjects { get; set; }

        /// <summary>
        /// Gets or sets number of Exams
        /// </summary>
        public int NumberOfExams { get; set; }

        #endregion
    }
}
