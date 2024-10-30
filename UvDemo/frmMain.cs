using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpWinFormsTemplate
{
    public partial class frmMain : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private string _programVersion;

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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }
    }
}
