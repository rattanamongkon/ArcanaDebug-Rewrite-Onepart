using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace rewrite_one_part_Arcanabug_v4
{
    public partial class ProgressDlg : Form
    {
        public ProgressDlg()
        {
            InitializeComponent();
        }

        public string Message
        {
            set { this.lblProgress.Text = value; }
        }

        public int ProgressValue
        {
            set { this.progressStatus.Value = value; }
        }

        public EventHandler stopProgress;

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            if (stopProgress != null)
            {
                stopProgress(sender, e);
            }
        }
    }
}
