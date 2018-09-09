namespace Russell
{
    partial class FormOptions
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
            this.groupBoxGeneral = new System.Windows.Forms.GroupBox();
            this.buttonAddAgency = new System.Windows.Forms.Button();
            this.labelDeafaultGraphStyle = new System.Windows.Forms.Label();
            this.comboBoxDefaultGraphStyle = new System.Windows.Forms.ComboBox();
            this.comboBoxDefaultAgency = new System.Windows.Forms.ComboBox();
            this.labelDefaultAgency = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSaveClose = new System.Windows.Forms.Button();
            this.groupBoxGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxGeneral
            // 
            this.groupBoxGeneral.Controls.Add(this.buttonAddAgency);
            this.groupBoxGeneral.Controls.Add(this.labelDeafaultGraphStyle);
            this.groupBoxGeneral.Controls.Add(this.comboBoxDefaultGraphStyle);
            this.groupBoxGeneral.Controls.Add(this.comboBoxDefaultAgency);
            this.groupBoxGeneral.Controls.Add(this.labelDefaultAgency);
            this.groupBoxGeneral.Location = new System.Drawing.Point(17, 16);
            this.groupBoxGeneral.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxGeneral.Name = "groupBoxGeneral";
            this.groupBoxGeneral.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxGeneral.Size = new System.Drawing.Size(585, 314);
            this.groupBoxGeneral.TabIndex = 0;
            this.groupBoxGeneral.TabStop = false;
            this.groupBoxGeneral.Text = "General";
            // 
            // buttonAddAgency
            // 
            this.buttonAddAgency.Location = new System.Drawing.Point(485, 49);
            this.buttonAddAgency.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddAgency.Name = "buttonAddAgency";
            this.buttonAddAgency.Size = new System.Drawing.Size(71, 28);
            this.buttonAddAgency.TabIndex = 4;
            this.buttonAddAgency.Text = "New";
            this.buttonAddAgency.UseVisualStyleBackColor = true;
            // 
            // labelDeafaultGraphStyle
            // 
            this.labelDeafaultGraphStyle.AutoSize = true;
            this.labelDeafaultGraphStyle.Location = new System.Drawing.Point(25, 110);
            this.labelDeafaultGraphStyle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDeafaultGraphStyle.Name = "labelDeafaultGraphStyle";
            this.labelDeafaultGraphStyle.Size = new System.Drawing.Size(136, 17);
            this.labelDeafaultGraphStyle.TabIndex = 3;
            this.labelDeafaultGraphStyle.Text = "Default Graph Style:";
            // 
            // comboBoxDefaultGraphStyle
            // 
            this.comboBoxDefaultGraphStyle.FormattingEnabled = true;
            this.comboBoxDefaultGraphStyle.Location = new System.Drawing.Point(197, 110);
            this.comboBoxDefaultGraphStyle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxDefaultGraphStyle.Name = "comboBoxDefaultGraphStyle";
            this.comboBoxDefaultGraphStyle.Size = new System.Drawing.Size(243, 24);
            this.comboBoxDefaultGraphStyle.TabIndex = 2;
            // 
            // comboBoxDefaultAgency
            // 
            this.comboBoxDefaultAgency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDefaultAgency.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxDefaultAgency.FormattingEnabled = true;
            this.comboBoxDefaultAgency.Location = new System.Drawing.Point(197, 49);
            this.comboBoxDefaultAgency.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxDefaultAgency.Name = "comboBoxDefaultAgency";
            this.comboBoxDefaultAgency.Size = new System.Drawing.Size(243, 24);
            this.comboBoxDefaultAgency.TabIndex = 1;
            // 
            // labelDefaultAgency
            // 
            this.labelDefaultAgency.AutoSize = true;
            this.labelDefaultAgency.Location = new System.Drawing.Point(21, 49);
            this.labelDefaultAgency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDefaultAgency.Name = "labelDefaultAgency";
            this.labelDefaultAgency.Size = new System.Drawing.Size(108, 17);
            this.labelDefaultAgency.TabIndex = 0;
            this.labelDefaultAgency.Text = "Default Agency:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(348, 348);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(111, 28);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click_1);
            // 
            // buttonSaveClose
            // 
            this.buttonSaveClose.Location = new System.Drawing.Point(503, 348);
            this.buttonSaveClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSaveClose.Name = "buttonSaveClose";
            this.buttonSaveClose.Size = new System.Drawing.Size(100, 28);
            this.buttonSaveClose.TabIndex = 2;
            this.buttonSaveClose.Text = "Save && Close";
            this.buttonSaveClose.UseVisualStyleBackColor = true;
            this.buttonSaveClose.Click += new System.EventHandler(this.buttonSaveClose_Click);
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 391);
            this.Controls.Add(this.buttonSaveClose);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBoxGeneral);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormOptions";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormOptions_Load);
            this.groupBoxGeneral.ResumeLayout(false);
            this.groupBoxGeneral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGeneral;
        private System.Windows.Forms.Label labelDeafaultGraphStyle;
        private System.Windows.Forms.ComboBox comboBoxDefaultGraphStyle;
        private System.Windows.Forms.ComboBox comboBoxDefaultAgency;
        private System.Windows.Forms.Label labelDefaultAgency;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSaveClose;
        private System.Windows.Forms.Button buttonAddAgency;
    }
}