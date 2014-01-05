//-----------------------------------------------------------------------
// <copyright file="ConfigurationFile.cs" company="Talegen Media, LLC">
//     Copyright (c) 2013 Talegen Media, LLC. All rights reserved.
// </copyright>
// <author>Rob Kennedy</author>
// <remarks>
// Private Source Code - Do Not Distribute
// </remarks>
//-----------------------------------------------------------------------
namespace GradeCalculator
{
    using System;
    using System.IO;
    using System.Text;
    using System.Windows.Forms;
    using System.Xml;
    using System.Xml.Serialization;
    
    /// <summary>
    /// General configuration file super-class used to build interfaces
    /// for retrieving and saving xml-configuration files.
    /// </summary>
    /// <authorname>Rob Kennedy</authorname>
    public class ConfigurationFile 
    {
        #region Private Properties

        /// <summary>Contains the configuration xml file path</summary>
        private string configurationFilePath;

        /// <summary>Contains a configuration file watcher for auto-reloading configuration changes</summary>
        private FileSystemWatcher configFileWatcher;
       
        #endregion

        #region Public Constructors
        /// <summary>
        /// Initializes a new instance of the ConfigurationFile class
        /// </summary>
        public ConfigurationFile()
            : this(string.Empty)
        {
            Properties.Resources.Culture = System.Threading.Thread.CurrentThread.CurrentUICulture;
        }

        /// <summary>
        /// Initializes a new instance of the ConfigurationFile class
        /// </summary>
        /// <param name="configurationFilePath">The xml file path to use for serialization</param>
        public ConfigurationFile(string configurationFilePath)
        {
            this.configurationFilePath = configurationFilePath;
        }

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the configuration file system watcher object
        /// </summary>
        [XmlIgnoreAttribute]
        public FileSystemWatcher ConfigurationWatcher
        {
            get
            {
                return this.configFileWatcher;
            }

            set
            {
                this.configFileWatcher = value;
            }
        }

        /// <summary>
        /// Gets or sets the configuration file path
        /// </summary>
        [XmlIgnoreAttribute]
        public string ConfigurationFilePath
        {
            get
            {
                return this.configurationFilePath;
            }

            set
            {
                this.configurationFilePath = value;
            }
        }
        #endregion

        #region Public Static Methods
        /// <summary>
        /// Load the specified configuration file into the current object
        /// </summary>
        /// <param name="configurationFilePath">The configuration file to load into the current object</param>
        /// <param name="objectType">Contains the object type to return</param>
        /// <returns>Returns the deserialized configuration object</returns>
        public static object Deserialize(string configurationFilePath, Type objectType)
        {
            object resultObject = null;
            FileStream textReader = null;

            if (File.Exists(configurationFilePath))
            {
                try
                {
                    XmlSerializer objectSerializer = new XmlSerializer(objectType);
                    XmlWriterSettings xmlWriteSettings = new XmlWriterSettings();
                    xmlWriteSettings.Indent = true;
                    xmlWriteSettings.IndentChars = " ";
                    xmlWriteSettings.Encoding = Encoding.UTF8;
                    xmlWriteSettings.NewLineChars = "\r\n";
                    xmlWriteSettings.NewLineOnAttributes = false;

                    textReader = File.Open(configurationFilePath, FileMode.Open, FileAccess.Read, FileShare.Read);
                    resultObject = objectSerializer.Deserialize(textReader);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (textReader != null)
                    {
                        textReader.Close();
                    }

                    if (resultObject != null)
                    {
                        ConfigurationFile type = (ConfigurationFile)resultObject;
                        type.ConfigurationFilePath = configurationFilePath;
                    }
                }
            }

            return resultObject;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Save the configuration file class
        /// </summary>
        public virtual void Serialize()
        {
            this.Serialize(this.configurationFilePath);
        }

        /// <summary>
        /// Save the configuration file class to a file path specified
        /// </summary>
        /// <param name="configurationFilePath">The configuration file path to save the object to</param>
        public virtual void Serialize(string configurationFilePath)
        {
            if (configurationFilePath != null ? configurationFilePath.Length > 0 : false)
            {
                this.configurationFilePath = configurationFilePath;
            }

            try
            {
                XmlSerializer objectSerializer = new XmlSerializer(this.GetType());
                XmlWriterSettings xmlWriteSettings = new XmlWriterSettings();
                xmlWriteSettings.Indent = true;
                xmlWriteSettings.IndentChars = " ";
                xmlWriteSettings.Encoding = Encoding.UTF8;
                xmlWriteSettings.NewLineChars = "\r\n";
                xmlWriteSettings.NewLineOnAttributes = false;

                using (XmlWriter xmlWriter = XmlTextWriter.Create(this.configurationFilePath, xmlWriteSettings))
                {
                    objectSerializer.Serialize(xmlWriter, this);
                    xmlWriter.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
