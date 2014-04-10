﻿using System;
using System.Windows.Forms;

namespace SS.Ynote.Classic.Features.RunScript
{
    public partial class NewRun : Form
    {
        public RunConfiguration Configuration { get; set; }
        public NewRun()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Filter = "Executables (*.exe), (*.bat), (*.cmd)|*.exe;*.bat;*.cmd";
                dlg.ShowDialog();
                if (dlg.FileName != null) tbProcess.Text = dlg.FileName;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var configuration = new RunConfiguration();
            configuration.EditConfig(tbName.Text, tbProcess.Text, tbArgs.Text,
                tbCmdDir.Text);
            Configuration = configuration;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
