﻿using System;
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
    public partial class LapHoaDonDangKy : UserControl
    {
        private MainForm mainForm;

        public LapHoaDonDangKy(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
        }
    }
}
