using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACCI_CertificationExaminationCenter
{
    public partial class RegisterDetailsFormControl : UserControl
    {
        private MainForm mainForm;

        public RegisterDetailsFormControl(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            CultureInfo vietnameseCulture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = vietnameseCulture;
            Thread.CurrentThread.CurrentUICulture = vietnameseCulture;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
