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
    public partial class CreateRegisterFormControl : UserControl
    {
        private MainForm mainForm;

        public CreateRegisterFormControl(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;

            // Đặt ngôn ngữ mặc định là tiếng Việt
            CultureInfo vietnameseCulture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = vietnameseCulture;
            Thread.CurrentThread.CurrentUICulture = vietnameseCulture;
        }

    }
}
