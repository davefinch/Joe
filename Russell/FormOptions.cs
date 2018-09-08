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
            // Load up the Agency Combo Box
            using (Sql sql = new Sql())
            {
                Dictionary<string, int> listAgency = new Dictionary<string, int>();

                // Function determined by the type of db we are connecting to
                if (Constants.DBMS == "MSSQL") { listAgency = sql.SQLGetAgencies(); } else { listAgency = sql.OLEGetAgencies(); }

                comboBoxDefaultAgency.DataSource = listAgency.ToList();
                comboBoxDefaultAgency.DisplayMember = "Key";
                comboBoxDefaultAgency.ValueMember = "Value";

            }


                // Choose Graph Type
                // Choose...
        }

        private void buttonSaveClose_Click(object sender, EventArgs e)
        {
            // Save Settings


            // Close window
            this.Close();
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            // Close window
            this.Close();
        }
    }
}
