using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACCI_CertificationExaminationCenter
{
    public partial class ExamineeResultsControl : UserControl
    {
        private MainForm mainForm;

        public ExamineeResultsControl(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
            result_guna2ShadowPanel.Visible = false;
        }

        private void insert_result_button_Click(object sender, EventArgs e)
        {
            result_guna2ShadowPanel.Visible = true;
        }
    }
}
