using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UvDemo
{
    public partial class frmMain : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private string _programVersion = string.Empty;

        private string _settingsFolderPath = string.Empty;

        public frmMain()
        {
            InitializeComponent();

            try
            {
                logger.Info("entering {0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);

                _programVersion = string.Format("{0}.{1}.{2}",
                                        Assembly.GetExecutingAssembly().GetName().Version.Major.ToString(),
                                        Assembly.GetExecutingAssembly().GetName().Version.Minor.ToString(),
                                        Assembly.GetExecutingAssembly().GetName().Version.Build.ToString());

                this.Text = string.Format("{0}  V{1}", Assembly.GetExecutingAssembly().GetName().Name, _programVersion);

            }

            catch (Exception ex)
            {
                logger.Error(ex);
            }
            finally
            {
                logger.Info("exiting  {0}.{1}", this.GetType().Name, MethodBase.GetCurrentMethod().Name);
            }

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {

                pgSpectrometerSettings.SelectedObject = new SpectrometerSettingsModel();

                _settingsFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), Assembly.GetExecutingAssembly().GetName().Name, "settings");

                Directory.CreateDirectory(_settingsFolderPath);

            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
            finally
            {
                logger.Info("exiting  {0}.{1}", this.GetType().Name, MethodBase.GetCurrentMethod().Name);
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiOpenLogsFolder_Click(object sender, EventArgs e)
        {
            string logsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), Assembly.GetExecutingAssembly().GetName().Name, "logs");
            OpenFolderInExplorerWindow(logsPath);
        }

        private void OpenFolderInExplorerWindow(string folderPath)
        {
            try
            {
                Process.Start("explorer.exe", folderPath);
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void tsmiShowHelpDocs_Click(object sender, EventArgs e)
        {
            try
            {

                string helpFilesFolderPath = Path.Combine(System.IO.Path.GetDirectoryName(Application.ExecutablePath), "HelpFiles");
                string helpHTMLPath = Path.Combine(helpFilesFolderPath, "Help.html");

                System.Diagnostics.Process.Start(helpHTMLPath);
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }

        }

        private void btnSaveSpecSettings_Click(object sender, EventArgs e)
        {
            try
            {
                logger.Info("entering {0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);

                // serialize the property grid object to a file

                string defaultSettingsFileName = string.Format("SpectrometerSettings_{0}.xml", DateTime.Now.ToString("yyMMdd_HHmmss"));
                string settingsFileName = string.Empty;

                // Use a save file dialog to get the file name
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = _settingsFolderPath;
                saveFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = false;
                saveFileDialog.FileName = defaultSettingsFileName;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    settingsFileName = saveFileDialog.FileName;

                    SpectrometerSettingsModel settings = (SpectrometerSettingsModel)pgSpectrometerSettings.SelectedObject;

                    // serialize the settings object to a file
                    settings.Save(_settingsFolderPath, defaultSettingsFileName);

                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
            finally
            {
                logger.Info("exiting  {0}.{1}", this.GetType().Name, MethodBase.GetCurrentMethod().Name);
            }
        }

        private void btnOpenSpectrometerSettings_Click(object sender, EventArgs e)
        {
            // Use file dialog to select the settings file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = _settingsFolderPath;
            openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    logger.Info("entering {0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);

                    SpectrometerSettingsModel settings = SpectrometerSettingsModel.Load<SpectrometerSettingsModel>(_settingsFolderPath, openFileDialog.SafeFileName);

                    pgSpectrometerSettings.SelectedObject = settings;
                }
                catch (Exception ex)
                {
                    logger.Error(ex);
                }
                finally
                {
                    logger.Info("exiting  {0}.{1}", this.GetType().Name, MethodBase.GetCurrentMethod().Name);
                }
            }


        }
    }
}
