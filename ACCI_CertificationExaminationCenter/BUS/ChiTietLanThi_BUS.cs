﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACCI_CertificationExaminationCenter.DAO;

namespace ACCI_CertificationExaminationCenter.BUS
{
    internal class ChiTietLanThi_BUS
    {
        private string SoBaoDanh { get; set; }
        private string HoTen { get; set; }
        private string GioiTinh { get; set; }
        private string SoDT { get; set; }
        private DateOnly NgayThi { get; set; }
        private TimeOnly ThoiGianThi { get; set; }
        private string LoaiDanhGia { get; set; }
        private string TrangThai { get; set; }

        public static DataTable LayTTChiTietLanThi(string SoBaoDanh)
        {
            DataTable dt = new DataTable();
            ChiTietLanThi_DAO dao = new ChiTietLanThi_DAO();
            dao.Connect();
            dt =  dao.LayTTChiTietLanThi(SoBaoDanh);
            dao.Disconnect();
            return dt;
        }
    }
}
