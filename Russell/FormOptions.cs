using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

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
                comboBoxDefaultAgency.SelectedValue = Convert.ToInt32(ConfigurationManager.AppSettings["DefaultAgencyId"]);

            }

                //< add key = "DefaultAgencyId" value = "Talent Talks" />   
                //<add key = "ChartStyle" value = "Polar" />

            // Choose Graph Type
            // Load up Graph Style ComboBox
            comboBoxDefaultGraphStyle.Items.Add("Area");
            comboBoxDefaultGraphStyle.Items.Add("Bar");
            comboBoxDefaultGraphStyle.Items.Add("BoxPlot");
            comboBoxDefaultGraphStyle.Items.Add("Bubble");
            comboBoxDefaultGraphStyle.Items.Add("Candlestick");
            comboBoxDefaultGraphStyle.Items.Add("Column");
            comboBoxDefaultGraphStyle.Items.Add("Doughnut");
            comboBoxDefaultGraphStyle.Items.Add("ErrorBar");
            comboBoxDefaultGraphStyle.Items.Add("FastLine");
            comboBoxDefaultGraphStyle.Items.Add("FastPoint");
            comboBoxDefaultGraphStyle.Items.Add("Funnel");
            comboBoxDefaultGraphStyle.Items.Add("Kagi");
            comboBoxDefaultGraphStyle.Items.Add("Line");
            comboBoxDefaultGraphStyle.Items.Add("Pie");
            comboBoxDefaultGraphStyle.Items.Add("Point");
            comboBoxDefaultGraphStyle.Items.Add("PointAndFigure");
            comboBoxDefaultGraphStyle.Items.Add("Polar");
            comboBoxDefaultGraphStyle.Items.Add("Pyramid");
            comboBoxDefaultGraphStyle.Items.Add("Radar");
            comboBoxDefaultGraphStyle.Items.Add("Range");
            comboBoxDefaultGraphStyle.Items.Add("RangeBar");
            comboBoxDefaultGraphStyle.Items.Add("RangeColumn");
            comboBoxDefaultGraphStyle.Items.Add("Renko");
            comboBoxDefaultGraphStyle.Items.Add("Spline");
            comboBoxDefaultGraphStyle.Items.Add("SplineArea");
            comboBoxDefaultGraphStyle.Items.Add("SplineRange");
            comboBoxDefaultGraphStyle.Items.Add("StackedArea");
            comboBoxDefaultGraphStyle.Items.Add("StackedArea100");
            comboBoxDefaultGraphStyle.Items.Add("StackedBar");
            comboBoxDefaultGraphStyle.Items.Add("StackedBar100");
            comboBoxDefaultGraphStyle.Items.Add("StackedColumn");
            comboBoxDefaultGraphStyle.Items.Add("StackedColumn100");
            comboBoxDefaultGraphStyle.Items.Add("StepLine");
            comboBoxDefaultGraphStyle.Items.Add("Stock");
            comboBoxDefaultGraphStyle.Items.Add("ThreeLineBreak");

            comboBoxDefaultGraphStyle.SelectedItem = ConfigurationManager.AppSettings["DefaultChartStyle"];
            // Choose....
        }

        private void buttonSaveClose_Click(object sender, EventArgs e)
        {
            // Save Settings
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["DefaultAgencyId"].Value = comboBoxDefaultAgency.SelectedValue.ToString();
            config.AppSettings.Settings["DefaultChartStyle"].Value = comboBoxDefaultGraphStyle.SelectedItem.ToString();
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

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
