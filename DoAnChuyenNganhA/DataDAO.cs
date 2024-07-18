using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace DoAnChuyenNganhA
{
    class DataDAO
    {
        string strCon = ConfigurationManager.ConnectionStrings["strCon"].ConnectionString;
        public List<Data> SelectAllBIDV()
        {
            List<Data> BIDV = new List<Data>();
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string strCom = "select * from BIDV";
            SqlCommand com = new SqlCommand(strCom, con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Data bidv = new Data()
                {
                    Nam = (string)dr["Nam"],
                    Quy = (string)dr["Quy"],
                    ThuNhapLaiRong = (string)dr["ThuNhapLaiRong"],
                    ThuNhapLaiVaCacKhoanThuNhap = (string)dr["ThuNhapLaiVaCacKhoanThuNhap"],
                    ChiPhiLaiVaKhoanChiPhiTuongTu = (string)dr["ChiPhiLaiVaKhoanChiPhiTuongTu"],
                    LaiLoRongTuHDDichVu = (string)dr["LaiLoRongTuHDDichVu"],
                    ThuNhapTuDV = (string)dr["ThuNhapTuDV"],
                    ChiPhiHoatDongDichVu = (string)dr["ChiPhiHoatDongDichVu"],
                    LaiLoTuKDNgoaiHoi = (string)dr["LaiLoTuKDNgoaiHoi"],
                    LaiLoTuMuaChungKhoanKD = (string)dr["LaiLoTuMuaChungKhoanKD"],
                    LaiLoThuanTuMuaBanChungKhoanDauTu = (string)dr["LaiLoThuanTuMuaBanChungKhoanDauTu"],
                    LaiTuHoatDongKhac = (string)dr["LaiTuHoatDongKhac"],
                    ThuNhapHDKhac = (string)dr["ThuNhapHDKhac"],
                    ChiPhiHoatDongKhac = (string)dr["ChiPhiHoatDongKhac"],
                    ThuNhapTuGopVon = (string)dr["ThuNhapTuGopVon"],
                    TongThuNhapKD = (string)dr["TongThuNhapKD"],
                    LaiLoCongTyLienKetLienDoanh = (string)dr["LaiLoCongTyLienKetLienDoanh"],
                    ChiPhiHoatDong = (string)dr["ChiPhiHoatDong"],
                    ChiPhiNhanVien = (string)dr["ChiPhiNhanVien"],
                    ChiPhiKhauHao = (string)dr["ChiPhiKhauHao"],
                    ChiPhiHoatDongKhac01 = (string)dr["ChiPhiHoatDongKhac01"],
                    LoiNhuanRongTuHDKinhDoanh = (string)dr["LoiNhuanRongTuHDKinhDoanh"],
                    ChiPhiDuPhong = (string)dr["ChiPhiDuPhong"],
                    ChiPhiDuPhongRuiRoTinDung = (string)dr["ChiPhiDuPhongRuiRoTinDung"],
                    KhoanXuLytheoCauTrucNganHang = (string)dr["KhoanXuLytheoCauTrucNganHang"],
                    DuPhongChungCacKhoanCamKetVaNo = (string)dr["DuPhongChungCacKhoanCamKetVaNo"],
                    DuPhongGiamGiaChungKhoan = (string)dr["DuPhongGiamGiaChungKhoan"],
                    ThuHoiNoDaXuLy = (string)dr["ThuHoiNoDaXuLy"],
                    TongLoiNhuanKeToan = (string)dr["TongLoiNhuanKeToan"],
                    ThuNhapTuCacKhoanNo = (string)dr["ThuNhapTuCacKhoanNo"],
                    LoiNhuanTuCacCTLienKet = (string)dr["LoiNhuanTuCacCTLienKet"],
                    TongLoiNhuanTruocThue = (string)dr["TongLoiNhuanTruocThue"],
                    ChiPhiThueTNDN = (string)dr["ChiPhiThueTNDN"],
                    ChiPhiThueHienThanh = (string)dr["ChiPhiThueHienThanh"],
                    ChiPhiThueHoanLai = (string)dr["ChiPhiThueHoanLai"],
                    LoiNhuanSauThue = (string)dr["LoiNhuanSauThue"],
                    LoiIchCoDongThieuSo = (string)dr["LoiIchCoDongThieuSo"],
                    LoiNhuanSauThueCoDongCTme = (string)dr["LoiNhuanSauThueCoDongCTme"],
                    LaiCoBanCoPhieu = (string)dr["LaiCoBanCoPhieu"],
                    LaiLoSuyGiamCoPhieu = (string)dr["LaiLoSuyGiamCoPhieu"]

                }; 
                BIDV.Add(bidv);
            }
            con.Close();           
            return BIDV;
        }

        public List<Data04> SelectAllBIDV02(string nam)
        {
            List<Data04> BIDV = new List<Data04>();
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string strCom = "select nam,quy,ThuNhapLaiRong,ThuNhapLaiVaCacKhoanThuNhap,ThuNhapTuDV,ThuNhapHDKhac,ThuNhapTuGopVon" +
                ",TongThuNhapKD,ThuNhapTuCacKhoanNo from BIDV where Nam like @nam";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@nam", "%" + nam + "%"));
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Data04 bidv = new Data04()
                {
                    Nam = (string)dr["Nam"],
                    Quy = (string)dr["Quy"],
                    ThuNhapLaiRong = (string)dr["ThuNhapLaiRong"],
                    ThuNhapLaiVaCacKhoanThuNhap = (string)dr["ThuNhapLaiVaCacKhoanThuNhap"],
                    ThuNhapTuDV = (string)dr["ThuNhapTuDV"],                   
                    ThuNhapHDKhac = (string)dr["ThuNhapHDKhac"],                  
                    ThuNhapTuGopVon = (string)dr["ThuNhapTuGopVon"],
                    TongThuNhapKD = (string)dr["TongThuNhapKD"],                                     
                    ThuNhapTuCacKhoanNo = (string)dr["ThuNhapTuCacKhoanNo"],                   
                };
                BIDV.Add(bidv);
            }
            con.Close();
            return BIDV;
        }

        public List<Data04> SelectAllFPT02(string nam)
        {
            List<Data04> BIDV = new List<Data04>();
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string strCom = "select nam,quy,ThuNhapLaiRong,ThuNhapLaiVaCacKhoanThuNhap,ThuNhapTuDV,ThuNhapHDKhac,ThuNhapTuGopVon" +
                ",TongThuNhapKD,ThuNhapTuCacKhoanNo from FPT where Nam like @nam";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@nam", "%" + nam + "%"));
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Data04 bidv = new Data04()
                {
                    Nam = (string)dr["Nam"],
                    Quy = (string)dr["Quy"],
                    ThuNhapLaiRong = (string)dr["ThuNhapLaiRong"],
                    ThuNhapLaiVaCacKhoanThuNhap = (string)dr["ThuNhapLaiVaCacKhoanThuNhap"],
                    ThuNhapTuDV = (string)dr["ThuNhapTuDV"],
                    ThuNhapHDKhac = (string)dr["ThuNhapHDKhac"],
                    ThuNhapTuGopVon = (string)dr["ThuNhapTuGopVon"],
                    TongThuNhapKD = (string)dr["TongThuNhapKD"],
                    ThuNhapTuCacKhoanNo = (string)dr["ThuNhapTuCacKhoanNo"],
                };
                BIDV.Add(bidv);
            }
            con.Close();
            return BIDV;
        }

        public List<Data04> SelectAllMB_Bank02(string nam)
        {
            List<Data04> BIDV = new List<Data04>();
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string strCom = "select nam,quy,ThuNhapLaiRong,ThuNhapLaiVaCacKhoanThuNhap,ThuNhapTuDV,ThuNhapHDKhac,ThuNhapTuGopVon" +
                ",TongThuNhapKD,ThuNhapTuCacKhoanNo from MB_Bank where Nam like @nam";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@nam", "%" + nam + "%"));
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Data04 bidv = new Data04()
                {
                    Nam = (string)dr["Nam"],
                    Quy = (string)dr["Quy"],
                    ThuNhapLaiRong = (string)dr["ThuNhapLaiRong"],
                    ThuNhapLaiVaCacKhoanThuNhap = (string)dr["ThuNhapLaiVaCacKhoanThuNhap"],
                    ThuNhapTuDV = (string)dr["ThuNhapTuDV"],
                    ThuNhapHDKhac = (string)dr["ThuNhapHDKhac"],
                    ThuNhapTuGopVon = (string)dr["ThuNhapTuGopVon"],
                    TongThuNhapKD = (string)dr["TongThuNhapKD"],
                    ThuNhapTuCacKhoanNo = (string)dr["ThuNhapTuCacKhoanNo"],
                };
                BIDV.Add(bidv);
            }
            con.Close();
            return BIDV;
        }

        public List<Data04> SelectAllOCB_Bank02(string nam)
        {
            List<Data04> BIDV = new List<Data04>();
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string strCom = "select nam,quy,ThuNhapLaiRong,ThuNhapLaiVaCacKhoanThuNhap,ThuNhapTuDV,ThuNhapHDKhac,ThuNhapTuGopVon" +
                ",TongThuNhapKD,ThuNhapTuCacKhoanNo from OCB_Bank where Nam like @nam";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@nam", "%" + nam + "%"));
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Data04 bidv = new Data04()
                {
                    Nam = (string)dr["Nam"],
                    Quy = (string)dr["Quy"],
                    ThuNhapLaiRong = (string)dr["ThuNhapLaiRong"],
                    ThuNhapLaiVaCacKhoanThuNhap = (string)dr["ThuNhapLaiVaCacKhoanThuNhap"],
                    ThuNhapTuDV = (string)dr["ThuNhapTuDV"],
                    ThuNhapHDKhac = (string)dr["ThuNhapHDKhac"],
                    ThuNhapTuGopVon = (string)dr["ThuNhapTuGopVon"],
                    TongThuNhapKD = (string)dr["TongThuNhapKD"],
                    ThuNhapTuCacKhoanNo = (string)dr["ThuNhapTuCacKhoanNo"],
                };
                BIDV.Add(bidv);
            }
            con.Close();
            return BIDV;
        }

        public List<Data04> SelectAllSCB02(string nam)
        {
            List<Data04> BIDV = new List<Data04>();
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string strCom = "select nam,quy,ThuNhapLaiRong,ThuNhapLaiVaCacKhoanThuNhap,ThuNhapTuDV,ThuNhapHDKhac,ThuNhapTuGopVon" +
                ",TongThuNhapKD,ThuNhapTuCacKhoanNo from SCB where Nam like @nam";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@nam", "%" + nam + "%"));
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Data04 bidv = new Data04()
                {
                    Nam = (string)dr["Nam"],
                    Quy = (string)dr["Quy"],
                    ThuNhapLaiRong = (string)dr["ThuNhapLaiRong"],
                    ThuNhapLaiVaCacKhoanThuNhap = (string)dr["ThuNhapLaiVaCacKhoanThuNhap"],
                    ThuNhapTuDV = (string)dr["ThuNhapTuDV"],
                    ThuNhapHDKhac = (string)dr["ThuNhapHDKhac"],
                    ThuNhapTuGopVon = (string)dr["ThuNhapTuGopVon"],
                    TongThuNhapKD = (string)dr["TongThuNhapKD"],
                    ThuNhapTuCacKhoanNo = (string)dr["ThuNhapTuCacKhoanNo"],
                };
                BIDV.Add(bidv);
            }
            con.Close();
            return BIDV;
        }

        public List<Data04> SelectAllTechcom02(string nam)
        {
            List<Data04> BIDV = new List<Data04>();
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string strCom = "select nam,quy,ThuNhapLaiRong,ThuNhapLaiVaCacKhoanThuNhap,ThuNhapTuDV,ThuNhapHDKhac,ThuNhapTuGopVon" +
                ",TongThuNhapKD,ThuNhapTuCacKhoanNo from TechcomBank where Nam like @nam";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@nam", "%" + nam + "%"));
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Data04 bidv = new Data04()
                {
                    Nam = (string)dr["Nam"],
                    Quy = (string)dr["Quy"],
                    ThuNhapLaiRong = (string)dr["ThuNhapLaiRong"],
                    ThuNhapLaiVaCacKhoanThuNhap = (string)dr["ThuNhapLaiVaCacKhoanThuNhap"],
                    ThuNhapTuDV = (string)dr["ThuNhapTuDV"],
                    ThuNhapHDKhac = (string)dr["ThuNhapHDKhac"],
                    ThuNhapTuGopVon = (string)dr["ThuNhapTuGopVon"],
                    TongThuNhapKD = (string)dr["TongThuNhapKD"],
                    ThuNhapTuCacKhoanNo = (string)dr["ThuNhapTuCacKhoanNo"],
                };
                BIDV.Add(bidv);
            }
            con.Close();
            return BIDV;
        }

        public List<Data04> SelectAllVietcom_Bank02(string nam)
        {
            List<Data04> BIDV = new List<Data04>();
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string strCom = "select nam,quy,ThuNhapLaiRong,ThuNhapLaiVaCacKhoanThuNhap,ThuNhapTuDV,ThuNhapHDKhac,ThuNhapTuGopVon" +
                ",TongThuNhapKD,ThuNhapTuCacKhoanNo from VietcomBank where Nam like @nam";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@nam", "%" + nam + "%"));
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Data04 bidv = new Data04()
                {
                    Nam = (string)dr["Nam"],
                    Quy = (string)dr["Quy"],
                    ThuNhapLaiRong = (string)dr["ThuNhapLaiRong"],
                    ThuNhapLaiVaCacKhoanThuNhap = (string)dr["ThuNhapLaiVaCacKhoanThuNhap"],
                    ThuNhapTuDV = (string)dr["ThuNhapTuDV"],
                    ThuNhapHDKhac = (string)dr["ThuNhapHDKhac"],
                    ThuNhapTuGopVon = (string)dr["ThuNhapTuGopVon"],
                    TongThuNhapKD = (string)dr["TongThuNhapKD"],
                    ThuNhapTuCacKhoanNo = (string)dr["ThuNhapTuCacKhoanNo"],
                };
                BIDV.Add(bidv);
            }
            con.Close();
            return BIDV;
        }

        public List<Data04> SelectAllVietin_Bank02(string nam)
        {
            List<Data04> BIDV = new List<Data04>();
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string strCom = "select nam,quy,ThuNhapLaiRong,ThuNhapLaiVaCacKhoanThuNhap,ThuNhapTuDV,ThuNhapHDKhac,ThuNhapTuGopVon" +
                ",TongThuNhapKD,ThuNhapTuCacKhoanNo from VietinBank where Nam like @nam";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@nam", "%" + nam + "%"));
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Data04 bidv = new Data04()
                {
                    Nam = (string)dr["Nam"],
                    Quy = (string)dr["Quy"],
                    ThuNhapLaiRong = (string)dr["ThuNhapLaiRong"],
                    ThuNhapLaiVaCacKhoanThuNhap = (string)dr["ThuNhapLaiVaCacKhoanThuNhap"],
                    ThuNhapTuDV = (string)dr["ThuNhapTuDV"],
                    ThuNhapHDKhac = (string)dr["ThuNhapHDKhac"],
                    ThuNhapTuGopVon = (string)dr["ThuNhapTuGopVon"],
                    TongThuNhapKD = (string)dr["TongThuNhapKD"],
                    ThuNhapTuCacKhoanNo = (string)dr["ThuNhapTuCacKhoanNo"],
                };
                BIDV.Add(bidv);
            }
            con.Close();
            return BIDV;
        }

        public List<Data04> SelectAllVinamilk02(string nam)
        {
            List<Data04> BIDV = new List<Data04>();
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string strCom = "select nam,quy,ThuNhapLaiRong,ThuNhapLaiVaCacKhoanThuNhap,ThuNhapTuDV,ThuNhapHDKhac,ThuNhapTuGopVon" +
                ",TongThuNhapKD,ThuNhapTuCacKhoanNo from VinaMilk where Nam like @nam";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@nam", "%" + nam + "%"));
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Data04 bidv = new Data04()
                {
                    Nam = (string)dr["Nam"],
                    Quy = (string)dr["Quy"],
                    ThuNhapLaiRong = (string)dr["ThuNhapLaiRong"],
                    ThuNhapLaiVaCacKhoanThuNhap = (string)dr["ThuNhapLaiVaCacKhoanThuNhap"],
                    ThuNhapTuDV = (string)dr["ThuNhapTuDV"],
                    ThuNhapHDKhac = (string)dr["ThuNhapHDKhac"],
                    ThuNhapTuGopVon = (string)dr["ThuNhapTuGopVon"],
                    TongThuNhapKD = (string)dr["TongThuNhapKD"],
                    ThuNhapTuCacKhoanNo = (string)dr["ThuNhapTuCacKhoanNo"],
                };
                BIDV.Add(bidv);
            }
            con.Close();
            return BIDV;
        }

        public List<Data04> SelectAllVP_Bank02(string nam)
        {
            List<Data04> BIDV = new List<Data04>();
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string strCom = "select nam,quy,ThuNhapLaiRong,ThuNhapLaiVaCacKhoanThuNhap,ThuNhapTuDV,ThuNhapHDKhac,ThuNhapTuGopVon" +
                ",TongThuNhapKD,ThuNhapTuCacKhoanNo from VP_Bank where Nam like @nam";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@nam", "%" + nam + "%"));
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Data04 bidv = new Data04()
                {
                    Nam = (string)dr["Nam"],
                    Quy = (string)dr["Quy"],
                    ThuNhapLaiRong = (string)dr["ThuNhapLaiRong"],
                    ThuNhapLaiVaCacKhoanThuNhap = (string)dr["ThuNhapLaiVaCacKhoanThuNhap"],
                    ThuNhapTuDV = (string)dr["ThuNhapTuDV"],
                    ThuNhapHDKhac = (string)dr["ThuNhapHDKhac"],
                    ThuNhapTuGopVon = (string)dr["ThuNhapTuGopVon"],
                    TongThuNhapKD = (string)dr["TongThuNhapKD"],
                    ThuNhapTuCacKhoanNo = (string)dr["ThuNhapTuCacKhoanNo"],
                };
                BIDV.Add(bidv);
            }
            con.Close();
            return BIDV;
        }

        public List<Data> SelectAllFPT()
        {
            List<Data> BIDV = new List<Data>();
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string strCom = "select * from FPT";
            SqlCommand com = new SqlCommand(strCom, con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Data bidv = new Data()
                {
                    Nam = (string)dr["Nam"],
                    Quy = (string)dr["Quy"],
                    ThuNhapLaiRong = (string)dr["ThuNhapLaiRong"],
                    ThuNhapLaiVaCacKhoanThuNhap = (string)dr["ThuNhapLaiVaCacKhoanThuNhap"],
                    ChiPhiLaiVaKhoanChiPhiTuongTu = (string)dr["ChiPhiLaiVaKhoanChiPhiTuongTu"],
                    LaiLoRongTuHDDichVu = (string)dr["LaiLoRongTuHDDichVu"],
                    ThuNhapTuDV = (string)dr["ThuNhapTuDV"],
                    ChiPhiHoatDongDichVu = (string)dr["ChiPhiHoatDongDichVu"],
                    LaiLoTuKDNgoaiHoi = (string)dr["LaiLoTuKDNgoaiHoi"],
                    LaiLoTuMuaChungKhoanKD = (string)dr["LaiLoTuMuaChungKhoanKD"],
                    LaiLoThuanTuMuaBanChungKhoanDauTu = (string)dr["LaiLoThuanTuMuaBanChungKhoanDauTu"],
                    LaiTuHoatDongKhac = (string)dr["LaiTuHoatDongKhac"],
                    ThuNhapHDKhac = (string)dr["ThuNhapHDKhac"],
                    ChiPhiHoatDongKhac = (string)dr["ChiPhiHoatDongKhac"],
                    ThuNhapTuGopVon = (string)dr["ThuNhapTuGopVon"],
                    TongThuNhapKD = (string)dr["TongThuNhapKD"],
                    LaiLoCongTyLienKetLienDoanh = (string)dr["LaiLoCongTyLienKetLienDoanh"],
                    ChiPhiHoatDong = (string)dr["ChiPhiHoatDong"],
                    ChiPhiNhanVien = (string)dr["ChiPhiNhanVien"],
                    ChiPhiKhauHao = (string)dr["ChiPhiKhauHao"],
                    ChiPhiHoatDongKhac01 = (string)dr["ChiPhiHoatDongKhac01"],
                    LoiNhuanRongTuHDKinhDoanh = (string)dr["LoiNhuanRongTuHDKinhDoanh"],
                    ChiPhiDuPhong = (string)dr["ChiPhiDuPhong"],
                    ChiPhiDuPhongRuiRoTinDung = (string)dr["ChiPhiDuPhongRuiRoTinDung"],
                    KhoanXuLytheoCauTrucNganHang = (string)dr["KhoanXuLytheoCauTrucNganHang"],
                    DuPhongChungCacKhoanCamKetVaNo = (string)dr["DuPhongChungCacKhoanCamKetVaNo"],
                    DuPhongGiamGiaChungKhoan = (string)dr["DuPhongGiamGiaChungKhoan"],
                    ThuHoiNoDaXuLy = (string)dr["ThuHoiNoDaXuLy"],
                    TongLoiNhuanKeToan = (string)dr["TongLoiNhuanKeToan"],
                    ThuNhapTuCacKhoanNo = (string)dr["ThuNhapTuCacKhoanNo"],
                    LoiNhuanTuCacCTLienKet = (string)dr["LoiNhuanTuCacCTLienKet"],
                    TongLoiNhuanTruocThue = (string)dr["TongLoiNhuanTruocThue"],
                    ChiPhiThueTNDN = (string)dr["ChiPhiThueTNDN"],
                    ChiPhiThueHienThanh = (string)dr["ChiPhiThueHienThanh"],
                    ChiPhiThueHoanLai = (string)dr["ChiPhiThueHoanLai"],
                    LoiNhuanSauThue = (string)dr["LoiNhuanSauThue"],
                    LoiIchCoDongThieuSo = (string)dr["LoiIchCoDongThieuSo"],
                    LoiNhuanSauThueCoDongCTme = (string)dr["LoiNhuanSauThueCoDongCTme"],
                    LaiCoBanCoPhieu = (string)dr["LaiCoBanCoPhieu"],
                    LaiLoSuyGiamCoPhieu = (string)dr["LaiLoSuyGiamCoPhieu"]

                };
                BIDV.Add(bidv);
            }
            con.Close();
            return BIDV;
        }

        public List<Data> SelectAllMB_Bank()
        {
            List<Data> BIDV = new List<Data>();
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string strCom = "select * from MB_Bank";
            SqlCommand com = new SqlCommand(strCom, con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Data bidv = new Data()
                {
                    Nam = (string)dr["Nam"],
                    Quy = (string)dr["Quy"],
                    ThuNhapLaiRong = (string)dr["ThuNhapLaiRong"],
                    ThuNhapLaiVaCacKhoanThuNhap = (string)dr["ThuNhapLaiVaCacKhoanThuNhap"],
                    ChiPhiLaiVaKhoanChiPhiTuongTu = (string)dr["ChiPhiLaiVaKhoanChiPhiTuongTu"],
                    LaiLoRongTuHDDichVu = (string)dr["LaiLoRongTuHDDichVu"],
                    ThuNhapTuDV = (string)dr["ThuNhapTuDV"],
                    ChiPhiHoatDongDichVu = (string)dr["ChiPhiHoatDongDichVu"],
                    LaiLoTuKDNgoaiHoi = (string)dr["LaiLoTuKDNgoaiHoi"],
                    LaiLoTuMuaChungKhoanKD = (string)dr["LaiLoTuMuaChungKhoanKD"],
                    LaiLoThuanTuMuaBanChungKhoanDauTu = (string)dr["LaiLoThuanTuMuaBanChungKhoanDauTu"],
                    LaiTuHoatDongKhac = (string)dr["LaiTuHoatDongKhac"],
                    ThuNhapHDKhac = (string)dr["ThuNhapHDKhac"],
                    ChiPhiHoatDongKhac = (string)dr["ChiPhiHoatDongKhac"],
                    ThuNhapTuGopVon = (string)dr["ThuNhapTuGopVon"],
                    TongThuNhapKD = (string)dr["TongThuNhapKD"],
                    LaiLoCongTyLienKetLienDoanh = (string)dr["LaiLoCongTyLienKetLienDoanh"],
                    ChiPhiHoatDong = (string)dr["ChiPhiHoatDong"],
                    ChiPhiNhanVien = (string)dr["ChiPhiNhanVien"],
                    ChiPhiKhauHao = (string)dr["ChiPhiKhauHao"],
                    ChiPhiHoatDongKhac01 = (string)dr["ChiPhiHoatDongKhac01"],
                    LoiNhuanRongTuHDKinhDoanh = (string)dr["LoiNhuanRongTuHDKinhDoanh"],
                    ChiPhiDuPhong = (string)dr["ChiPhiDuPhong"],
                    ChiPhiDuPhongRuiRoTinDung = (string)dr["ChiPhiDuPhongRuiRoTinDung"],
                    KhoanXuLytheoCauTrucNganHang = (string)dr["KhoanXuLytheoCauTrucNganHang"],
                    DuPhongChungCacKhoanCamKetVaNo = (string)dr["DuPhongChungCacKhoanCamKetVaNo"],
                    DuPhongGiamGiaChungKhoan = (string)dr["DuPhongGiamGiaChungKhoan"],
                    ThuHoiNoDaXuLy = (string)dr["ThuHoiNoDaXuLy"],
                    TongLoiNhuanKeToan = (string)dr["TongLoiNhuanKeToan"],
                    ThuNhapTuCacKhoanNo = (string)dr["ThuNhapTuCacKhoanNo"],
                    LoiNhuanTuCacCTLienKet = (string)dr["LoiNhuanTuCacCTLienKet"],
                    TongLoiNhuanTruocThue = (string)dr["TongLoiNhuanTruocThue"],
                    ChiPhiThueTNDN = (string)dr["ChiPhiThueTNDN"],
                    ChiPhiThueHienThanh = (string)dr["ChiPhiThueHienThanh"],
                    ChiPhiThueHoanLai = (string)dr["ChiPhiThueHoanLai"],
                    LoiNhuanSauThue = (string)dr["LoiNhuanSauThue"],
                    LoiIchCoDongThieuSo = (string)dr["LoiIchCoDongThieuSo"],
                    LoiNhuanSauThueCoDongCTme = (string)dr["LoiNhuanSauThueCoDongCTme"],
                    LaiCoBanCoPhieu = (string)dr["LaiCoBanCoPhieu"],
                    LaiLoSuyGiamCoPhieu = (string)dr["LaiLoSuyGiamCoPhieu"]

                };
                BIDV.Add(bidv);
            }
            con.Close();
            return BIDV;
        }

        public List<Data> SelectAllOCB_Bank()
        {
            List<Data> BIDV = new List<Data>();
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string strCom = "select * from OCB_Bank";
            SqlCommand com = new SqlCommand(strCom, con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Data bidv = new Data()
                {
                    Nam = (string)dr["Nam"],
                    Quy = (string)dr["Quy"],
                    ThuNhapLaiRong = (string)dr["ThuNhapLaiRong"],
                    ThuNhapLaiVaCacKhoanThuNhap = (string)dr["ThuNhapLaiVaCacKhoanThuNhap"],
                    ChiPhiLaiVaKhoanChiPhiTuongTu = (string)dr["ChiPhiLaiVaKhoanChiPhiTuongTu"],
                    LaiLoRongTuHDDichVu = (string)dr["LaiLoRongTuHDDichVu"],
                    ThuNhapTuDV = (string)dr["ThuNhapTuDV"],
                    ChiPhiHoatDongDichVu = (string)dr["ChiPhiHoatDongDichVu"],
                    LaiLoTuKDNgoaiHoi = (string)dr["LaiLoTuKDNgoaiHoi"],
                    LaiLoTuMuaChungKhoanKD = (string)dr["LaiLoTuMuaChungKhoanKD"],
                    LaiLoThuanTuMuaBanChungKhoanDauTu = (string)dr["LaiLoThuanTuMuaBanChungKhoanDauTu"],
                    LaiTuHoatDongKhac = (string)dr["LaiTuHoatDongKhac"],
                    ThuNhapHDKhac = (string)dr["ThuNhapHDKhac"],
                    ChiPhiHoatDongKhac = (string)dr["ChiPhiHoatDongKhac"],
                    ThuNhapTuGopVon = (string)dr["ThuNhapTuGopVon"],
                    TongThuNhapKD = (string)dr["TongThuNhapKD"],
                    LaiLoCongTyLienKetLienDoanh = (string)dr["LaiLoCongTyLienKetLienDoanh"],
                    ChiPhiHoatDong = (string)dr["ChiPhiHoatDong"],
                    ChiPhiNhanVien = (string)dr["ChiPhiNhanVien"],
                    ChiPhiKhauHao = (string)dr["ChiPhiKhauHao"],
                    ChiPhiHoatDongKhac01 = (string)dr["ChiPhiHoatDongKhac01"],
                    LoiNhuanRongTuHDKinhDoanh = (string)dr["LoiNhuanRongTuHDKinhDoanh"],
                    ChiPhiDuPhong = (string)dr["ChiPhiDuPhong"],
                    ChiPhiDuPhongRuiRoTinDung = (string)dr["ChiPhiDuPhongRuiRoTinDung"],
                    KhoanXuLytheoCauTrucNganHang = (string)dr["KhoanXuLytheoCauTrucNganHang"],
                    DuPhongChungCacKhoanCamKetVaNo = (string)dr["DuPhongChungCacKhoanCamKetVaNo"],
                    DuPhongGiamGiaChungKhoan = (string)dr["DuPhongGiamGiaChungKhoan"],
                    ThuHoiNoDaXuLy = (string)dr["ThuHoiNoDaXuLy"],
                    TongLoiNhuanKeToan = (string)dr["TongLoiNhuanKeToan"],
                    ThuNhapTuCacKhoanNo = (string)dr["ThuNhapTuCacKhoanNo"],
                    LoiNhuanTuCacCTLienKet = (string)dr["LoiNhuanTuCacCTLienKet"],
                    TongLoiNhuanTruocThue = (string)dr["TongLoiNhuanTruocThue"],
                    ChiPhiThueTNDN = (string)dr["ChiPhiThueTNDN"],
                    ChiPhiThueHienThanh = (string)dr["ChiPhiThueHienThanh"],
                    ChiPhiThueHoanLai = (string)dr["ChiPhiThueHoanLai"],
                    LoiNhuanSauThue = (string)dr["LoiNhuanSauThue"],
                    LoiIchCoDongThieuSo = (string)dr["LoiIchCoDongThieuSo"],
                    LoiNhuanSauThueCoDongCTme = (string)dr["LoiNhuanSauThueCoDongCTme"],
                    LaiCoBanCoPhieu = (string)dr["LaiCoBanCoPhieu"],
                    LaiLoSuyGiamCoPhieu = (string)dr["LaiLoSuyGiamCoPhieu"]

                };
                BIDV.Add(bidv);
            }
            con.Close();
            return BIDV;
        }

        public List<Data> SelectAllSCB()
        {
            List<Data> BIDV = new List<Data>();
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string strCom = "select * from SCB";
            SqlCommand com = new SqlCommand(strCom, con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Data bidv = new Data()
                {
                    Nam = (string)dr["Nam"],
                    Quy = (string)dr["Quy"],
                    ThuNhapLaiRong = (string)dr["ThuNhapLaiRong"],
                    ThuNhapLaiVaCacKhoanThuNhap = (string)dr["ThuNhapLaiVaCacKhoanThuNhap"],
                    ChiPhiLaiVaKhoanChiPhiTuongTu = (string)dr["ChiPhiLaiVaKhoanChiPhiTuongTu"],
                    LaiLoRongTuHDDichVu = (string)dr["LaiLoRongTuHDDichVu"],
                    ThuNhapTuDV = (string)dr["ThuNhapTuDV"],
                    ChiPhiHoatDongDichVu = (string)dr["ChiPhiHoatDongDichVu"],
                    LaiLoTuKDNgoaiHoi = (string)dr["LaiLoTuKDNgoaiHoi"],
                    LaiLoTuMuaChungKhoanKD = (string)dr["LaiLoTuMuaChungKhoanKD"],
                    LaiLoThuanTuMuaBanChungKhoanDauTu = (string)dr["LaiLoThuanTuMuaBanChungKhoanDauTu"],
                    LaiTuHoatDongKhac = (string)dr["LaiTuHoatDongKhac"],
                    ThuNhapHDKhac = (string)dr["ThuNhapHDKhac"],
                    ChiPhiHoatDongKhac = (string)dr["ChiPhiHoatDongKhac"],
                    ThuNhapTuGopVon = (string)dr["ThuNhapTuGopVon"],
                    TongThuNhapKD = (string)dr["TongThuNhapKD"],
                    LaiLoCongTyLienKetLienDoanh = (string)dr["LaiLoCongTyLienKetLienDoanh"],
                    ChiPhiHoatDong = (string)dr["ChiPhiHoatDong"],
                    ChiPhiNhanVien = (string)dr["ChiPhiNhanVien"],
                    ChiPhiKhauHao = (string)dr["ChiPhiKhauHao"],
                    ChiPhiHoatDongKhac01 = (string)dr["ChiPhiHoatDongKhac01"],
                    LoiNhuanRongTuHDKinhDoanh = (string)dr["LoiNhuanRongTuHDKinhDoanh"],
                    ChiPhiDuPhong = (string)dr["ChiPhiDuPhong"],
                    ChiPhiDuPhongRuiRoTinDung = (string)dr["ChiPhiDuPhongRuiRoTinDung"],
                    KhoanXuLytheoCauTrucNganHang = (string)dr["KhoanXuLytheoCauTrucNganHang"],
                    DuPhongChungCacKhoanCamKetVaNo = (string)dr["DuPhongChungCacKhoanCamKetVaNo"],
                    DuPhongGiamGiaChungKhoan = (string)dr["DuPhongGiamGiaChungKhoan"],
                    ThuHoiNoDaXuLy = (string)dr["ThuHoiNoDaXuLy"],
                    TongLoiNhuanKeToan = (string)dr["TongLoiNhuanKeToan"],
                    ThuNhapTuCacKhoanNo = (string)dr["ThuNhapTuCacKhoanNo"],
                    LoiNhuanTuCacCTLienKet = (string)dr["LoiNhuanTuCacCTLienKet"],
                    TongLoiNhuanTruocThue = (string)dr["TongLoiNhuanTruocThue"],
                    ChiPhiThueTNDN = (string)dr["ChiPhiThueTNDN"],
                    ChiPhiThueHienThanh = (string)dr["ChiPhiThueHienThanh"],
                    ChiPhiThueHoanLai = (string)dr["ChiPhiThueHoanLai"],
                    LoiNhuanSauThue = (string)dr["LoiNhuanSauThue"],
                    LoiIchCoDongThieuSo = (string)dr["LoiIchCoDongThieuSo"],
                    LoiNhuanSauThueCoDongCTme = (string)dr["LoiNhuanSauThueCoDongCTme"],
                    LaiCoBanCoPhieu = (string)dr["LaiCoBanCoPhieu"],
                    LaiLoSuyGiamCoPhieu = (string)dr["LaiLoSuyGiamCoPhieu"]

                };
                BIDV.Add(bidv);
            }
            con.Close();
            return BIDV;
        }

        public List<Data> SelectAllTechcom_bank()
        {
            List<Data> BIDV = new List<Data>();
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string strCom = "select * from TechcomBank";
            SqlCommand com = new SqlCommand(strCom, con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Data bidv = new Data()
                {
                    Nam = (string)dr["Nam"],
                    Quy = (string)dr["Quy"],
                    ThuNhapLaiRong = (string)dr["ThuNhapLaiRong"],
                    ThuNhapLaiVaCacKhoanThuNhap = (string)dr["ThuNhapLaiVaCacKhoanThuNhap"],
                    ChiPhiLaiVaKhoanChiPhiTuongTu = (string)dr["ChiPhiLaiVaKhoanChiPhiTuongTu"],
                    LaiLoRongTuHDDichVu = (string)dr["LaiLoRongTuHDDichVu"],
                    ThuNhapTuDV = (string)dr["ThuNhapTuDV"],
                    ChiPhiHoatDongDichVu = (string)dr["ChiPhiHoatDongDichVu"],
                    LaiLoTuKDNgoaiHoi = (string)dr["LaiLoTuKDNgoaiHoi"],
                    LaiLoTuMuaChungKhoanKD = (string)dr["LaiLoTuMuaChungKhoanKD"],
                    LaiLoThuanTuMuaBanChungKhoanDauTu = (string)dr["LaiLoThuanTuMuaBanChungKhoanDauTu"],
                    LaiTuHoatDongKhac = (string)dr["LaiTuHoatDongKhac"],
                    ThuNhapHDKhac = (string)dr["ThuNhapHDKhac"],
                    ChiPhiHoatDongKhac = (string)dr["ChiPhiHoatDongKhac"],
                    ThuNhapTuGopVon = (string)dr["ThuNhapTuGopVon"],
                    TongThuNhapKD = (string)dr["TongThuNhapKD"],
                    LaiLoCongTyLienKetLienDoanh = (string)dr["LaiLoCongTyLienKetLienDoanh"],
                    ChiPhiHoatDong = (string)dr["ChiPhiHoatDong"],
                    ChiPhiNhanVien = (string)dr["ChiPhiNhanVien"],
                    ChiPhiKhauHao = (string)dr["ChiPhiKhauHao"],
                    ChiPhiHoatDongKhac01 = (string)dr["ChiPhiHoatDongKhac01"],
                    LoiNhuanRongTuHDKinhDoanh = (string)dr["LoiNhuanRongTuHDKinhDoanh"],
                    ChiPhiDuPhong = (string)dr["ChiPhiDuPhong"],
                    ChiPhiDuPhongRuiRoTinDung = (string)dr["ChiPhiDuPhongRuiRoTinDung"],
                    KhoanXuLytheoCauTrucNganHang = (string)dr["KhoanXuLytheoCauTrucNganHang"],
                    DuPhongChungCacKhoanCamKetVaNo = (string)dr["DuPhongChungCacKhoanCamKetVaNo"],
                    DuPhongGiamGiaChungKhoan = (string)dr["DuPhongGiamGiaChungKhoan"],
                    ThuHoiNoDaXuLy = (string)dr["ThuHoiNoDaXuLy"],
                    TongLoiNhuanKeToan = (string)dr["TongLoiNhuanKeToan"],
                    ThuNhapTuCacKhoanNo = (string)dr["ThuNhapTuCacKhoanNo"],
                    LoiNhuanTuCacCTLienKet = (string)dr["LoiNhuanTuCacCTLienKet"],
                    TongLoiNhuanTruocThue = (string)dr["TongLoiNhuanTruocThue"],
                    ChiPhiThueTNDN = (string)dr["ChiPhiThueTNDN"],
                    ChiPhiThueHienThanh = (string)dr["ChiPhiThueHienThanh"],
                    ChiPhiThueHoanLai = (string)dr["ChiPhiThueHoanLai"],
                    LoiNhuanSauThue = (string)dr["LoiNhuanSauThue"],
                    LoiIchCoDongThieuSo = (string)dr["LoiIchCoDongThieuSo"],
                    LoiNhuanSauThueCoDongCTme = (string)dr["LoiNhuanSauThueCoDongCTme"],
                    LaiCoBanCoPhieu = (string)dr["LaiCoBanCoPhieu"],
                    LaiLoSuyGiamCoPhieu = (string)dr["LaiLoSuyGiamCoPhieu"]

                };
                BIDV.Add(bidv);
            }
            con.Close();
            return BIDV;
        }

        public List<Data> SelectAllVietcom_Bank()
        {
            List<Data> BIDV = new List<Data>();
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string strCom = "select * from VietcomBank";
            SqlCommand com = new SqlCommand(strCom, con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Data bidv = new Data()
                {
                    Nam = (string)dr["Nam"],
                    Quy = (string)dr["Quy"],
                    ThuNhapLaiRong = (string)dr["ThuNhapLaiRong"],
                    ThuNhapLaiVaCacKhoanThuNhap = (string)dr["ThuNhapLaiVaCacKhoanThuNhap"],
                    ChiPhiLaiVaKhoanChiPhiTuongTu = (string)dr["ChiPhiLaiVaKhoanChiPhiTuongTu"],
                    LaiLoRongTuHDDichVu = (string)dr["LaiLoRongTuHDDichVu"],
                    ThuNhapTuDV = (string)dr["ThuNhapTuDV"],
                    ChiPhiHoatDongDichVu = (string)dr["ChiPhiHoatDongDichVu"],
                    LaiLoTuKDNgoaiHoi = (string)dr["LaiLoTuKDNgoaiHoi"],
                    LaiLoTuMuaChungKhoanKD = (string)dr["LaiLoTuMuaChungKhoanKD"],
                    LaiLoThuanTuMuaBanChungKhoanDauTu = (string)dr["LaiLoThuanTuMuaBanChungKhoanDauTu"],
                    LaiTuHoatDongKhac = (string)dr["LaiTuHoatDongKhac"],
                    ThuNhapHDKhac = (string)dr["ThuNhapHDKhac"],
                    ChiPhiHoatDongKhac = (string)dr["ChiPhiHoatDongKhac"],
                    ThuNhapTuGopVon = (string)dr["ThuNhapTuGopVon"],
                    TongThuNhapKD = (string)dr["TongThuNhapKD"],
                    LaiLoCongTyLienKetLienDoanh = (string)dr["LaiLoCongTyLienKetLienDoanh"],
                    ChiPhiHoatDong = (string)dr["ChiPhiHoatDong"],
                    ChiPhiNhanVien = (string)dr["ChiPhiNhanVien"],
                    ChiPhiKhauHao = (string)dr["ChiPhiKhauHao"],
                    ChiPhiHoatDongKhac01 = (string)dr["ChiPhiHoatDongKhac01"],
                    LoiNhuanRongTuHDKinhDoanh = (string)dr["LoiNhuanRongTuHDKinhDoanh"],
                    ChiPhiDuPhong = (string)dr["ChiPhiDuPhong"],
                    ChiPhiDuPhongRuiRoTinDung = (string)dr["ChiPhiDuPhongRuiRoTinDung"],
                    KhoanXuLytheoCauTrucNganHang = (string)dr["KhoanXuLytheoCauTrucNganHang"],
                    DuPhongChungCacKhoanCamKetVaNo = (string)dr["DuPhongChungCacKhoanCamKetVaNo"],
                    DuPhongGiamGiaChungKhoan = (string)dr["DuPhongGiamGiaChungKhoan"],
                    ThuHoiNoDaXuLy = (string)dr["ThuHoiNoDaXuLy"],
                    TongLoiNhuanKeToan = (string)dr["TongLoiNhuanKeToan"],
                    ThuNhapTuCacKhoanNo = (string)dr["ThuNhapTuCacKhoanNo"],
                    LoiNhuanTuCacCTLienKet = (string)dr["LoiNhuanTuCacCTLienKet"],
                    TongLoiNhuanTruocThue = (string)dr["TongLoiNhuanTruocThue"],
                    ChiPhiThueTNDN = (string)dr["ChiPhiThueTNDN"],
                    ChiPhiThueHienThanh = (string)dr["ChiPhiThueHienThanh"],
                    ChiPhiThueHoanLai = (string)dr["ChiPhiThueHoanLai"],
                    LoiNhuanSauThue = (string)dr["LoiNhuanSauThue"],
                    LoiIchCoDongThieuSo = (string)dr["LoiIchCoDongThieuSo"],
                    LoiNhuanSauThueCoDongCTme = (string)dr["LoiNhuanSauThueCoDongCTme"],
                    LaiCoBanCoPhieu = (string)dr["LaiCoBanCoPhieu"],
                    LaiLoSuyGiamCoPhieu = (string)dr["LaiLoSuyGiamCoPhieu"]

                };
                BIDV.Add(bidv);
            }
            con.Close();
            return BIDV;
        }

        public List<Data> SelectAllVietin_Bank()
        {
            List<Data> BIDV = new List<Data>();
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string strCom = "select * from VietinBank";
            SqlCommand com = new SqlCommand(strCom, con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Data bidv = new Data()
                {
                    Nam = (string)dr["Nam"],
                    Quy = (string)dr["Quy"],
                    ThuNhapLaiRong = (string)dr["ThuNhapLaiRong"],
                    ThuNhapLaiVaCacKhoanThuNhap = (string)dr["ThuNhapLaiVaCacKhoanThuNhap"],
                    ChiPhiLaiVaKhoanChiPhiTuongTu = (string)dr["ChiPhiLaiVaKhoanChiPhiTuongTu"],
                    LaiLoRongTuHDDichVu = (string)dr["LaiLoRongTuHDDichVu"],
                    ThuNhapTuDV = (string)dr["ThuNhapTuDV"],
                    ChiPhiHoatDongDichVu = (string)dr["ChiPhiHoatDongDichVu"],
                    LaiLoTuKDNgoaiHoi = (string)dr["LaiLoTuKDNgoaiHoi"],
                    LaiLoTuMuaChungKhoanKD = (string)dr["LaiLoTuMuaChungKhoanKD"],
                    LaiLoThuanTuMuaBanChungKhoanDauTu = (string)dr["LaiLoThuanTuMuaBanChungKhoanDauTu"],
                    LaiTuHoatDongKhac = (string)dr["LaiTuHoatDongKhac"],
                    ThuNhapHDKhac = (string)dr["ThuNhapHDKhac"],
                    ChiPhiHoatDongKhac = (string)dr["ChiPhiHoatDongKhac"],
                    ThuNhapTuGopVon = (string)dr["ThuNhapTuGopVon"],
                    TongThuNhapKD = (string)dr["TongThuNhapKD"],
                    LaiLoCongTyLienKetLienDoanh = (string)dr["LaiLoCongTyLienKetLienDoanh"],
                    ChiPhiHoatDong = (string)dr["ChiPhiHoatDong"],
                    ChiPhiNhanVien = (string)dr["ChiPhiNhanVien"],
                    ChiPhiKhauHao = (string)dr["ChiPhiKhauHao"],
                    ChiPhiHoatDongKhac01 = (string)dr["ChiPhiHoatDongKhac01"],
                    LoiNhuanRongTuHDKinhDoanh = (string)dr["LoiNhuanRongTuHDKinhDoanh"],
                    ChiPhiDuPhong = (string)dr["ChiPhiDuPhong"],
                    ChiPhiDuPhongRuiRoTinDung = (string)dr["ChiPhiDuPhongRuiRoTinDung"],
                    KhoanXuLytheoCauTrucNganHang = (string)dr["KhoanXuLytheoCauTrucNganHang"],
                    DuPhongChungCacKhoanCamKetVaNo = (string)dr["DuPhongChungCacKhoanCamKetVaNo"],
                    DuPhongGiamGiaChungKhoan = (string)dr["DuPhongGiamGiaChungKhoan"],
                    ThuHoiNoDaXuLy = (string)dr["ThuHoiNoDaXuLy"],
                    TongLoiNhuanKeToan = (string)dr["TongLoiNhuanKeToan"],
                    ThuNhapTuCacKhoanNo = (string)dr["ThuNhapTuCacKhoanNo"],
                    LoiNhuanTuCacCTLienKet = (string)dr["LoiNhuanTuCacCTLienKet"],
                    TongLoiNhuanTruocThue = (string)dr["TongLoiNhuanTruocThue"],
                    ChiPhiThueTNDN = (string)dr["ChiPhiThueTNDN"],
                    ChiPhiThueHienThanh = (string)dr["ChiPhiThueHienThanh"],
                    ChiPhiThueHoanLai = (string)dr["ChiPhiThueHoanLai"],
                    LoiNhuanSauThue = (string)dr["LoiNhuanSauThue"],
                    LoiIchCoDongThieuSo = (string)dr["LoiIchCoDongThieuSo"],
                    LoiNhuanSauThueCoDongCTme = (string)dr["LoiNhuanSauThueCoDongCTme"],
                    LaiCoBanCoPhieu = (string)dr["LaiCoBanCoPhieu"],
                    LaiLoSuyGiamCoPhieu = (string)dr["LaiLoSuyGiamCoPhieu"]

                };
                BIDV.Add(bidv);
            }
            con.Close();
            return BIDV;
        }

        public List<Data> SelectAllVinaMilk()
        {
            List<Data> BIDV = new List<Data>();
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string strCom = "select * from VinaMilk";
            SqlCommand com = new SqlCommand(strCom, con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Data bidv = new Data()
                {
                    Nam = (string)dr["Nam"],
                    Quy = (string)dr["Quy"],
                    ThuNhapLaiRong = (string)dr["ThuNhapLaiRong"],
                    ThuNhapLaiVaCacKhoanThuNhap = (string)dr["ThuNhapLaiVaCacKhoanThuNhap"],
                    ChiPhiLaiVaKhoanChiPhiTuongTu = (string)dr["ChiPhiLaiVaKhoanChiPhiTuongTu"],
                    LaiLoRongTuHDDichVu = (string)dr["LaiLoRongTuHDDichVu"],
                    ThuNhapTuDV = (string)dr["ThuNhapTuDV"],
                    ChiPhiHoatDongDichVu = (string)dr["ChiPhiHoatDongDichVu"],
                    LaiLoTuKDNgoaiHoi = (string)dr["LaiLoTuKDNgoaiHoi"],
                    LaiLoTuMuaChungKhoanKD = (string)dr["LaiLoTuMuaChungKhoanKD"],
                    LaiLoThuanTuMuaBanChungKhoanDauTu = (string)dr["LaiLoThuanTuMuaBanChungKhoanDauTu"],
                    LaiTuHoatDongKhac = (string)dr["LaiTuHoatDongKhac"],
                    ThuNhapHDKhac = (string)dr["ThuNhapHDKhac"],
                    ChiPhiHoatDongKhac = (string)dr["ChiPhiHoatDongKhac"],
                    ThuNhapTuGopVon = (string)dr["ThuNhapTuGopVon"],
                    TongThuNhapKD = (string)dr["TongThuNhapKD"],
                    LaiLoCongTyLienKetLienDoanh = (string)dr["LaiLoCongTyLienKetLienDoanh"],
                    ChiPhiHoatDong = (string)dr["ChiPhiHoatDong"],
                    ChiPhiNhanVien = (string)dr["ChiPhiNhanVien"],
                    ChiPhiKhauHao = (string)dr["ChiPhiKhauHao"],
                    ChiPhiHoatDongKhac01 = (string)dr["ChiPhiHoatDongKhac01"],
                    LoiNhuanRongTuHDKinhDoanh = (string)dr["LoiNhuanRongTuHDKinhDoanh"],
                    ChiPhiDuPhong = (string)dr["ChiPhiDuPhong"],
                    ChiPhiDuPhongRuiRoTinDung = (string)dr["ChiPhiDuPhongRuiRoTinDung"],
                    KhoanXuLytheoCauTrucNganHang = (string)dr["KhoanXuLytheoCauTrucNganHang"],
                    DuPhongChungCacKhoanCamKetVaNo = (string)dr["DuPhongChungCacKhoanCamKetVaNo"],
                    DuPhongGiamGiaChungKhoan = (string)dr["DuPhongGiamGiaChungKhoan"],
                    ThuHoiNoDaXuLy = (string)dr["ThuHoiNoDaXuLy"],
                    TongLoiNhuanKeToan = (string)dr["TongLoiNhuanKeToan"],
                    ThuNhapTuCacKhoanNo = (string)dr["ThuNhapTuCacKhoanNo"],
                    LoiNhuanTuCacCTLienKet = (string)dr["LoiNhuanTuCacCTLienKet"],
                    TongLoiNhuanTruocThue = (string)dr["TongLoiNhuanTruocThue"],
                    ChiPhiThueTNDN = (string)dr["ChiPhiThueTNDN"],
                    ChiPhiThueHienThanh = (string)dr["ChiPhiThueHienThanh"],
                    ChiPhiThueHoanLai = (string)dr["ChiPhiThueHoanLai"],
                    LoiNhuanSauThue = (string)dr["LoiNhuanSauThue"],
                    LoiIchCoDongThieuSo = (string)dr["LoiIchCoDongThieuSo"],
                    LoiNhuanSauThueCoDongCTme = (string)dr["LoiNhuanSauThueCoDongCTme"],
                    LaiCoBanCoPhieu = (string)dr["LaiCoBanCoPhieu"],
                    LaiLoSuyGiamCoPhieu = (string)dr["LaiLoSuyGiamCoPhieu"]

                };
                BIDV.Add(bidv);
            }
            con.Close();
            return BIDV;
        }

        public List<Data> SelectAllVP_Bank()
        {
            List<Data> BIDV = new List<Data>();
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string strCom = "select * from VP_Bank";
            SqlCommand com = new SqlCommand(strCom, con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Data bidv = new Data()
                {
                    Nam = (string)dr["Nam"],
                    Quy = (string)dr["Quy"],
                    ThuNhapLaiRong = (string)dr["ThuNhapLaiRong"],
                    ThuNhapLaiVaCacKhoanThuNhap = (string)dr["ThuNhapLaiVaCacKhoanThuNhap"],
                    ChiPhiLaiVaKhoanChiPhiTuongTu = (string)dr["ChiPhiLaiVaKhoanChiPhiTuongTu"],
                    LaiLoRongTuHDDichVu = (string)dr["LaiLoRongTuHDDichVu"],
                    ThuNhapTuDV = (string)dr["ThuNhapTuDV"],
                    ChiPhiHoatDongDichVu = (string)dr["ChiPhiHoatDongDichVu"],
                    LaiLoTuKDNgoaiHoi = (string)dr["LaiLoTuKDNgoaiHoi"],
                    LaiLoTuMuaChungKhoanKD = (string)dr["LaiLoTuMuaChungKhoanKD"],
                    LaiLoThuanTuMuaBanChungKhoanDauTu = (string)dr["LaiLoThuanTuMuaBanChungKhoanDauTu"],
                    LaiTuHoatDongKhac = (string)dr["LaiTuHoatDongKhac"],
                    ThuNhapHDKhac = (string)dr["ThuNhapHDKhac"],
                    ChiPhiHoatDongKhac = (string)dr["ChiPhiHoatDongKhac"],
                    ThuNhapTuGopVon = (string)dr["ThuNhapTuGopVon"],
                    TongThuNhapKD = (string)dr["TongThuNhapKD"],
                    LaiLoCongTyLienKetLienDoanh = (string)dr["LaiLoCongTyLienKetLienDoanh"],
                    ChiPhiHoatDong = (string)dr["ChiPhiHoatDong"],
                    ChiPhiNhanVien = (string)dr["ChiPhiNhanVien"],
                    ChiPhiKhauHao = (string)dr["ChiPhiKhauHao"],
                    ChiPhiHoatDongKhac01 = (string)dr["ChiPhiHoatDongKhac01"],
                    LoiNhuanRongTuHDKinhDoanh = (string)dr["LoiNhuanRongTuHDKinhDoanh"],
                    ChiPhiDuPhong = (string)dr["ChiPhiDuPhong"],
                    ChiPhiDuPhongRuiRoTinDung = (string)dr["ChiPhiDuPhongRuiRoTinDung"],
                    KhoanXuLytheoCauTrucNganHang = (string)dr["KhoanXuLytheoCauTrucNganHang"],
                    DuPhongChungCacKhoanCamKetVaNo = (string)dr["DuPhongChungCacKhoanCamKetVaNo"],
                    DuPhongGiamGiaChungKhoan = (string)dr["DuPhongGiamGiaChungKhoan"],
                    ThuHoiNoDaXuLy = (string)dr["ThuHoiNoDaXuLy"],
                    TongLoiNhuanKeToan = (string)dr["TongLoiNhuanKeToan"],
                    ThuNhapTuCacKhoanNo = (string)dr["ThuNhapTuCacKhoanNo"],
                    LoiNhuanTuCacCTLienKet = (string)dr["LoiNhuanTuCacCTLienKet"],
                    TongLoiNhuanTruocThue = (string)dr["TongLoiNhuanTruocThue"],
                    ChiPhiThueTNDN = (string)dr["ChiPhiThueTNDN"],
                    ChiPhiThueHienThanh = (string)dr["ChiPhiThueHienThanh"],
                    ChiPhiThueHoanLai = (string)dr["ChiPhiThueHoanLai"],
                    LoiNhuanSauThue = (string)dr["LoiNhuanSauThue"],
                    LoiIchCoDongThieuSo = (string)dr["LoiIchCoDongThieuSo"],
                    LoiNhuanSauThueCoDongCTme = (string)dr["LoiNhuanSauThueCoDongCTme"],
                    LaiCoBanCoPhieu = (string)dr["LaiCoBanCoPhieu"],
                    LaiLoSuyGiamCoPhieu = (string)dr["LaiLoSuyGiamCoPhieu"]

                };
                BIDV.Add(bidv);
            }
            con.Close();
            return BIDV;
        }

        public List<Data02> SelectAll02()
        {
            List<Data02> BIDV = new List<Data02>();
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string strCom = "select * from Company";
            SqlCommand com = new SqlCommand(strCom, con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Data02 bidv = new Data02()
                {
                    id = (int)dr["id"],
                    Company = (string)dr["company"],
                    
                };
                BIDV.Add(bidv);
            }
            con.Close();
            return BIDV;
        }

        public List<Data02> Search(string giatri)
        {
            List<Data02> BIDV = new List<Data02>();
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string strCom = "select * from Company where LoiNhuanTuCacCTLienKet like @giatri or " +
                "ChiPhiHoatDongKhac like @giatri or LaiLoTuMuaChungKhoanKD like @giatri";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@giatri", "%" + giatri + "%"));
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Data02 bidv = new Data02()
                {
                    id = (int)dr["id"],
                    Company = (string)dr["company"],
                    LoiNhuanRongTuHDKinhDoanh = (string)dr["LoiNhuanRongTuHDKinhDoanh"],
                    TongLoiNhuanKeToan = (string)dr["TongLoiNhuanKeToan"],
                    LoiNhuanTuCacCTLienKet = (string)dr["LoiNhuanTuCacCTLienKet"],
                    TongLoiNhuanTruocThue = (string)dr["TongLoiNhuanTruocThue"],
                    LoiNhuanSauThue = (string)dr["LoiNhuanSauThue"],
                    LoiNhuanSauThueCoDongCTme = (string)dr["LoiNhuanSauThueCoDongCTme"],
                    ChiPhiLaiVaKhoanChiPhiTuongTu = (string)dr["ChiPhiLaiVaKhoanChiPhiTuongTu"],
                    ChiPhiHoatDongDichVu = (string)dr["ChiPhiHoatDongDichVu"],
                    ChiPhiHoatDongKhac = (string)dr["ChiPhiHoatDongKhac"],
                    ChiPhiHoatDong = (string)dr["ChiPhiHoatDong"],
                    ChiPhiNhanVien = (string)dr["ChiPhiNhanVien"],
                    LaiLoRongTuHDDichVu = (string)dr["LaiLoRongTuHDDichVu"],
                    LaiLoTuKDNgoaiHoi = (string)dr["LaiLoTuKDNgoaiHoi"],
                    LaiLoTuMuaChungKhoanKD = (string)dr["LaiLoTuMuaChungKhoanKD"],
                    LaiLoThuanTuMuaBanChungKhoanDauTu = (string)dr["LaiLoThuanTuMuaBanChungKhoanDauTu"],
                    LaiLoCongTyLienKetLienDoanh = (string)dr["LaiLoCongTyLienKetLienDoanh"],
                   
                };
                BIDV.Add(bidv);
            }
            con.Close();
            return BIDV;
        }

        public List<Data03> SelectAll03()
        {
            List<Data03> BIDV = new List<Data03>();
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string strCom = "select * from ThongTinChiTietCacCT";
            SqlCommand com = new SqlCommand(strCom, con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Data03 bidv = new Data03()
                {
                    Chiphi = (string)dr["ChiPhi"],
                    LoiNhuan = (string)dr["NguonLoiNhuan"],
                    LaiLo = (string)dr["LoLai"]
                };
                BIDV.Add(bidv);
            }
            con.Close();
            return BIDV;
        }

        public List<Data> SelectByNamBIDV(string Nam)
        {
            List<Data> BIDV = new List<Data>();
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string strCom = "select * from BIDV where Nam like @Nam";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@Nam", "%" + Nam + "%"));
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Data bidv = new Data()
                {
                    Nam = (string)dr["Nam"],
                    Quy = (string)dr["Quy"],
                    ThuNhapLaiRong = (string)dr["ThuNhapLaiRong"],
                    ThuNhapLaiVaCacKhoanThuNhap = (string)dr["ThuNhapLaiVaCacKhoanThuNhap"],
                    ChiPhiLaiVaKhoanChiPhiTuongTu = (string)dr["ChiPhiLaiVaKhoanChiPhiTuongTu"],
                    LaiLoRongTuHDDichVu = (string)dr["LaiLoRongTuHDDichVu"],
                    ThuNhapTuDV = (string)dr["ThuNhapTuDV"],
                    ChiPhiHoatDongDichVu = (string)dr["ChiPhiHoatDongDichVu"],
                    LaiLoTuKDNgoaiHoi = (string)dr["LaiLoTuKDNgoaiHoi"],
                    LaiLoTuMuaChungKhoanKD = (string)dr["LaiLoTuMuaChungKhoanKD"],
                    LaiLoThuanTuMuaBanChungKhoanDauTu = (string)dr["LaiLoThuanTuMuaBanChungKhoanDauTu"],
                    LaiTuHoatDongKhac = (string)dr["LaiTuHoatDongKhac"],
                    ThuNhapHDKhac = (string)dr["ThuNhapHDKhac"],
                    ChiPhiHoatDongKhac = (string)dr["ChiPhiHoatDongKhac"],
                    ThuNhapTuGopVon = (string)dr["ThuNhapTuGopVon"],
                    TongThuNhapKD = (string)dr["TongThuNhapKD"],
                    LaiLoCongTyLienKetLienDoanh = (string)dr["LaiLoCongTyLienKetLienDoanh"],
                    ChiPhiHoatDong = (string)dr["ChiPhiHoatDong"],
                    ChiPhiNhanVien = (string)dr["ChiPhiNhanVien"],
                    ChiPhiKhauHao = (string)dr["ChiPhiKhauHao"],
                    ChiPhiHoatDongKhac01 = (string)dr["ChiPhiHoatDongKhac01"],
                    LoiNhuanRongTuHDKinhDoanh = (string)dr["LoiNhuanRongTuHDKinhDoanh"],
                    ChiPhiDuPhong = (string)dr["ChiPhiDuPhong"],
                    ChiPhiDuPhongRuiRoTinDung = (string)dr["ChiPhiDuPhongRuiRoTinDung"],
                    KhoanXuLytheoCauTrucNganHang = (string)dr["KhoanXuLytheoCauTrucNganHang"],
                    DuPhongChungCacKhoanCamKetVaNo = (string)dr["DuPhongChungCacKhoanCamKetVaNo"],
                    DuPhongGiamGiaChungKhoan = (string)dr["DuPhongGiamGiaChungKhoan"],
                    ThuHoiNoDaXuLy = (string)dr["ThuHoiNoDaXuLy"],
                    TongLoiNhuanKeToan = (string)dr["TongLoiNhuanKeToan"],
                    ThuNhapTuCacKhoanNo = (string)dr["ThuNhapTuCacKhoanNo"],
                    LoiNhuanTuCacCTLienKet = (string)dr["LoiNhuanTuCacCTLienKet"],
                    TongLoiNhuanTruocThue = (string)dr["TongLoiNhuanTruocThue"],
                    ChiPhiThueTNDN = (string)dr["ChiPhiThueTNDN"],
                    ChiPhiThueHienThanh = (string)dr["ChiPhiThueHienThanh"],
                    ChiPhiThueHoanLai = (string)dr["ChiPhiThueHoanLai"],
                    LoiNhuanSauThue = (string)dr["LoiNhuanSauThue"],
                    LoiIchCoDongThieuSo = (string)dr["LoiIchCoDongThieuSo"],
                    LoiNhuanSauThueCoDongCTme = (string)dr["LoiNhuanSauThueCoDongCTme"],
                    LaiCoBanCoPhieu = (string)dr["LaiCoBanCoPhieu"],
                    LaiLoSuyGiamCoPhieu = (string)dr["LaiLoSuyGiamCoPhieu"]

                };
                BIDV.Add(bidv); 
            }
            con.Close();
            return BIDV;
        }

        public List<Data> SelectByNamFPT(string Nam)
        {
            List<Data> BIDV = new List<Data>();
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string strCom = "select * from FPT where Nam like @Nam";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@Nam", "%" + Nam + "%"));
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Data bidv = new Data()
                {
                    Nam = (string)dr["Nam"],
                    Quy = (string)dr["Quy"],
                    ThuNhapLaiRong = (string)dr["ThuNhapLaiRong"],
                    ThuNhapLaiVaCacKhoanThuNhap = (string)dr["ThuNhapLaiVaCacKhoanThuNhap"],
                    ChiPhiLaiVaKhoanChiPhiTuongTu = (string)dr["ChiPhiLaiVaKhoanChiPhiTuongTu"],
                    LaiLoRongTuHDDichVu = (string)dr["LaiLoRongTuHDDichVu"],
                    ThuNhapTuDV = (string)dr["ThuNhapTuDV"],
                    ChiPhiHoatDongDichVu = (string)dr["ChiPhiHoatDongDichVu"],
                    LaiLoTuKDNgoaiHoi = (string)dr["LaiLoTuKDNgoaiHoi"],
                    LaiLoTuMuaChungKhoanKD = (string)dr["LaiLoTuMuaChungKhoanKD"],
                    LaiLoThuanTuMuaBanChungKhoanDauTu = (string)dr["LaiLoThuanTuMuaBanChungKhoanDauTu"],
                    LaiTuHoatDongKhac = (string)dr["LaiTuHoatDongKhac"],
                    ThuNhapHDKhac = (string)dr["ThuNhapHDKhac"],
                    ChiPhiHoatDongKhac = (string)dr["ChiPhiHoatDongKhac"],
                    ThuNhapTuGopVon = (string)dr["ThuNhapTuGopVon"],
                    TongThuNhapKD = (string)dr["TongThuNhapKD"],
                    LaiLoCongTyLienKetLienDoanh = (string)dr["LaiLoCongTyLienKetLienDoanh"],
                    ChiPhiHoatDong = (string)dr["ChiPhiHoatDong"],
                    ChiPhiNhanVien = (string)dr["ChiPhiNhanVien"],
                    ChiPhiKhauHao = (string)dr["ChiPhiKhauHao"],
                    ChiPhiHoatDongKhac01 = (string)dr["ChiPhiHoatDongKhac01"],
                    LoiNhuanRongTuHDKinhDoanh = (string)dr["LoiNhuanRongTuHDKinhDoanh"],
                    ChiPhiDuPhong = (string)dr["ChiPhiDuPhong"],
                    ChiPhiDuPhongRuiRoTinDung = (string)dr["ChiPhiDuPhongRuiRoTinDung"],
                    KhoanXuLytheoCauTrucNganHang = (string)dr["KhoanXuLytheoCauTrucNganHang"],
                    DuPhongChungCacKhoanCamKetVaNo = (string)dr["DuPhongChungCacKhoanCamKetVaNo"],
                    DuPhongGiamGiaChungKhoan = (string)dr["DuPhongGiamGiaChungKhoan"],
                    ThuHoiNoDaXuLy = (string)dr["ThuHoiNoDaXuLy"],
                    TongLoiNhuanKeToan = (string)dr["TongLoiNhuanKeToan"],
                    ThuNhapTuCacKhoanNo = (string)dr["ThuNhapTuCacKhoanNo"],
                    LoiNhuanTuCacCTLienKet = (string)dr["LoiNhuanTuCacCTLienKet"],
                    TongLoiNhuanTruocThue = (string)dr["TongLoiNhuanTruocThue"],
                    ChiPhiThueTNDN = (string)dr["ChiPhiThueTNDN"],
                    ChiPhiThueHienThanh = (string)dr["ChiPhiThueHienThanh"],
                    ChiPhiThueHoanLai = (string)dr["ChiPhiThueHoanLai"],
                    LoiNhuanSauThue = (string)dr["LoiNhuanSauThue"],
                    LoiIchCoDongThieuSo = (string)dr["LoiIchCoDongThieuSo"],
                    LoiNhuanSauThueCoDongCTme = (string)dr["LoiNhuanSauThueCoDongCTme"],
                    LaiCoBanCoPhieu = (string)dr["LaiCoBanCoPhieu"],
                    LaiLoSuyGiamCoPhieu = (string)dr["LaiLoSuyGiamCoPhieu"]

                };
                BIDV.Add(bidv);
            }
            con.Close();
            return BIDV;
        }

        public List<Data> SelectByNamMB_Bank(string Nam)
        {
            List<Data> BIDV = new List<Data>();
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string strCom = "select * from MB_Bank where Nam like @Nam";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@Nam", "%" + Nam + "%"));
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Data bidv = new Data()
                {
                    Nam = (string)dr["Nam"],
                    Quy = (string)dr["Quy"],
                    ThuNhapLaiRong = (string)dr["ThuNhapLaiRong"],
                    ThuNhapLaiVaCacKhoanThuNhap = (string)dr["ThuNhapLaiVaCacKhoanThuNhap"],
                    ChiPhiLaiVaKhoanChiPhiTuongTu = (string)dr["ChiPhiLaiVaKhoanChiPhiTuongTu"],
                    LaiLoRongTuHDDichVu = (string)dr["LaiLoRongTuHDDichVu"],
                    ThuNhapTuDV = (string)dr["ThuNhapTuDV"],
                    ChiPhiHoatDongDichVu = (string)dr["ChiPhiHoatDongDichVu"],
                    LaiLoTuKDNgoaiHoi = (string)dr["LaiLoTuKDNgoaiHoi"],
                    LaiLoTuMuaChungKhoanKD = (string)dr["LaiLoTuMuaChungKhoanKD"],
                    LaiLoThuanTuMuaBanChungKhoanDauTu = (string)dr["LaiLoThuanTuMuaBanChungKhoanDauTu"],
                    LaiTuHoatDongKhac = (string)dr["LaiTuHoatDongKhac"],
                    ThuNhapHDKhac = (string)dr["ThuNhapHDKhac"],
                    ChiPhiHoatDongKhac = (string)dr["ChiPhiHoatDongKhac"],
                    ThuNhapTuGopVon = (string)dr["ThuNhapTuGopVon"],
                    TongThuNhapKD = (string)dr["TongThuNhapKD"],
                    LaiLoCongTyLienKetLienDoanh = (string)dr["LaiLoCongTyLienKetLienDoanh"],
                    ChiPhiHoatDong = (string)dr["ChiPhiHoatDong"],
                    ChiPhiNhanVien = (string)dr["ChiPhiNhanVien"],
                    ChiPhiKhauHao = (string)dr["ChiPhiKhauHao"],
                    ChiPhiHoatDongKhac01 = (string)dr["ChiPhiHoatDongKhac01"],
                    LoiNhuanRongTuHDKinhDoanh = (string)dr["LoiNhuanRongTuHDKinhDoanh"],
                    ChiPhiDuPhong = (string)dr["ChiPhiDuPhong"],
                    ChiPhiDuPhongRuiRoTinDung = (string)dr["ChiPhiDuPhongRuiRoTinDung"],
                    KhoanXuLytheoCauTrucNganHang = (string)dr["KhoanXuLytheoCauTrucNganHang"],
                    DuPhongChungCacKhoanCamKetVaNo = (string)dr["DuPhongChungCacKhoanCamKetVaNo"],
                    DuPhongGiamGiaChungKhoan = (string)dr["DuPhongGiamGiaChungKhoan"],
                    ThuHoiNoDaXuLy = (string)dr["ThuHoiNoDaXuLy"],
                    TongLoiNhuanKeToan = (string)dr["TongLoiNhuanKeToan"],
                    ThuNhapTuCacKhoanNo = (string)dr["ThuNhapTuCacKhoanNo"],
                    LoiNhuanTuCacCTLienKet = (string)dr["LoiNhuanTuCacCTLienKet"],
                    TongLoiNhuanTruocThue = (string)dr["TongLoiNhuanTruocThue"],
                    ChiPhiThueTNDN = (string)dr["ChiPhiThueTNDN"],
                    ChiPhiThueHienThanh = (string)dr["ChiPhiThueHienThanh"],
                    ChiPhiThueHoanLai = (string)dr["ChiPhiThueHoanLai"],
                    LoiNhuanSauThue = (string)dr["LoiNhuanSauThue"],
                    LoiIchCoDongThieuSo = (string)dr["LoiIchCoDongThieuSo"],
                    LoiNhuanSauThueCoDongCTme = (string)dr["LoiNhuanSauThueCoDongCTme"],
                    LaiCoBanCoPhieu = (string)dr["LaiCoBanCoPhieu"],
                    LaiLoSuyGiamCoPhieu = (string)dr["LaiLoSuyGiamCoPhieu"]

                };
                BIDV.Add(bidv);
            }
            con.Close();
            return BIDV;
        }

        public List<Data> SelectByNamOCB_Bank(string Nam)
        {
            List<Data> BIDV = new List<Data>();
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string strCom = "select * from OCB_Bank where Nam like @Nam";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@Nam", "%" + Nam + "%"));
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Data bidv = new Data()
                {
                    Nam = (string)dr["Nam"],
                    Quy = (string)dr["Quy"],
                    ThuNhapLaiRong = (string)dr["ThuNhapLaiRong"],
                    ThuNhapLaiVaCacKhoanThuNhap = (string)dr["ThuNhapLaiVaCacKhoanThuNhap"],
                    ChiPhiLaiVaKhoanChiPhiTuongTu = (string)dr["ChiPhiLaiVaKhoanChiPhiTuongTu"],
                    LaiLoRongTuHDDichVu = (string)dr["LaiLoRongTuHDDichVu"],
                    ThuNhapTuDV = (string)dr["ThuNhapTuDV"],
                    ChiPhiHoatDongDichVu = (string)dr["ChiPhiHoatDongDichVu"],
                    LaiLoTuKDNgoaiHoi = (string)dr["LaiLoTuKDNgoaiHoi"],
                    LaiLoTuMuaChungKhoanKD = (string)dr["LaiLoTuMuaChungKhoanKD"],
                    LaiLoThuanTuMuaBanChungKhoanDauTu = (string)dr["LaiLoThuanTuMuaBanChungKhoanDauTu"],
                    LaiTuHoatDongKhac = (string)dr["LaiTuHoatDongKhac"],
                    ThuNhapHDKhac = (string)dr["ThuNhapHDKhac"],
                    ChiPhiHoatDongKhac = (string)dr["ChiPhiHoatDongKhac"],
                    ThuNhapTuGopVon = (string)dr["ThuNhapTuGopVon"],
                    TongThuNhapKD = (string)dr["TongThuNhapKD"],
                    LaiLoCongTyLienKetLienDoanh = (string)dr["LaiLoCongTyLienKetLienDoanh"],
                    ChiPhiHoatDong = (string)dr["ChiPhiHoatDong"],
                    ChiPhiNhanVien = (string)dr["ChiPhiNhanVien"],
                    ChiPhiKhauHao = (string)dr["ChiPhiKhauHao"],
                    ChiPhiHoatDongKhac01 = (string)dr["ChiPhiHoatDongKhac01"],
                    LoiNhuanRongTuHDKinhDoanh = (string)dr["LoiNhuanRongTuHDKinhDoanh"],
                    ChiPhiDuPhong = (string)dr["ChiPhiDuPhong"],
                    ChiPhiDuPhongRuiRoTinDung = (string)dr["ChiPhiDuPhongRuiRoTinDung"],
                    KhoanXuLytheoCauTrucNganHang = (string)dr["KhoanXuLytheoCauTrucNganHang"],
                    DuPhongChungCacKhoanCamKetVaNo = (string)dr["DuPhongChungCacKhoanCamKetVaNo"],
                    DuPhongGiamGiaChungKhoan = (string)dr["DuPhongGiamGiaChungKhoan"],
                    ThuHoiNoDaXuLy = (string)dr["ThuHoiNoDaXuLy"],
                    TongLoiNhuanKeToan = (string)dr["TongLoiNhuanKeToan"],
                    ThuNhapTuCacKhoanNo = (string)dr["ThuNhapTuCacKhoanNo"],
                    LoiNhuanTuCacCTLienKet = (string)dr["LoiNhuanTuCacCTLienKet"],
                    TongLoiNhuanTruocThue = (string)dr["TongLoiNhuanTruocThue"],
                    ChiPhiThueTNDN = (string)dr["ChiPhiThueTNDN"],
                    ChiPhiThueHienThanh = (string)dr["ChiPhiThueHienThanh"],
                    ChiPhiThueHoanLai = (string)dr["ChiPhiThueHoanLai"],
                    LoiNhuanSauThue = (string)dr["LoiNhuanSauThue"],
                    LoiIchCoDongThieuSo = (string)dr["LoiIchCoDongThieuSo"],
                    LoiNhuanSauThueCoDongCTme = (string)dr["LoiNhuanSauThueCoDongCTme"],
                    LaiCoBanCoPhieu = (string)dr["LaiCoBanCoPhieu"],
                    LaiLoSuyGiamCoPhieu = (string)dr["LaiLoSuyGiamCoPhieu"]

                };
                BIDV.Add(bidv);
            }
            con.Close();
            return BIDV;
        }

        public List<Data> SelectByNamSCB(string Nam)
        {
            List<Data> BIDV = new List<Data>();
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string strCom = "select * from SCB where Nam like @Nam";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@Nam", "%" + Nam + "%"));
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Data bidv = new Data()
                {
                    Nam = (string)dr["Nam"],
                    Quy = (string)dr["Quy"],
                    ThuNhapLaiRong = (string)dr["ThuNhapLaiRong"],
                    ThuNhapLaiVaCacKhoanThuNhap = (string)dr["ThuNhapLaiVaCacKhoanThuNhap"],
                    ChiPhiLaiVaKhoanChiPhiTuongTu = (string)dr["ChiPhiLaiVaKhoanChiPhiTuongTu"],
                    LaiLoRongTuHDDichVu = (string)dr["LaiLoRongTuHDDichVu"],
                    ThuNhapTuDV = (string)dr["ThuNhapTuDV"],
                    ChiPhiHoatDongDichVu = (string)dr["ChiPhiHoatDongDichVu"],
                    LaiLoTuKDNgoaiHoi = (string)dr["LaiLoTuKDNgoaiHoi"],
                    LaiLoTuMuaChungKhoanKD = (string)dr["LaiLoTuMuaChungKhoanKD"],
                    LaiLoThuanTuMuaBanChungKhoanDauTu = (string)dr["LaiLoThuanTuMuaBanChungKhoanDauTu"],
                    LaiTuHoatDongKhac = (string)dr["LaiTuHoatDongKhac"],
                    ThuNhapHDKhac = (string)dr["ThuNhapHDKhac"],
                    ChiPhiHoatDongKhac = (string)dr["ChiPhiHoatDongKhac"],
                    ThuNhapTuGopVon = (string)dr["ThuNhapTuGopVon"],
                    TongThuNhapKD = (string)dr["TongThuNhapKD"],
                    LaiLoCongTyLienKetLienDoanh = (string)dr["LaiLoCongTyLienKetLienDoanh"],
                    ChiPhiHoatDong = (string)dr["ChiPhiHoatDong"],
                    ChiPhiNhanVien = (string)dr["ChiPhiNhanVien"],
                    ChiPhiKhauHao = (string)dr["ChiPhiKhauHao"],
                    ChiPhiHoatDongKhac01 = (string)dr["ChiPhiHoatDongKhac01"],
                    LoiNhuanRongTuHDKinhDoanh = (string)dr["LoiNhuanRongTuHDKinhDoanh"],
                    ChiPhiDuPhong = (string)dr["ChiPhiDuPhong"],
                    ChiPhiDuPhongRuiRoTinDung = (string)dr["ChiPhiDuPhongRuiRoTinDung"],
                    KhoanXuLytheoCauTrucNganHang = (string)dr["KhoanXuLytheoCauTrucNganHang"],
                    DuPhongChungCacKhoanCamKetVaNo = (string)dr["DuPhongChungCacKhoanCamKetVaNo"],
                    DuPhongGiamGiaChungKhoan = (string)dr["DuPhongGiamGiaChungKhoan"],
                    ThuHoiNoDaXuLy = (string)dr["ThuHoiNoDaXuLy"],
                    TongLoiNhuanKeToan = (string)dr["TongLoiNhuanKeToan"],
                    ThuNhapTuCacKhoanNo = (string)dr["ThuNhapTuCacKhoanNo"],
                    LoiNhuanTuCacCTLienKet = (string)dr["LoiNhuanTuCacCTLienKet"],
                    TongLoiNhuanTruocThue = (string)dr["TongLoiNhuanTruocThue"],
                    ChiPhiThueTNDN = (string)dr["ChiPhiThueTNDN"],
                    ChiPhiThueHienThanh = (string)dr["ChiPhiThueHienThanh"],
                    ChiPhiThueHoanLai = (string)dr["ChiPhiThueHoanLai"],
                    LoiNhuanSauThue = (string)dr["LoiNhuanSauThue"],
                    LoiIchCoDongThieuSo = (string)dr["LoiIchCoDongThieuSo"],
                    LoiNhuanSauThueCoDongCTme = (string)dr["LoiNhuanSauThueCoDongCTme"],
                    LaiCoBanCoPhieu = (string)dr["LaiCoBanCoPhieu"],
                    LaiLoSuyGiamCoPhieu = (string)dr["LaiLoSuyGiamCoPhieu"]

                };
                BIDV.Add(bidv);
            }
            con.Close();
            return BIDV;
        }

        public List<Data> SelectByNamTechcom(string Nam)
        {
            List<Data> BIDV = new List<Data>();
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string strCom = "select * from TechcomBank where Nam like @Nam";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@Nam", "%" + Nam + "%"));
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Data bidv = new Data()
                {
                    Nam = (string)dr["Nam"],
                    Quy = (string)dr["Quy"],
                    ThuNhapLaiRong = (string)dr["ThuNhapLaiRong"],
                    ThuNhapLaiVaCacKhoanThuNhap = (string)dr["ThuNhapLaiVaCacKhoanThuNhap"],
                    ChiPhiLaiVaKhoanChiPhiTuongTu = (string)dr["ChiPhiLaiVaKhoanChiPhiTuongTu"],
                    LaiLoRongTuHDDichVu = (string)dr["LaiLoRongTuHDDichVu"],
                    ThuNhapTuDV = (string)dr["ThuNhapTuDV"],
                    ChiPhiHoatDongDichVu = (string)dr["ChiPhiHoatDongDichVu"],
                    LaiLoTuKDNgoaiHoi = (string)dr["LaiLoTuKDNgoaiHoi"],
                    LaiLoTuMuaChungKhoanKD = (string)dr["LaiLoTuMuaChungKhoanKD"],
                    LaiLoThuanTuMuaBanChungKhoanDauTu = (string)dr["LaiLoThuanTuMuaBanChungKhoanDauTu"],
                    LaiTuHoatDongKhac = (string)dr["LaiTuHoatDongKhac"],
                    ThuNhapHDKhac = (string)dr["ThuNhapHDKhac"],
                    ChiPhiHoatDongKhac = (string)dr["ChiPhiHoatDongKhac"],
                    ThuNhapTuGopVon = (string)dr["ThuNhapTuGopVon"],
                    TongThuNhapKD = (string)dr["TongThuNhapKD"],
                    LaiLoCongTyLienKetLienDoanh = (string)dr["LaiLoCongTyLienKetLienDoanh"],
                    ChiPhiHoatDong = (string)dr["ChiPhiHoatDong"],
                    ChiPhiNhanVien = (string)dr["ChiPhiNhanVien"],
                    ChiPhiKhauHao = (string)dr["ChiPhiKhauHao"],
                    ChiPhiHoatDongKhac01 = (string)dr["ChiPhiHoatDongKhac01"],
                    LoiNhuanRongTuHDKinhDoanh = (string)dr["LoiNhuanRongTuHDKinhDoanh"],
                    ChiPhiDuPhong = (string)dr["ChiPhiDuPhong"],
                    ChiPhiDuPhongRuiRoTinDung = (string)dr["ChiPhiDuPhongRuiRoTinDung"],
                    KhoanXuLytheoCauTrucNganHang = (string)dr["KhoanXuLytheoCauTrucNganHang"],
                    DuPhongChungCacKhoanCamKetVaNo = (string)dr["DuPhongChungCacKhoanCamKetVaNo"],
                    DuPhongGiamGiaChungKhoan = (string)dr["DuPhongGiamGiaChungKhoan"],
                    ThuHoiNoDaXuLy = (string)dr["ThuHoiNoDaXuLy"],
                    TongLoiNhuanKeToan = (string)dr["TongLoiNhuanKeToan"],
                    ThuNhapTuCacKhoanNo = (string)dr["ThuNhapTuCacKhoanNo"],
                    LoiNhuanTuCacCTLienKet = (string)dr["LoiNhuanTuCacCTLienKet"],
                    TongLoiNhuanTruocThue = (string)dr["TongLoiNhuanTruocThue"],
                    ChiPhiThueTNDN = (string)dr["ChiPhiThueTNDN"],
                    ChiPhiThueHienThanh = (string)dr["ChiPhiThueHienThanh"],
                    ChiPhiThueHoanLai = (string)dr["ChiPhiThueHoanLai"],
                    LoiNhuanSauThue = (string)dr["LoiNhuanSauThue"],
                    LoiIchCoDongThieuSo = (string)dr["LoiIchCoDongThieuSo"],
                    LoiNhuanSauThueCoDongCTme = (string)dr["LoiNhuanSauThueCoDongCTme"],
                    LaiCoBanCoPhieu = (string)dr["LaiCoBanCoPhieu"],
                    LaiLoSuyGiamCoPhieu = (string)dr["LaiLoSuyGiamCoPhieu"]

                };
                BIDV.Add(bidv);
            }
            con.Close();
            return BIDV;
        }

        public List<Data> SelectByNamVietcom(string Nam)
        {
            List<Data> BIDV = new List<Data>();
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string strCom = "select * from VietcomBank where Nam like @Nam";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@Nam", "%" + Nam + "%"));
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Data bidv = new Data()
                {
                    Nam = (string)dr["Nam"],
                    Quy = (string)dr["Quy"],
                    ThuNhapLaiRong = (string)dr["ThuNhapLaiRong"],
                    ThuNhapLaiVaCacKhoanThuNhap = (string)dr["ThuNhapLaiVaCacKhoanThuNhap"],
                    ChiPhiLaiVaKhoanChiPhiTuongTu = (string)dr["ChiPhiLaiVaKhoanChiPhiTuongTu"],
                    LaiLoRongTuHDDichVu = (string)dr["LaiLoRongTuHDDichVu"],
                    ThuNhapTuDV = (string)dr["ThuNhapTuDV"],
                    ChiPhiHoatDongDichVu = (string)dr["ChiPhiHoatDongDichVu"],
                    LaiLoTuKDNgoaiHoi = (string)dr["LaiLoTuKDNgoaiHoi"],
                    LaiLoTuMuaChungKhoanKD = (string)dr["LaiLoTuMuaChungKhoanKD"],
                    LaiLoThuanTuMuaBanChungKhoanDauTu = (string)dr["LaiLoThuanTuMuaBanChungKhoanDauTu"],
                    LaiTuHoatDongKhac = (string)dr["LaiTuHoatDongKhac"],
                    ThuNhapHDKhac = (string)dr["ThuNhapHDKhac"],
                    ChiPhiHoatDongKhac = (string)dr["ChiPhiHoatDongKhac"],
                    ThuNhapTuGopVon = (string)dr["ThuNhapTuGopVon"],
                    TongThuNhapKD = (string)dr["TongThuNhapKD"],
                    LaiLoCongTyLienKetLienDoanh = (string)dr["LaiLoCongTyLienKetLienDoanh"],
                    ChiPhiHoatDong = (string)dr["ChiPhiHoatDong"],
                    ChiPhiNhanVien = (string)dr["ChiPhiNhanVien"],
                    ChiPhiKhauHao = (string)dr["ChiPhiKhauHao"],
                    ChiPhiHoatDongKhac01 = (string)dr["ChiPhiHoatDongKhac01"],
                    LoiNhuanRongTuHDKinhDoanh = (string)dr["LoiNhuanRongTuHDKinhDoanh"],
                    ChiPhiDuPhong = (string)dr["ChiPhiDuPhong"],
                    ChiPhiDuPhongRuiRoTinDung = (string)dr["ChiPhiDuPhongRuiRoTinDung"],
                    KhoanXuLytheoCauTrucNganHang = (string)dr["KhoanXuLytheoCauTrucNganHang"],
                    DuPhongChungCacKhoanCamKetVaNo = (string)dr["DuPhongChungCacKhoanCamKetVaNo"],
                    DuPhongGiamGiaChungKhoan = (string)dr["DuPhongGiamGiaChungKhoan"],
                    ThuHoiNoDaXuLy = (string)dr["ThuHoiNoDaXuLy"],
                    TongLoiNhuanKeToan = (string)dr["TongLoiNhuanKeToan"],
                    ThuNhapTuCacKhoanNo = (string)dr["ThuNhapTuCacKhoanNo"],
                    LoiNhuanTuCacCTLienKet = (string)dr["LoiNhuanTuCacCTLienKet"],
                    TongLoiNhuanTruocThue = (string)dr["TongLoiNhuanTruocThue"],
                    ChiPhiThueTNDN = (string)dr["ChiPhiThueTNDN"],
                    ChiPhiThueHienThanh = (string)dr["ChiPhiThueHienThanh"],
                    ChiPhiThueHoanLai = (string)dr["ChiPhiThueHoanLai"],
                    LoiNhuanSauThue = (string)dr["LoiNhuanSauThue"],
                    LoiIchCoDongThieuSo = (string)dr["LoiIchCoDongThieuSo"],
                    LoiNhuanSauThueCoDongCTme = (string)dr["LoiNhuanSauThueCoDongCTme"],
                    LaiCoBanCoPhieu = (string)dr["LaiCoBanCoPhieu"],
                    LaiLoSuyGiamCoPhieu = (string)dr["LaiLoSuyGiamCoPhieu"]

                };
                BIDV.Add(bidv);
            }
            con.Close();
            return BIDV;
        }

        public List<Data> SelectByNamVietin(string Nam)
        {
            List<Data> BIDV = new List<Data>();
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string strCom = "select * from VietinBank where Nam like @Nam";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@Nam", "%" + Nam + "%"));
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Data bidv = new Data()
                {
                    Nam = (string)dr["Nam"],
                    Quy = (string)dr["Quy"],
                    ThuNhapLaiRong = (string)dr["ThuNhapLaiRong"],
                    ThuNhapLaiVaCacKhoanThuNhap = (string)dr["ThuNhapLaiVaCacKhoanThuNhap"],
                    ChiPhiLaiVaKhoanChiPhiTuongTu = (string)dr["ChiPhiLaiVaKhoanChiPhiTuongTu"],
                    LaiLoRongTuHDDichVu = (string)dr["LaiLoRongTuHDDichVu"],
                    ThuNhapTuDV = (string)dr["ThuNhapTuDV"],
                    ChiPhiHoatDongDichVu = (string)dr["ChiPhiHoatDongDichVu"],
                    LaiLoTuKDNgoaiHoi = (string)dr["LaiLoTuKDNgoaiHoi"],
                    LaiLoTuMuaChungKhoanKD = (string)dr["LaiLoTuMuaChungKhoanKD"],
                    LaiLoThuanTuMuaBanChungKhoanDauTu = (string)dr["LaiLoThuanTuMuaBanChungKhoanDauTu"],
                    LaiTuHoatDongKhac = (string)dr["LaiTuHoatDongKhac"],
                    ThuNhapHDKhac = (string)dr["ThuNhapHDKhac"],
                    ChiPhiHoatDongKhac = (string)dr["ChiPhiHoatDongKhac"],
                    ThuNhapTuGopVon = (string)dr["ThuNhapTuGopVon"],
                    TongThuNhapKD = (string)dr["TongThuNhapKD"],
                    LaiLoCongTyLienKetLienDoanh = (string)dr["LaiLoCongTyLienKetLienDoanh"],
                    ChiPhiHoatDong = (string)dr["ChiPhiHoatDong"],
                    ChiPhiNhanVien = (string)dr["ChiPhiNhanVien"],
                    ChiPhiKhauHao = (string)dr["ChiPhiKhauHao"],
                    ChiPhiHoatDongKhac01 = (string)dr["ChiPhiHoatDongKhac01"],
                    LoiNhuanRongTuHDKinhDoanh = (string)dr["LoiNhuanRongTuHDKinhDoanh"],
                    ChiPhiDuPhong = (string)dr["ChiPhiDuPhong"],
                    ChiPhiDuPhongRuiRoTinDung = (string)dr["ChiPhiDuPhongRuiRoTinDung"],
                    KhoanXuLytheoCauTrucNganHang = (string)dr["KhoanXuLytheoCauTrucNganHang"],
                    DuPhongChungCacKhoanCamKetVaNo = (string)dr["DuPhongChungCacKhoanCamKetVaNo"],
                    DuPhongGiamGiaChungKhoan = (string)dr["DuPhongGiamGiaChungKhoan"],
                    ThuHoiNoDaXuLy = (string)dr["ThuHoiNoDaXuLy"],
                    TongLoiNhuanKeToan = (string)dr["TongLoiNhuanKeToan"],
                    ThuNhapTuCacKhoanNo = (string)dr["ThuNhapTuCacKhoanNo"],
                    LoiNhuanTuCacCTLienKet = (string)dr["LoiNhuanTuCacCTLienKet"],
                    TongLoiNhuanTruocThue = (string)dr["TongLoiNhuanTruocThue"],
                    ChiPhiThueTNDN = (string)dr["ChiPhiThueTNDN"],
                    ChiPhiThueHienThanh = (string)dr["ChiPhiThueHienThanh"],
                    ChiPhiThueHoanLai = (string)dr["ChiPhiThueHoanLai"],
                    LoiNhuanSauThue = (string)dr["LoiNhuanSauThue"],
                    LoiIchCoDongThieuSo = (string)dr["LoiIchCoDongThieuSo"],
                    LoiNhuanSauThueCoDongCTme = (string)dr["LoiNhuanSauThueCoDongCTme"],
                    LaiCoBanCoPhieu = (string)dr["LaiCoBanCoPhieu"],
                    LaiLoSuyGiamCoPhieu = (string)dr["LaiLoSuyGiamCoPhieu"]

                };
                BIDV.Add(bidv);
            }
            con.Close();
            return BIDV;
        }

        public List<Data> SelectByNamVinaMilk(string Nam)
        {
            List<Data> BIDV = new List<Data>();
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string strCom = "select * from VinaMilk where Nam like @Nam";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@Nam", "%" + Nam + "%"));
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Data bidv = new Data()
                {
                    Nam = (string)dr["Nam"],
                    Quy = (string)dr["Quy"],
                    ThuNhapLaiRong = (string)dr["ThuNhapLaiRong"],
                    ThuNhapLaiVaCacKhoanThuNhap = (string)dr["ThuNhapLaiVaCacKhoanThuNhap"],
                    ChiPhiLaiVaKhoanChiPhiTuongTu = (string)dr["ChiPhiLaiVaKhoanChiPhiTuongTu"],
                    LaiLoRongTuHDDichVu = (string)dr["LaiLoRongTuHDDichVu"],
                    ThuNhapTuDV = (string)dr["ThuNhapTuDV"],
                    ChiPhiHoatDongDichVu = (string)dr["ChiPhiHoatDongDichVu"],
                    LaiLoTuKDNgoaiHoi = (string)dr["LaiLoTuKDNgoaiHoi"],
                    LaiLoTuMuaChungKhoanKD = (string)dr["LaiLoTuMuaChungKhoanKD"],
                    LaiLoThuanTuMuaBanChungKhoanDauTu = (string)dr["LaiLoThuanTuMuaBanChungKhoanDauTu"],
                    LaiTuHoatDongKhac = (string)dr["LaiTuHoatDongKhac"],
                    ThuNhapHDKhac = (string)dr["ThuNhapHDKhac"],
                    ChiPhiHoatDongKhac = (string)dr["ChiPhiHoatDongKhac"],
                    ThuNhapTuGopVon = (string)dr["ThuNhapTuGopVon"],
                    TongThuNhapKD = (string)dr["TongThuNhapKD"],
                    LaiLoCongTyLienKetLienDoanh = (string)dr["LaiLoCongTyLienKetLienDoanh"],
                    ChiPhiHoatDong = (string)dr["ChiPhiHoatDong"],
                    ChiPhiNhanVien = (string)dr["ChiPhiNhanVien"],
                    ChiPhiKhauHao = (string)dr["ChiPhiKhauHao"],
                    ChiPhiHoatDongKhac01 = (string)dr["ChiPhiHoatDongKhac01"],
                    LoiNhuanRongTuHDKinhDoanh = (string)dr["LoiNhuanRongTuHDKinhDoanh"],
                    ChiPhiDuPhong = (string)dr["ChiPhiDuPhong"],
                    ChiPhiDuPhongRuiRoTinDung = (string)dr["ChiPhiDuPhongRuiRoTinDung"],
                    KhoanXuLytheoCauTrucNganHang = (string)dr["KhoanXuLytheoCauTrucNganHang"],
                    DuPhongChungCacKhoanCamKetVaNo = (string)dr["DuPhongChungCacKhoanCamKetVaNo"],
                    DuPhongGiamGiaChungKhoan = (string)dr["DuPhongGiamGiaChungKhoan"],
                    ThuHoiNoDaXuLy = (string)dr["ThuHoiNoDaXuLy"],
                    TongLoiNhuanKeToan = (string)dr["TongLoiNhuanKeToan"],
                    ThuNhapTuCacKhoanNo = (string)dr["ThuNhapTuCacKhoanNo"],
                    LoiNhuanTuCacCTLienKet = (string)dr["LoiNhuanTuCacCTLienKet"],
                    TongLoiNhuanTruocThue = (string)dr["TongLoiNhuanTruocThue"],
                    ChiPhiThueTNDN = (string)dr["ChiPhiThueTNDN"],
                    ChiPhiThueHienThanh = (string)dr["ChiPhiThueHienThanh"],
                    ChiPhiThueHoanLai = (string)dr["ChiPhiThueHoanLai"],
                    LoiNhuanSauThue = (string)dr["LoiNhuanSauThue"],
                    LoiIchCoDongThieuSo = (string)dr["LoiIchCoDongThieuSo"],
                    LoiNhuanSauThueCoDongCTme = (string)dr["LoiNhuanSauThueCoDongCTme"],
                    LaiCoBanCoPhieu = (string)dr["LaiCoBanCoPhieu"],
                    LaiLoSuyGiamCoPhieu = (string)dr["LaiLoSuyGiamCoPhieu"]

                };
                BIDV.Add(bidv);
            }
            con.Close();
            return BIDV;
        }

        public List<Data> SelectByNamVP_Bank(string Nam)
        {
            List<Data> BIDV = new List<Data>();
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string strCom = "select * from VP_Bank where Nam like @Nam";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@Nam", "%" + Nam + "%"));
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Data bidv = new Data()
                {
                    Nam = (string)dr["Nam"],
                    Quy = (string)dr["Quy"],
                    ThuNhapLaiRong = (string)dr["ThuNhapLaiRong"],
                    ThuNhapLaiVaCacKhoanThuNhap = (string)dr["ThuNhapLaiVaCacKhoanThuNhap"],
                    ChiPhiLaiVaKhoanChiPhiTuongTu = (string)dr["ChiPhiLaiVaKhoanChiPhiTuongTu"],
                    LaiLoRongTuHDDichVu = (string)dr["LaiLoRongTuHDDichVu"],
                    ThuNhapTuDV = (string)dr["ThuNhapTuDV"],
                    ChiPhiHoatDongDichVu = (string)dr["ChiPhiHoatDongDichVu"],
                    LaiLoTuKDNgoaiHoi = (string)dr["LaiLoTuKDNgoaiHoi"],
                    LaiLoTuMuaChungKhoanKD = (string)dr["LaiLoTuMuaChungKhoanKD"],
                    LaiLoThuanTuMuaBanChungKhoanDauTu = (string)dr["LaiLoThuanTuMuaBanChungKhoanDauTu"],
                    LaiTuHoatDongKhac = (string)dr["LaiTuHoatDongKhac"],
                    ThuNhapHDKhac = (string)dr["ThuNhapHDKhac"],
                    ChiPhiHoatDongKhac = (string)dr["ChiPhiHoatDongKhac"],
                    ThuNhapTuGopVon = (string)dr["ThuNhapTuGopVon"],
                    TongThuNhapKD = (string)dr["TongThuNhapKD"],
                    LaiLoCongTyLienKetLienDoanh = (string)dr["LaiLoCongTyLienKetLienDoanh"],
                    ChiPhiHoatDong = (string)dr["ChiPhiHoatDong"],
                    ChiPhiNhanVien = (string)dr["ChiPhiNhanVien"],
                    ChiPhiKhauHao = (string)dr["ChiPhiKhauHao"],
                    ChiPhiHoatDongKhac01 = (string)dr["ChiPhiHoatDongKhac01"],
                    LoiNhuanRongTuHDKinhDoanh = (string)dr["LoiNhuanRongTuHDKinhDoanh"],
                    ChiPhiDuPhong = (string)dr["ChiPhiDuPhong"],
                    ChiPhiDuPhongRuiRoTinDung = (string)dr["ChiPhiDuPhongRuiRoTinDung"],
                    KhoanXuLytheoCauTrucNganHang = (string)dr["KhoanXuLytheoCauTrucNganHang"],
                    DuPhongChungCacKhoanCamKetVaNo = (string)dr["DuPhongChungCacKhoanCamKetVaNo"],
                    DuPhongGiamGiaChungKhoan = (string)dr["DuPhongGiamGiaChungKhoan"],
                    ThuHoiNoDaXuLy = (string)dr["ThuHoiNoDaXuLy"],
                    TongLoiNhuanKeToan = (string)dr["TongLoiNhuanKeToan"],
                    ThuNhapTuCacKhoanNo = (string)dr["ThuNhapTuCacKhoanNo"],
                    LoiNhuanTuCacCTLienKet = (string)dr["LoiNhuanTuCacCTLienKet"],
                    TongLoiNhuanTruocThue = (string)dr["TongLoiNhuanTruocThue"],
                    ChiPhiThueTNDN = (string)dr["ChiPhiThueTNDN"],
                    ChiPhiThueHienThanh = (string)dr["ChiPhiThueHienThanh"],
                    ChiPhiThueHoanLai = (string)dr["ChiPhiThueHoanLai"],
                    LoiNhuanSauThue = (string)dr["LoiNhuanSauThue"],
                    LoiIchCoDongThieuSo = (string)dr["LoiIchCoDongThieuSo"],
                    LoiNhuanSauThueCoDongCTme = (string)dr["LoiNhuanSauThueCoDongCTme"],
                    LaiCoBanCoPhieu = (string)dr["LaiCoBanCoPhieu"],
                    LaiLoSuyGiamCoPhieu = (string)dr["LaiLoSuyGiamCoPhieu"]

                };
                BIDV.Add(bidv);
            }
            con.Close();
            return BIDV;
        }
    }
}
