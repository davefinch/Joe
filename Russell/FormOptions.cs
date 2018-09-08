using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Russell
{
    public partial class FormOptions : Form
    {
        public FormOptions()
        {
            InitializeComponent();
            this.Text = Constants.AppName + " - Settings"; 
        }

        private void FormOptions_Load(object sender, EventArgs e)
        {

            // Choose Default Agency
            // Choose Graph Type
            // Choose...
        }

        private void buttonSaveClose_Click(object sender, EventArgs e)
        {
            // Save Settings


            // Close window
            this.Close();
        }
    }
}
