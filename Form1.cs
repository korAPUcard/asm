using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedStatusMonitor
{
    public partial class Form1 : Form
    {
        AboutBox1 aboutBox = new AboutBox1();

        public bool isBgProcessEnabled = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isBgProcessEnabled == true)
            {
                DialogResult dlrProgramShutdownAlert1 = MessageBox.Show("Are you sure to shutdown the program?\nIf you shutdown the program, you cannot check your devices status.", "Program Shutdown", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {

            }
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //BackgroundWorker bgw;
        }

        private void MenuStrip_App_MouseHover(object sender, EventArgs e)
        {
            this.MenuStrip_App.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
        }

        private void MenuStrip_Advanced_MouseHover(object sender, EventArgs e)
        {
            this.MenuStrip_App.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
        }

        private void MenuStrip_Help_MouseHover(object sender, EventArgs e)
        {
            this.MenuStrip_App.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
        }

        private void MenuStrip_App_Preferences_Click(object sender, EventArgs e)
        {

        }

        private void MenuStrip_App_ProgramRestart_Click(object sender, EventArgs e)
        {

        }

        private void MenuStrip_App_ProgramShutdown_Click(object sender, EventArgs e)
        {

        }

        private void MenuStrip_Help_About_Click(object sender, EventArgs e)
        {
            aboutBox.Show();
        }

        private void ManuStrip_Help_Manual_Click(object sender, EventArgs e)
        {

        }

        private void MenuStrip_Help_CheckUpdates_Click(object sender, EventArgs e)
        {

        }

        private void MenuStrip_Advanced_AIDiagnosis_Click(object sender, EventArgs e)
        {

        }
    }
    /*
    public class ASMMenuStripRenderer : ToolStripProfessionalRenderer
    {
        public ASMMenuStripRenderer() : base(new ASMDarkThemeColorTable()) { }
    }
    
    public class ASMDarkThemeColorTable : ProfessionalColorTable
    {
        public override Color MenuItemSelected
        {
            get { return ColorTranslator.FromHtml("2D333A"); }
        }

        public override Color MenuItemSelectedGradientBegin
        {
            get { return ColorTranslator.FromHtml("2D333A"); }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get { return ColorTranslator.FromHtml("22262B"); }
        }

        public override Color ToolStripDropDownBackground
        {
            get { return ColorTranslator.FromHtml("22262B"); }
        }
    }
    */
}
