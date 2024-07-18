using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace DoAnChuyenNganhA
{
    public partial class database : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "FszuRvZPyejVLF3WuuRG7a0rzwRGpXPWrCP3M28y",
            BasePath = "https://doanchuyennganha-test-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        public database()
        {
            InitializeComponent();
        }

        private void database_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            if (client != null)
            {
                //lbl_clearfields.Text = "connected";
            }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            #region DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("Chi phí dự phòng");
            dt.Columns.Add("Chi phí dự phòng rủi ro tín dụng");
            dt.Columns.Add("Chi phí hoạt động");
            dt.Columns.Add("Chi phí hoạt động dịch vụ");
            dt.Columns.Add("Chi phí hoạt động khác");
            dt.Columns.Add("Chi phí hoạt động khác_1");
            dt.Columns.Add("Chi phí khấu hao");
            dt.Columns.Add("Chi phí lãi và các khoản chi phí tương tự");
            dt.Columns.Add("Chi phí nhân viên");
            dt.Columns.Add("Chi phí thuế TNDN");
            dt.Columns.Add("Chi phí thuế hiện hành");
            dt.Columns.Add("Chi phí thuế hoãn lại");
            dt.Columns.Add("Các khoản xử lý theo đề tài cấu trúc Ngân hàng");
            dt.Columns.Add("Dự phòng chung cho các khoản cam kết và nợ tiềm tàng");
            dt.Columns.Add("Dự phòng giảm giá chứng khoán");
            dt.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán đầu tư");
            dt.Columns.Add("Lãi lỗ trong công ty liên kết, liên doanh");
            dt.Columns.Add("Lãi cơ bản trên cổ phiếu");
            dt.Columns.Add("Lãi lỗ ròng từ hoạt động dịch vụ");
            dt.Columns.Add("Lãi lỗ ròng từ hoạt động kinh doanh ngoại hối và vàng");
            dt.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán kinh doanh");
            dt.Columns.Add("Lãi suy giảm trên cổ phiếu");
            dt.Columns.Add("Lãi thuần từ hoạt động khác");
            dt.Columns.Add("Lợi nhuận ròng từ hoạt động kinh doanh trước chi phí dự phòng");
            dt.Columns.Add("Lợi nhuận sau thuế");
            dt.Columns.Add("Lợi nhuận sau thuế của cổ đông công ty mẹ");
            dt.Columns.Add("Lợi nhuận được hưởng từ các công ty liên kết và liên doanh");
            dt.Columns.Add("Lợi ích của cổ đông thiểu số");
            dt.Columns.Add("Năm");
            dt.Columns.Add("Quý");
            dt.Columns.Add("Thu hồi nợ đã xử lý bằng nguồn dự phòng");
            dt.Columns.Add("Thu nhập hoạt động khác");
            dt.Columns.Add("Thu nhập lãi ròng");
            dt.Columns.Add("Thu nhập lãi và các khoản thu nhập tương tự");
            dt.Columns.Add("Thu nhập từ các khoản nợ khó đòi");
            dt.Columns.Add("Thu nhập từ góp vốn, mua cổ phần");
            dt.Columns.Add("Thu nhập từ hoạt động dịch vụ");
            dt.Columns.Add("Tổng lợi nhuận kế toán");
            dt.Columns.Add("Tổng lợi nhuận trước thuế");
            dt.Columns.Add("Tổng thu nhập kinh doanh");
            #endregion

            dtg_data.Rows.Clear();
            //FirebaseResponse response = client.Get(@"Counter");
            //int Counter = int.Parse(response.ResultAs<string>());
            for (int i = 0; i <= 43; i++)
            {
                FirebaseResponse res1 = client.Get("data/BIDV/" + i);
                //string n = res1.ResultAs<string>();
                //string n = i.ToString();
                //i = res1.ResultAs<int>();

                //var res2 = client.Get()
                dtg_data.AutoGenerateColumns = true;
                Data d = res1.ResultAs<Data>();
                if (d.Nam != "") // lailoTHUan = chung khoan kinh doanh, lailotumuaCK= chung khoan dau tu
                {
                    dt.Rows.Add(d.Nam, d.Quy, d.ThuNhapLaiRong, d.ThuNhapLaiVaCacKhoanThuNhap, d.ChiPhiLaiVaKhoanChiPhiTuongTu
                        , d.LaiLoRongTuHDDichVu, d.ThuNhapTuDV, d.ChiPhiHoatDongDichVu, d.LaiLoTuKDNgoaiHoi, d.LaiLoThuanTuMuaBanChungKhoanDauTu
                        , d.LaiLoTuMuaChungKhoanKD, d.LaiTuHoatDongKhac, d.ThuNhapHDKhac, d.ChiPhiHoatDongKhac, d.ThuNhapTuGopVon
                        , d.TongThuNhapKD, d.LaiLoCongTyLienKetLienDoanh, d.ChiPhiHoatDong, d.ChiPhiNhanVien, d.ChiPhiKhauHao
                        , d.ChiPhiHoatDongKhac01, d.LoiNhuanRongTuHDKinhDoanh, d.ChiPhiDuPhong, d.ChiPhiDuPhongRuiRoTinDung, d.KhoanXuLytheoCauTrucNganHang, d.DuPhongChungCacKhoanCamKetVaNo
                        , d.DuPhongGiamGiaChungKhoan, d.ThuHoiNoDaXuLy, d.TongLoiNhuanKeToan, d.ThuNhapTuCacKhoanNo, d.LoiNhuanTuCacCTLienKet, d.TongLoiNhuanTruocThue, d.ChiPhiThueTNDN
                        , d.ChiPhiThueHienThanh, d.ChiPhiThueHoanLai, d.LoiNhuanSauThue, d.LoiIchCoDongThieuSo, d.LoiNhuanSauThueCoDongCTme, d.LaiCoBanCoPhieu
                        , d.LaiLoSuyGiamCoPhieu);
                }
            }

            foreach (DataRow item in dt.Rows)
            {
                dtg_data.Rows.Add(item.ItemArray);
            }
        }

        private void btn_fpt_Click(object sender, EventArgs e)
        {
            #region DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("Chi phí dự phòng");
            dt.Columns.Add("Chi phí dự phòng rủi ro tín dụng");
            dt.Columns.Add("Chi phí hoạt động");
            dt.Columns.Add("Chi phí hoạt động dịch vụ");
            dt.Columns.Add("Chi phí hoạt động khác");
            dt.Columns.Add("Chi phí hoạt động khác_1");
            dt.Columns.Add("Chi phí khấu hao");
            dt.Columns.Add("Chi phí lãi và các khoản chi phí tương tự");
            dt.Columns.Add("Chi phí nhân viên");
            dt.Columns.Add("Chi phí thuế TNDN");
            dt.Columns.Add("Chi phí thuế hiện hành");
            dt.Columns.Add("Chi phí thuế hoãn lại");
            dt.Columns.Add("Các khoản xử lý theo đề tài cấu trúc Ngân hàng");
            dt.Columns.Add("Dự phòng chung cho các khoản cam kết và nợ tiềm tàng");
            dt.Columns.Add("Dự phòng giảm giá chứng khoán");
            dt.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán đầu tư");
            dt.Columns.Add("Lãi lỗ trong công ty liên kết, liên doanh");
            dt.Columns.Add("Lãi cơ bản trên cổ phiếu");
            dt.Columns.Add("Lãi lỗ ròng từ hoạt động dịch vụ");
            dt.Columns.Add("Lãi lỗ ròng từ hoạt động kinh doanh ngoại hối và vàng");
            dt.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán kinh doanh");
            dt.Columns.Add("Lãi suy giảm trên cổ phiếu");
            dt.Columns.Add("Lãi thuần từ hoạt động khác");
            dt.Columns.Add("Lợi nhuận ròng từ hoạt động kinh doanh trước chi phí dự phòng");
            dt.Columns.Add("Lợi nhuận sau thuế");
            dt.Columns.Add("Lợi nhuận sau thuế của cổ đông công ty mẹ");
            dt.Columns.Add("Lợi nhuận được hưởng từ các công ty liên kết và liên doanh");
            dt.Columns.Add("Lợi ích của cổ đông thiểu số");
            dt.Columns.Add("Năm");
            dt.Columns.Add("Quý");
            dt.Columns.Add("Thu hồi nợ đã xử lý bằng nguồn dự phòng");
            dt.Columns.Add("Thu nhập hoạt động khác");
            dt.Columns.Add("Thu nhập lãi ròng");
            dt.Columns.Add("Thu nhập lãi và các khoản thu nhập tương tự");
            dt.Columns.Add("Thu nhập từ các khoản nợ khó đòi");
            dt.Columns.Add("Thu nhập từ góp vốn, mua cổ phần");
            dt.Columns.Add("Thu nhập từ hoạt động dịch vụ");
            dt.Columns.Add("Tổng lợi nhuận kế toán");
            dt.Columns.Add("Tổng lợi nhuận trước thuế");
            dt.Columns.Add("Tổng thu nhập kinh doanh");
            #endregion

            dtg_data.Rows.Clear();
            //FirebaseResponse response = client.Get(@"Counter");
            //int Counter = int.Parse(response.ResultAs<string>());
            for (int i = 0; i <= 43; i++)
            {
                FirebaseResponse res1 = client.Get("data/FPT/" + i);
                //string n = res1.ResultAs<string>();
                //string n = i.ToString();
                //i = res1.ResultAs<int>();

                //var res2 = client.Get()
                dtg_data.AutoGenerateColumns = true;
                Data d = res1.ResultAs<Data>();
                if (d.Nam != "") // lailoTHUan = chung khoan kinh doanh, lailotumuaCK= chung khoan dau tu
                {
                    dt.Rows.Add(d.Nam, d.Quy, d.ThuNhapLaiRong, d.ThuNhapLaiVaCacKhoanThuNhap, d.ChiPhiLaiVaKhoanChiPhiTuongTu
                        , d.LaiLoRongTuHDDichVu, d.ThuNhapTuDV, d.ChiPhiHoatDongDichVu, d.LaiLoTuKDNgoaiHoi, d.LaiLoThuanTuMuaBanChungKhoanDauTu
                        , d.LaiLoTuMuaChungKhoanKD, d.LaiTuHoatDongKhac, d.ThuNhapHDKhac, d.ChiPhiHoatDongKhac, d.ThuNhapTuGopVon
                        , d.TongThuNhapKD, d.LaiLoCongTyLienKetLienDoanh, d.ChiPhiHoatDong, d.ChiPhiNhanVien, d.ChiPhiKhauHao
                        , d.ChiPhiHoatDongKhac01, d.LoiNhuanRongTuHDKinhDoanh, d.ChiPhiDuPhong, d.ChiPhiDuPhongRuiRoTinDung, d.KhoanXuLytheoCauTrucNganHang, d.DuPhongChungCacKhoanCamKetVaNo
                        , d.DuPhongGiamGiaChungKhoan, d.ThuHoiNoDaXuLy, d.TongLoiNhuanKeToan, d.ThuNhapTuCacKhoanNo, d.LoiNhuanTuCacCTLienKet, d.TongLoiNhuanTruocThue, d.ChiPhiThueTNDN
                        , d.ChiPhiThueHienThanh, d.ChiPhiThueHoanLai, d.LoiNhuanSauThue, d.LoiIchCoDongThieuSo, d.LoiNhuanSauThueCoDongCTme, d.LaiCoBanCoPhieu
                        , d.LaiLoSuyGiamCoPhieu);
                }
            }

            foreach (DataRow item in dt.Rows)
            {
                dtg_data.Rows.Add(item.ItemArray);
            }
        }

        private void btn_mbb_Click(object sender, EventArgs e)
        {
            #region DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("Chi phí dự phòng");
            dt.Columns.Add("Chi phí dự phòng rủi ro tín dụng");
            dt.Columns.Add("Chi phí hoạt động");
            dt.Columns.Add("Chi phí hoạt động dịch vụ");
            dt.Columns.Add("Chi phí hoạt động khác");
            dt.Columns.Add("Chi phí hoạt động khác_1");
            dt.Columns.Add("Chi phí khấu hao");
            dt.Columns.Add("Chi phí lãi và các khoản chi phí tương tự");
            dt.Columns.Add("Chi phí nhân viên");
            dt.Columns.Add("Chi phí thuế TNDN");
            dt.Columns.Add("Chi phí thuế hiện hành");
            dt.Columns.Add("Chi phí thuế hoãn lại");
            dt.Columns.Add("Các khoản xử lý theo đề tài cấu trúc Ngân hàng");
            dt.Columns.Add("Dự phòng chung cho các khoản cam kết và nợ tiềm tàng");
            dt.Columns.Add("Dự phòng giảm giá chứng khoán");
            dt.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán đầu tư");
            dt.Columns.Add("Lãi lỗ trong công ty liên kết, liên doanh");
            dt.Columns.Add("Lãi cơ bản trên cổ phiếu");
            dt.Columns.Add("Lãi lỗ ròng từ hoạt động dịch vụ");
            dt.Columns.Add("Lãi lỗ ròng từ hoạt động kinh doanh ngoại hối và vàng");
            dt.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán kinh doanh");
            dt.Columns.Add("Lãi suy giảm trên cổ phiếu");
            dt.Columns.Add("Lãi thuần từ hoạt động khác");
            dt.Columns.Add("Lợi nhuận ròng từ hoạt động kinh doanh trước chi phí dự phòng");
            dt.Columns.Add("Lợi nhuận sau thuế");
            dt.Columns.Add("Lợi nhuận sau thuế của cổ đông công ty mẹ");
            dt.Columns.Add("Lợi nhuận được hưởng từ các công ty liên kết và liên doanh");
            dt.Columns.Add("Lợi ích của cổ đông thiểu số");
            dt.Columns.Add("Năm");
            dt.Columns.Add("Quý");
            dt.Columns.Add("Thu hồi nợ đã xử lý bằng nguồn dự phòng");
            dt.Columns.Add("Thu nhập hoạt động khác");
            dt.Columns.Add("Thu nhập lãi ròng");
            dt.Columns.Add("Thu nhập lãi và các khoản thu nhập tương tự");
            dt.Columns.Add("Thu nhập từ các khoản nợ khó đòi");
            dt.Columns.Add("Thu nhập từ góp vốn, mua cổ phần");
            dt.Columns.Add("Thu nhập từ hoạt động dịch vụ");
            dt.Columns.Add("Tổng lợi nhuận kế toán");
            dt.Columns.Add("Tổng lợi nhuận trước thuế");
            dt.Columns.Add("Tổng thu nhập kinh doanh");
            #endregion

            dtg_data.Rows.Clear();
            //FirebaseResponse response = client.Get(@"Counter");
            //int Counter = int.Parse(response.ResultAs<string>());
            for (int i = 0; i <= 43; i++)
            {
                FirebaseResponse res1 = client.Get("data/MB Bank/" + i);
                //string n = res1.ResultAs<string>();
                //string n = i.ToString();
                //i = res1.ResultAs<int>();

                //var res2 = client.Get()
                dtg_data.AutoGenerateColumns = true;
                Data d = res1.ResultAs<Data>();
                if (d.Nam != "") // lailoTHUan = chung khoan kinh doanh, lailotumuaCK= chung khoan dau tu
                {
                    dt.Rows.Add(d.Nam, d.Quy, d.ThuNhapLaiRong, d.ThuNhapLaiVaCacKhoanThuNhap, d.ChiPhiLaiVaKhoanChiPhiTuongTu
                        , d.LaiLoRongTuHDDichVu, d.ThuNhapTuDV, d.ChiPhiHoatDongDichVu, d.LaiLoTuKDNgoaiHoi, d.LaiLoThuanTuMuaBanChungKhoanDauTu
                        , d.LaiLoTuMuaChungKhoanKD, d.LaiTuHoatDongKhac, d.ThuNhapHDKhac, d.ChiPhiHoatDongKhac, d.ThuNhapTuGopVon
                        , d.TongThuNhapKD, d.LaiLoCongTyLienKetLienDoanh, d.ChiPhiHoatDong, d.ChiPhiNhanVien, d.ChiPhiKhauHao
                        , d.ChiPhiHoatDongKhac01, d.LoiNhuanRongTuHDKinhDoanh, d.ChiPhiDuPhong, d.ChiPhiDuPhongRuiRoTinDung, d.KhoanXuLytheoCauTrucNganHang, d.DuPhongChungCacKhoanCamKetVaNo
                        , d.DuPhongGiamGiaChungKhoan, d.ThuHoiNoDaXuLy, d.TongLoiNhuanKeToan, d.ThuNhapTuCacKhoanNo, d.LoiNhuanTuCacCTLienKet, d.TongLoiNhuanTruocThue, d.ChiPhiThueTNDN
                        , d.ChiPhiThueHienThanh, d.ChiPhiThueHoanLai, d.LoiNhuanSauThue, d.LoiIchCoDongThieuSo, d.LoiNhuanSauThueCoDongCTme, d.LaiCoBanCoPhieu
                        , d.LaiLoSuyGiamCoPhieu);
                }
            }

            foreach (DataRow item in dt.Rows)
            {
                dtg_data.Rows.Add(item.ItemArray);
            }
        }

        private void btn_ocb_Click(object sender, EventArgs e)
        {
            #region DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("Chi phí dự phòng");
            dt.Columns.Add("Chi phí dự phòng rủi ro tín dụng");
            dt.Columns.Add("Chi phí hoạt động");
            dt.Columns.Add("Chi phí hoạt động dịch vụ");
            dt.Columns.Add("Chi phí hoạt động khác");
            dt.Columns.Add("Chi phí hoạt động khác_1");
            dt.Columns.Add("Chi phí khấu hao");
            dt.Columns.Add("Chi phí lãi và các khoản chi phí tương tự");
            dt.Columns.Add("Chi phí nhân viên");
            dt.Columns.Add("Chi phí thuế TNDN");
            dt.Columns.Add("Chi phí thuế hiện hành");
            dt.Columns.Add("Chi phí thuế hoãn lại");
            dt.Columns.Add("Các khoản xử lý theo đề tài cấu trúc Ngân hàng");
            dt.Columns.Add("Dự phòng chung cho các khoản cam kết và nợ tiềm tàng");
            dt.Columns.Add("Dự phòng giảm giá chứng khoán");
            dt.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán đầu tư");
            dt.Columns.Add("Lãi lỗ trong công ty liên kết, liên doanh");
            dt.Columns.Add("Lãi cơ bản trên cổ phiếu");
            dt.Columns.Add("Lãi lỗ ròng từ hoạt động dịch vụ");
            dt.Columns.Add("Lãi lỗ ròng từ hoạt động kinh doanh ngoại hối và vàng");
            dt.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán kinh doanh");
            dt.Columns.Add("Lãi suy giảm trên cổ phiếu");
            dt.Columns.Add("Lãi thuần từ hoạt động khác");
            dt.Columns.Add("Lợi nhuận ròng từ hoạt động kinh doanh trước chi phí dự phòng");
            dt.Columns.Add("Lợi nhuận sau thuế");
            dt.Columns.Add("Lợi nhuận sau thuế của cổ đông công ty mẹ");
            dt.Columns.Add("Lợi nhuận được hưởng từ các công ty liên kết và liên doanh");
            dt.Columns.Add("Lợi ích của cổ đông thiểu số");
            dt.Columns.Add("Năm");
            dt.Columns.Add("Quý");
            dt.Columns.Add("Thu hồi nợ đã xử lý bằng nguồn dự phòng");
            dt.Columns.Add("Thu nhập hoạt động khác");
            dt.Columns.Add("Thu nhập lãi ròng");
            dt.Columns.Add("Thu nhập lãi và các khoản thu nhập tương tự");
            dt.Columns.Add("Thu nhập từ các khoản nợ khó đòi");
            dt.Columns.Add("Thu nhập từ góp vốn, mua cổ phần");
            dt.Columns.Add("Thu nhập từ hoạt động dịch vụ");
            dt.Columns.Add("Tổng lợi nhuận kế toán");
            dt.Columns.Add("Tổng lợi nhuận trước thuế");
            dt.Columns.Add("Tổng thu nhập kinh doanh");
            #endregion

            dtg_data.Rows.Clear();
            //FirebaseResponse response = client.Get(@"Counter");
            //int Counter = int.Parse(response.ResultAs<string>());
            for (int i = 0; i <= 43; i++)
            {
                FirebaseResponse res1 = client.Get("data/OCB Bank/" + i);
                //string n = res1.ResultAs<string>();
                //string n = i.ToString();
                //i = res1.ResultAs<int>();

                //var res2 = client.Get()
                dtg_data.AutoGenerateColumns = true;
                Data d = res1.ResultAs<Data>();
                if (d.Nam != "") // lailoTHUan = chung khoan kinh doanh, lailotumuaCK= chung khoan dau tu
                {
                    dt.Rows.Add(d.Nam, d.Quy, d.ThuNhapLaiRong, d.ThuNhapLaiVaCacKhoanThuNhap, d.ChiPhiLaiVaKhoanChiPhiTuongTu
                        , d.LaiLoRongTuHDDichVu, d.ThuNhapTuDV, d.ChiPhiHoatDongDichVu, d.LaiLoTuKDNgoaiHoi, d.LaiLoThuanTuMuaBanChungKhoanDauTu
                        , d.LaiLoTuMuaChungKhoanKD, d.LaiTuHoatDongKhac, d.ThuNhapHDKhac, d.ChiPhiHoatDongKhac, d.ThuNhapTuGopVon
                        , d.TongThuNhapKD, d.LaiLoCongTyLienKetLienDoanh, d.ChiPhiHoatDong, d.ChiPhiNhanVien, d.ChiPhiKhauHao
                        , d.ChiPhiHoatDongKhac01, d.LoiNhuanRongTuHDKinhDoanh, d.ChiPhiDuPhong, d.ChiPhiDuPhongRuiRoTinDung, d.KhoanXuLytheoCauTrucNganHang, d.DuPhongChungCacKhoanCamKetVaNo
                        , d.DuPhongGiamGiaChungKhoan, d.ThuHoiNoDaXuLy, d.TongLoiNhuanKeToan, d.ThuNhapTuCacKhoanNo, d.LoiNhuanTuCacCTLienKet, d.TongLoiNhuanTruocThue, d.ChiPhiThueTNDN
                        , d.ChiPhiThueHienThanh, d.ChiPhiThueHoanLai, d.LoiNhuanSauThue, d.LoiIchCoDongThieuSo, d.LoiNhuanSauThueCoDongCTme, d.LaiCoBanCoPhieu
                        , d.LaiLoSuyGiamCoPhieu);
                }
            }

            foreach (DataRow item in dt.Rows)
            {
                dtg_data.Rows.Add(item.ItemArray);
            }
        }

        private void btn_scb_Click(object sender, EventArgs e)
        {
            #region DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("Chi phí dự phòng");
            dt.Columns.Add("Chi phí dự phòng rủi ro tín dụng");
            dt.Columns.Add("Chi phí hoạt động");
            dt.Columns.Add("Chi phí hoạt động dịch vụ");
            dt.Columns.Add("Chi phí hoạt động khác");
            dt.Columns.Add("Chi phí hoạt động khác_1");
            dt.Columns.Add("Chi phí khấu hao");
            dt.Columns.Add("Chi phí lãi và các khoản chi phí tương tự");
            dt.Columns.Add("Chi phí nhân viên");
            dt.Columns.Add("Chi phí thuế TNDN");
            dt.Columns.Add("Chi phí thuế hiện hành");
            dt.Columns.Add("Chi phí thuế hoãn lại");
            dt.Columns.Add("Các khoản xử lý theo đề tài cấu trúc Ngân hàng");
            dt.Columns.Add("Dự phòng chung cho các khoản cam kết và nợ tiềm tàng");
            dt.Columns.Add("Dự phòng giảm giá chứng khoán");
            dt.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán đầu tư");
            dt.Columns.Add("Lãi lỗ trong công ty liên kết, liên doanh");
            dt.Columns.Add("Lãi cơ bản trên cổ phiếu");
            dt.Columns.Add("Lãi lỗ ròng từ hoạt động dịch vụ");
            dt.Columns.Add("Lãi lỗ ròng từ hoạt động kinh doanh ngoại hối và vàng");
            dt.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán kinh doanh");
            dt.Columns.Add("Lãi suy giảm trên cổ phiếu");
            dt.Columns.Add("Lãi thuần từ hoạt động khác");
            dt.Columns.Add("Lợi nhuận ròng từ hoạt động kinh doanh trước chi phí dự phòng");
            dt.Columns.Add("Lợi nhuận sau thuế");
            dt.Columns.Add("Lợi nhuận sau thuế của cổ đông công ty mẹ");
            dt.Columns.Add("Lợi nhuận được hưởng từ các công ty liên kết và liên doanh");
            dt.Columns.Add("Lợi ích của cổ đông thiểu số");
            dt.Columns.Add("Năm");
            dt.Columns.Add("Quý");
            dt.Columns.Add("Thu hồi nợ đã xử lý bằng nguồn dự phòng");
            dt.Columns.Add("Thu nhập hoạt động khác");
            dt.Columns.Add("Thu nhập lãi ròng");
            dt.Columns.Add("Thu nhập lãi và các khoản thu nhập tương tự");
            dt.Columns.Add("Thu nhập từ các khoản nợ khó đòi");
            dt.Columns.Add("Thu nhập từ góp vốn, mua cổ phần");
            dt.Columns.Add("Thu nhập từ hoạt động dịch vụ");
            dt.Columns.Add("Tổng lợi nhuận kế toán");
            dt.Columns.Add("Tổng lợi nhuận trước thuế");
            dt.Columns.Add("Tổng thu nhập kinh doanh");
            #endregion

            dtg_data.Rows.Clear();
            //FirebaseResponse response = client.Get(@"Counter");
            //int Counter = int.Parse(response.ResultAs<string>());
            for (int i = 0; i <= 43; i++)
            {
                FirebaseResponse res1 = client.Get("data/SCB/" + i);
                //string n = res1.ResultAs<string>();
                //string n = i.ToString();
                //i = res1.ResultAs<int>();

                //var res2 = client.Get()
                dtg_data.AutoGenerateColumns = true;
                Data d = res1.ResultAs<Data>();
                if (d.Nam != "") // lailoTHUan = chung khoan kinh doanh, lailotumuaCK= chung khoan dau tu
                {
                    dt.Rows.Add(d.Nam, d.Quy, d.ThuNhapLaiRong, d.ThuNhapLaiVaCacKhoanThuNhap, d.ChiPhiLaiVaKhoanChiPhiTuongTu
                        , d.LaiLoRongTuHDDichVu, d.ThuNhapTuDV, d.ChiPhiHoatDongDichVu, d.LaiLoTuKDNgoaiHoi, d.LaiLoThuanTuMuaBanChungKhoanDauTu
                        , d.LaiLoTuMuaChungKhoanKD, d.LaiTuHoatDongKhac, d.ThuNhapHDKhac, d.ChiPhiHoatDongKhac, d.ThuNhapTuGopVon
                        , d.TongThuNhapKD, d.LaiLoCongTyLienKetLienDoanh, d.ChiPhiHoatDong, d.ChiPhiNhanVien, d.ChiPhiKhauHao
                        , d.ChiPhiHoatDongKhac01, d.LoiNhuanRongTuHDKinhDoanh, d.ChiPhiDuPhong, d.ChiPhiDuPhongRuiRoTinDung, d.KhoanXuLytheoCauTrucNganHang, d.DuPhongChungCacKhoanCamKetVaNo
                        , d.DuPhongGiamGiaChungKhoan, d.ThuHoiNoDaXuLy, d.TongLoiNhuanKeToan, d.ThuNhapTuCacKhoanNo, d.LoiNhuanTuCacCTLienKet, d.TongLoiNhuanTruocThue, d.ChiPhiThueTNDN
                        , d.ChiPhiThueHienThanh, d.ChiPhiThueHoanLai, d.LoiNhuanSauThue, d.LoiIchCoDongThieuSo, d.LoiNhuanSauThueCoDongCTme, d.LaiCoBanCoPhieu
                        , d.LaiLoSuyGiamCoPhieu);
                }
            }

            foreach (DataRow item in dt.Rows)
            {
                dtg_data.Rows.Add(item.ItemArray);
            }
        }

        private void btn_techcom_Click(object sender, EventArgs e)
        {
            #region DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("Chi phí dự phòng");
            dt.Columns.Add("Chi phí dự phòng rủi ro tín dụng");
            dt.Columns.Add("Chi phí hoạt động");
            dt.Columns.Add("Chi phí hoạt động dịch vụ");
            dt.Columns.Add("Chi phí hoạt động khác");
            dt.Columns.Add("Chi phí hoạt động khác_1");
            dt.Columns.Add("Chi phí khấu hao");
            dt.Columns.Add("Chi phí lãi và các khoản chi phí tương tự");
            dt.Columns.Add("Chi phí nhân viên");
            dt.Columns.Add("Chi phí thuế TNDN");
            dt.Columns.Add("Chi phí thuế hiện hành");
            dt.Columns.Add("Chi phí thuế hoãn lại");
            dt.Columns.Add("Các khoản xử lý theo đề tài cấu trúc Ngân hàng");
            dt.Columns.Add("Dự phòng chung cho các khoản cam kết và nợ tiềm tàng");
            dt.Columns.Add("Dự phòng giảm giá chứng khoán");
            dt.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán đầu tư");
            dt.Columns.Add("Lãi lỗ trong công ty liên kết, liên doanh");
            dt.Columns.Add("Lãi cơ bản trên cổ phiếu");
            dt.Columns.Add("Lãi lỗ ròng từ hoạt động dịch vụ");
            dt.Columns.Add("Lãi lỗ ròng từ hoạt động kinh doanh ngoại hối và vàng");
            dt.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán kinh doanh");
            dt.Columns.Add("Lãi suy giảm trên cổ phiếu");
            dt.Columns.Add("Lãi thuần từ hoạt động khác");
            dt.Columns.Add("Lợi nhuận ròng từ hoạt động kinh doanh trước chi phí dự phòng");
            dt.Columns.Add("Lợi nhuận sau thuế");
            dt.Columns.Add("Lợi nhuận sau thuế của cổ đông công ty mẹ");
            dt.Columns.Add("Lợi nhuận được hưởng từ các công ty liên kết và liên doanh");
            dt.Columns.Add("Lợi ích của cổ đông thiểu số");
            dt.Columns.Add("Năm");
            dt.Columns.Add("Quý");
            dt.Columns.Add("Thu hồi nợ đã xử lý bằng nguồn dự phòng");
            dt.Columns.Add("Thu nhập hoạt động khác");
            dt.Columns.Add("Thu nhập lãi ròng");
            dt.Columns.Add("Thu nhập lãi và các khoản thu nhập tương tự");
            dt.Columns.Add("Thu nhập từ các khoản nợ khó đòi");
            dt.Columns.Add("Thu nhập từ góp vốn, mua cổ phần");
            dt.Columns.Add("Thu nhập từ hoạt động dịch vụ");
            dt.Columns.Add("Tổng lợi nhuận kế toán");
            dt.Columns.Add("Tổng lợi nhuận trước thuế");
            dt.Columns.Add("Tổng thu nhập kinh doanh");
            #endregion

            dtg_data.Rows.Clear();
            //FirebaseResponse response = client.Get(@"Counter");
            //int Counter = int.Parse(response.ResultAs<string>());
            for (int i = 0; i <= 43; i++)
            {
                FirebaseResponse res1 = client.Get("data/Techcom Bank/" + i);
                //string n = res1.ResultAs<string>();
                //string n = i.ToString();
                //i = res1.ResultAs<int>();

                //var res2 = client.Get()
                dtg_data.AutoGenerateColumns = true;
                Data d = res1.ResultAs<Data>();
                if (d.Nam != "") // lailoTHUan = chung khoan kinh doanh, lailotumuaCK= chung khoan dau tu
                {
                    dt.Rows.Add(d.Nam, d.Quy, d.ThuNhapLaiRong, d.ThuNhapLaiVaCacKhoanThuNhap, d.ChiPhiLaiVaKhoanChiPhiTuongTu
                        , d.LaiLoRongTuHDDichVu, d.ThuNhapTuDV, d.ChiPhiHoatDongDichVu, d.LaiLoTuKDNgoaiHoi, d.LaiLoThuanTuMuaBanChungKhoanDauTu
                        , d.LaiLoTuMuaChungKhoanKD, d.LaiTuHoatDongKhac, d.ThuNhapHDKhac, d.ChiPhiHoatDongKhac, d.ThuNhapTuGopVon
                        , d.TongThuNhapKD, d.LaiLoCongTyLienKetLienDoanh, d.ChiPhiHoatDong, d.ChiPhiNhanVien, d.ChiPhiKhauHao
                        , d.ChiPhiHoatDongKhac01, d.LoiNhuanRongTuHDKinhDoanh, d.ChiPhiDuPhong, d.ChiPhiDuPhongRuiRoTinDung, d.KhoanXuLytheoCauTrucNganHang, d.DuPhongChungCacKhoanCamKetVaNo
                        , d.DuPhongGiamGiaChungKhoan, d.ThuHoiNoDaXuLy, d.TongLoiNhuanKeToan, d.ThuNhapTuCacKhoanNo, d.LoiNhuanTuCacCTLienKet, d.TongLoiNhuanTruocThue, d.ChiPhiThueTNDN
                        , d.ChiPhiThueHienThanh, d.ChiPhiThueHoanLai, d.LoiNhuanSauThue, d.LoiIchCoDongThieuSo, d.LoiNhuanSauThueCoDongCTme, d.LaiCoBanCoPhieu
                        , d.LaiLoSuyGiamCoPhieu);
                }
            }

            foreach (DataRow item in dt.Rows)
            {
                dtg_data.Rows.Add(item.ItemArray);
            }
        }

        private void btn_vp_Click(object sender, EventArgs e)
        {
            #region DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("Chi phí dự phòng");
            dt.Columns.Add("Chi phí dự phòng rủi ro tín dụng");
            dt.Columns.Add("Chi phí hoạt động");
            dt.Columns.Add("Chi phí hoạt động dịch vụ");
            dt.Columns.Add("Chi phí hoạt động khác");
            dt.Columns.Add("Chi phí hoạt động khác_1");
            dt.Columns.Add("Chi phí khấu hao");
            dt.Columns.Add("Chi phí lãi và các khoản chi phí tương tự");
            dt.Columns.Add("Chi phí nhân viên");
            dt.Columns.Add("Chi phí thuế TNDN");
            dt.Columns.Add("Chi phí thuế hiện hành");
            dt.Columns.Add("Chi phí thuế hoãn lại");
            dt.Columns.Add("Các khoản xử lý theo đề tài cấu trúc Ngân hàng");
            dt.Columns.Add("Dự phòng chung cho các khoản cam kết và nợ tiềm tàng");
            dt.Columns.Add("Dự phòng giảm giá chứng khoán");
            dt.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán đầu tư");
            dt.Columns.Add("Lãi lỗ trong công ty liên kết, liên doanh");
            dt.Columns.Add("Lãi cơ bản trên cổ phiếu");
            dt.Columns.Add("Lãi lỗ ròng từ hoạt động dịch vụ");
            dt.Columns.Add("Lãi lỗ ròng từ hoạt động kinh doanh ngoại hối và vàng");
            dt.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán kinh doanh");
            dt.Columns.Add("Lãi suy giảm trên cổ phiếu");
            dt.Columns.Add("Lãi thuần từ hoạt động khác");
            dt.Columns.Add("Lợi nhuận ròng từ hoạt động kinh doanh trước chi phí dự phòng");
            dt.Columns.Add("Lợi nhuận sau thuế");
            dt.Columns.Add("Lợi nhuận sau thuế của cổ đông công ty mẹ");
            dt.Columns.Add("Lợi nhuận được hưởng từ các công ty liên kết và liên doanh");
            dt.Columns.Add("Lợi ích của cổ đông thiểu số");
            dt.Columns.Add("Năm");
            dt.Columns.Add("Quý");
            dt.Columns.Add("Thu hồi nợ đã xử lý bằng nguồn dự phòng");
            dt.Columns.Add("Thu nhập hoạt động khác");
            dt.Columns.Add("Thu nhập lãi ròng");
            dt.Columns.Add("Thu nhập lãi và các khoản thu nhập tương tự");
            dt.Columns.Add("Thu nhập từ các khoản nợ khó đòi");
            dt.Columns.Add("Thu nhập từ góp vốn, mua cổ phần");
            dt.Columns.Add("Thu nhập từ hoạt động dịch vụ");
            dt.Columns.Add("Tổng lợi nhuận kế toán");
            dt.Columns.Add("Tổng lợi nhuận trước thuế");
            dt.Columns.Add("Tổng thu nhập kinh doanh");
            #endregion

            dtg_data.Rows.Clear();
            //FirebaseResponse response = client.Get(@"Counter");
            //int Counter = int.Parse(response.ResultAs<string>());
            for (int i = 0; i <= 43; i++)
            {
                FirebaseResponse res1 = client.Get("data/VP Bank/" + i);
                //string n = res1.ResultAs<string>();
                //string n = i.ToString();
                //i = res1.ResultAs<int>();

                //var res2 = client.Get()
                dtg_data.AutoGenerateColumns = true;
                Data d = res1.ResultAs<Data>();
                if (d.Nam != "") // lailoTHUan = chung khoan kinh doanh, lailotumuaCK= chung khoan dau tu
                {
                    dt.Rows.Add(d.Nam, d.Quy, d.ThuNhapLaiRong, d.ThuNhapLaiVaCacKhoanThuNhap, d.ChiPhiLaiVaKhoanChiPhiTuongTu
                        , d.LaiLoRongTuHDDichVu, d.ThuNhapTuDV, d.ChiPhiHoatDongDichVu, d.LaiLoTuKDNgoaiHoi, d.LaiLoThuanTuMuaBanChungKhoanDauTu
                        , d.LaiLoTuMuaChungKhoanKD, d.LaiTuHoatDongKhac, d.ThuNhapHDKhac, d.ChiPhiHoatDongKhac, d.ThuNhapTuGopVon
                        , d.TongThuNhapKD, d.LaiLoCongTyLienKetLienDoanh, d.ChiPhiHoatDong, d.ChiPhiNhanVien, d.ChiPhiKhauHao
                        , d.ChiPhiHoatDongKhac01, d.LoiNhuanRongTuHDKinhDoanh, d.ChiPhiDuPhong, d.ChiPhiDuPhongRuiRoTinDung, d.KhoanXuLytheoCauTrucNganHang, d.DuPhongChungCacKhoanCamKetVaNo
                        , d.DuPhongGiamGiaChungKhoan, d.ThuHoiNoDaXuLy, d.TongLoiNhuanKeToan, d.ThuNhapTuCacKhoanNo, d.LoiNhuanTuCacCTLienKet, d.TongLoiNhuanTruocThue, d.ChiPhiThueTNDN
                        , d.ChiPhiThueHienThanh, d.ChiPhiThueHoanLai, d.LoiNhuanSauThue, d.LoiIchCoDongThieuSo, d.LoiNhuanSauThueCoDongCTme, d.LaiCoBanCoPhieu
                        , d.LaiLoSuyGiamCoPhieu);
                }
            }

            foreach (DataRow item in dt.Rows)
            {
                dtg_data.Rows.Add(item.ItemArray);
            }
        }

        private void btn_vietcom_Click(object sender, EventArgs e)
        {
            #region DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("Chi phí dự phòng");
            dt.Columns.Add("Chi phí dự phòng rủi ro tín dụng");
            dt.Columns.Add("Chi phí hoạt động");
            dt.Columns.Add("Chi phí hoạt động dịch vụ");
            dt.Columns.Add("Chi phí hoạt động khác");
            dt.Columns.Add("Chi phí hoạt động khác_1");
            dt.Columns.Add("Chi phí khấu hao");
            dt.Columns.Add("Chi phí lãi và các khoản chi phí tương tự");
            dt.Columns.Add("Chi phí nhân viên");
            dt.Columns.Add("Chi phí thuế TNDN");
            dt.Columns.Add("Chi phí thuế hiện hành");
            dt.Columns.Add("Chi phí thuế hoãn lại");
            dt.Columns.Add("Các khoản xử lý theo đề tài cấu trúc Ngân hàng");
            dt.Columns.Add("Dự phòng chung cho các khoản cam kết và nợ tiềm tàng");
            dt.Columns.Add("Dự phòng giảm giá chứng khoán");
            dt.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán đầu tư");
            dt.Columns.Add("Lãi lỗ trong công ty liên kết, liên doanh");
            dt.Columns.Add("Lãi cơ bản trên cổ phiếu");
            dt.Columns.Add("Lãi lỗ ròng từ hoạt động dịch vụ");
            dt.Columns.Add("Lãi lỗ ròng từ hoạt động kinh doanh ngoại hối và vàng");
            dt.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán kinh doanh");
            dt.Columns.Add("Lãi suy giảm trên cổ phiếu");
            dt.Columns.Add("Lãi thuần từ hoạt động khác");
            dt.Columns.Add("Lợi nhuận ròng từ hoạt động kinh doanh trước chi phí dự phòng");
            dt.Columns.Add("Lợi nhuận sau thuế");
            dt.Columns.Add("Lợi nhuận sau thuế của cổ đông công ty mẹ");
            dt.Columns.Add("Lợi nhuận được hưởng từ các công ty liên kết và liên doanh");
            dt.Columns.Add("Lợi ích của cổ đông thiểu số");
            dt.Columns.Add("Năm");
            dt.Columns.Add("Quý");
            dt.Columns.Add("Thu hồi nợ đã xử lý bằng nguồn dự phòng");
            dt.Columns.Add("Thu nhập hoạt động khác");
            dt.Columns.Add("Thu nhập lãi ròng");
            dt.Columns.Add("Thu nhập lãi và các khoản thu nhập tương tự");
            dt.Columns.Add("Thu nhập từ các khoản nợ khó đòi");
            dt.Columns.Add("Thu nhập từ góp vốn, mua cổ phần");
            dt.Columns.Add("Thu nhập từ hoạt động dịch vụ");
            dt.Columns.Add("Tổng lợi nhuận kế toán");
            dt.Columns.Add("Tổng lợi nhuận trước thuế");
            dt.Columns.Add("Tổng thu nhập kinh doanh");
            #endregion

            dtg_data.Rows.Clear();
            //FirebaseResponse response = client.Get(@"Counter");
            //int Counter = int.Parse(response.ResultAs<string>());
            for (int i = 0; i <= 43; i++)
            {
                FirebaseResponse res1 = client.Get("data/Vietcom Bank/" + i);
                //string n = res1.ResultAs<string>();
                //string n = i.ToString();
                //i = res1.ResultAs<int>();

                //var res2 = client.Get()
                dtg_data.AutoGenerateColumns = true;
                Data d = res1.ResultAs<Data>();
                if (d.Nam != "") // lailoTHUan = chung khoan kinh doanh, lailotumuaCK= chung khoan dau tu
                {
                    dt.Rows.Add(d.Nam, d.Quy, d.ThuNhapLaiRong, d.ThuNhapLaiVaCacKhoanThuNhap, d.ChiPhiLaiVaKhoanChiPhiTuongTu
                        , d.LaiLoRongTuHDDichVu, d.ThuNhapTuDV, d.ChiPhiHoatDongDichVu, d.LaiLoTuKDNgoaiHoi, d.LaiLoThuanTuMuaBanChungKhoanDauTu
                        , d.LaiLoTuMuaChungKhoanKD, d.LaiTuHoatDongKhac, d.ThuNhapHDKhac, d.ChiPhiHoatDongKhac, d.ThuNhapTuGopVon
                        , d.TongThuNhapKD, d.LaiLoCongTyLienKetLienDoanh, d.ChiPhiHoatDong, d.ChiPhiNhanVien, d.ChiPhiKhauHao
                        , d.ChiPhiHoatDongKhac01, d.LoiNhuanRongTuHDKinhDoanh, d.ChiPhiDuPhong, d.ChiPhiDuPhongRuiRoTinDung, d.KhoanXuLytheoCauTrucNganHang, d.DuPhongChungCacKhoanCamKetVaNo
                        , d.DuPhongGiamGiaChungKhoan, d.ThuHoiNoDaXuLy, d.TongLoiNhuanKeToan, d.ThuNhapTuCacKhoanNo, d.LoiNhuanTuCacCTLienKet, d.TongLoiNhuanTruocThue, d.ChiPhiThueTNDN
                        , d.ChiPhiThueHienThanh, d.ChiPhiThueHoanLai, d.LoiNhuanSauThue, d.LoiIchCoDongThieuSo, d.LoiNhuanSauThueCoDongCTme, d.LaiCoBanCoPhieu
                        , d.LaiLoSuyGiamCoPhieu);
                }
            }

            foreach (DataRow item in dt.Rows)
            {
                dtg_data.Rows.Add(item.ItemArray);
            }
        }

        private void btn_vietin_Click(object sender, EventArgs e)
        {
            #region DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("Chi phí dự phòng");
            dt.Columns.Add("Chi phí dự phòng rủi ro tín dụng");
            dt.Columns.Add("Chi phí hoạt động");
            dt.Columns.Add("Chi phí hoạt động dịch vụ");
            dt.Columns.Add("Chi phí hoạt động khác");
            dt.Columns.Add("Chi phí hoạt động khác_1");
            dt.Columns.Add("Chi phí khấu hao");
            dt.Columns.Add("Chi phí lãi và các khoản chi phí tương tự");
            dt.Columns.Add("Chi phí nhân viên");
            dt.Columns.Add("Chi phí thuế TNDN");
            dt.Columns.Add("Chi phí thuế hiện hành");
            dt.Columns.Add("Chi phí thuế hoãn lại");
            dt.Columns.Add("Các khoản xử lý theo đề tài cấu trúc Ngân hàng");
            dt.Columns.Add("Dự phòng chung cho các khoản cam kết và nợ tiềm tàng");
            dt.Columns.Add("Dự phòng giảm giá chứng khoán");
            dt.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán đầu tư");
            dt.Columns.Add("Lãi lỗ trong công ty liên kết, liên doanh");
            dt.Columns.Add("Lãi cơ bản trên cổ phiếu");
            dt.Columns.Add("Lãi lỗ ròng từ hoạt động dịch vụ");
            dt.Columns.Add("Lãi lỗ ròng từ hoạt động kinh doanh ngoại hối và vàng");
            dt.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán kinh doanh");
            dt.Columns.Add("Lãi suy giảm trên cổ phiếu");
            dt.Columns.Add("Lãi thuần từ hoạt động khác");
            dt.Columns.Add("Lợi nhuận ròng từ hoạt động kinh doanh trước chi phí dự phòng");
            dt.Columns.Add("Lợi nhuận sau thuế");
            dt.Columns.Add("Lợi nhuận sau thuế của cổ đông công ty mẹ");
            dt.Columns.Add("Lợi nhuận được hưởng từ các công ty liên kết và liên doanh");
            dt.Columns.Add("Lợi ích của cổ đông thiểu số");
            dt.Columns.Add("Năm");
            dt.Columns.Add("Quý");
            dt.Columns.Add("Thu hồi nợ đã xử lý bằng nguồn dự phòng");
            dt.Columns.Add("Thu nhập hoạt động khác");
            dt.Columns.Add("Thu nhập lãi ròng");
            dt.Columns.Add("Thu nhập lãi và các khoản thu nhập tương tự");
            dt.Columns.Add("Thu nhập từ các khoản nợ khó đòi");
            dt.Columns.Add("Thu nhập từ góp vốn, mua cổ phần");
            dt.Columns.Add("Thu nhập từ hoạt động dịch vụ");
            dt.Columns.Add("Tổng lợi nhuận kế toán");
            dt.Columns.Add("Tổng lợi nhuận trước thuế");
            dt.Columns.Add("Tổng thu nhập kinh doanh");
            #endregion

            dtg_data.Rows.Clear();            
            for (int i = 0; i <= 43; i++)
            {
                FirebaseResponse res1 = client.Get("data/Vietin Bank/" + i);
                

                //var res2 = client.Get()
                dtg_data.AutoGenerateColumns = true;
                Data d = res1.ResultAs<Data>();
                if (d.Nam != "") // lailoTHUan = chung khoan kinh doanh, lailotumuaCK= chung khoan dau tu
                {
                    dt.Rows.Add(d.Nam, d.Quy, d.ThuNhapLaiRong, d.ThuNhapLaiVaCacKhoanThuNhap, d.ChiPhiLaiVaKhoanChiPhiTuongTu
                        , d.LaiLoRongTuHDDichVu, d.ThuNhapTuDV, d.ChiPhiHoatDongDichVu, d.LaiLoTuKDNgoaiHoi, d.LaiLoThuanTuMuaBanChungKhoanDauTu
                        , d.LaiLoTuMuaChungKhoanKD, d.LaiTuHoatDongKhac, d.ThuNhapHDKhac, d.ChiPhiHoatDongKhac, d.ThuNhapTuGopVon
                        , d.TongThuNhapKD, d.LaiLoCongTyLienKetLienDoanh, d.ChiPhiHoatDong, d.ChiPhiNhanVien, d.ChiPhiKhauHao
                        , d.ChiPhiHoatDongKhac01, d.LoiNhuanRongTuHDKinhDoanh, d.ChiPhiDuPhong, d.ChiPhiDuPhongRuiRoTinDung, d.KhoanXuLytheoCauTrucNganHang, d.DuPhongChungCacKhoanCamKetVaNo
                        , d.DuPhongGiamGiaChungKhoan, d.ThuHoiNoDaXuLy, d.TongLoiNhuanKeToan, d.ThuNhapTuCacKhoanNo, d.LoiNhuanTuCacCTLienKet, d.TongLoiNhuanTruocThue, d.ChiPhiThueTNDN
                        , d.ChiPhiThueHienThanh, d.ChiPhiThueHoanLai, d.LoiNhuanSauThue, d.LoiIchCoDongThieuSo, d.LoiNhuanSauThueCoDongCTme, d.LaiCoBanCoPhieu
                        , d.LaiLoSuyGiamCoPhieu);
                }
            }

            foreach (DataRow item in dt.Rows)
            {
                dtg_data.Rows.Add(item.ItemArray);
            }
        }

        private void btn_vinamilk_Click(object sender, EventArgs e)
        {
            #region DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("Chi phí dự phòng");
            dt.Columns.Add("Chi phí dự phòng rủi ro tín dụng");
            dt.Columns.Add("Chi phí hoạt động");
            dt.Columns.Add("Chi phí hoạt động dịch vụ");
            dt.Columns.Add("Chi phí hoạt động khác");
            dt.Columns.Add("Chi phí hoạt động khác_1");
            dt.Columns.Add("Chi phí khấu hao");
            dt.Columns.Add("Chi phí lãi và các khoản chi phí tương tự");
            dt.Columns.Add("Chi phí nhân viên");
            dt.Columns.Add("Chi phí thuế TNDN");
            dt.Columns.Add("Chi phí thuế hiện hành");
            dt.Columns.Add("Chi phí thuế hoãn lại");
            dt.Columns.Add("Các khoản xử lý theo đề tài cấu trúc Ngân hàng");
            dt.Columns.Add("Dự phòng chung cho các khoản cam kết và nợ tiềm tàng");
            dt.Columns.Add("Dự phòng giảm giá chứng khoán");
            dt.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán đầu tư");
            dt.Columns.Add("Lãi lỗ trong công ty liên kết, liên doanh");
            dt.Columns.Add("Lãi cơ bản trên cổ phiếu");
            dt.Columns.Add("Lãi lỗ ròng từ hoạt động dịch vụ");
            dt.Columns.Add("Lãi lỗ ròng từ hoạt động kinh doanh ngoại hối và vàng");
            dt.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán kinh doanh");
            dt.Columns.Add("Lãi suy giảm trên cổ phiếu");
            dt.Columns.Add("Lãi thuần từ hoạt động khác");
            dt.Columns.Add("Lợi nhuận ròng từ hoạt động kinh doanh trước chi phí dự phòng");
            dt.Columns.Add("Lợi nhuận sau thuế");
            dt.Columns.Add("Lợi nhuận sau thuế của cổ đông công ty mẹ");
            dt.Columns.Add("Lợi nhuận được hưởng từ các công ty liên kết và liên doanh");
            dt.Columns.Add("Lợi ích của cổ đông thiểu số");
            dt.Columns.Add("Năm");
            dt.Columns.Add("Quý");
            dt.Columns.Add("Thu hồi nợ đã xử lý bằng nguồn dự phòng");
            dt.Columns.Add("Thu nhập hoạt động khác");
            dt.Columns.Add("Thu nhập lãi ròng");
            dt.Columns.Add("Thu nhập lãi và các khoản thu nhập tương tự");
            dt.Columns.Add("Thu nhập từ các khoản nợ khó đòi");
            dt.Columns.Add("Thu nhập từ góp vốn, mua cổ phần");
            dt.Columns.Add("Thu nhập từ hoạt động dịch vụ");
            dt.Columns.Add("Tổng lợi nhuận kế toán");
            dt.Columns.Add("Tổng lợi nhuận trước thuế");
            dt.Columns.Add("Tổng thu nhập kinh doanh");
            #endregion

            dtg_data.Rows.Clear();
            //FirebaseResponse response = client.Get(@"Counter");
            //int Counter = int.Parse(response.ResultAs<string>());
            for (int i = 0; i <= 43; i++)
            {
                FirebaseResponse res1 = client.Get("data/BIDV/" + i);
                //string n = res1.ResultAs<string>();
                //string n = i.ToString();
                //i = res1.ResultAs<int>();

                //var res2 = client.Get()
                dtg_data.AutoGenerateColumns = true;
                Data d = res1.ResultAs<Data>();
                if (d.Nam != "") // lailoTHUan = chung khoan kinh doanh, lailotumuaCK= chung khoan dau tu
                {
                    dt.Rows.Add(d.Nam, d.Quy, d.ThuNhapLaiRong, d.ThuNhapLaiVaCacKhoanThuNhap, d.ChiPhiLaiVaKhoanChiPhiTuongTu
                        , d.LaiLoRongTuHDDichVu, d.ThuNhapTuDV, d.ChiPhiHoatDongDichVu, d.LaiLoTuKDNgoaiHoi, d.LaiLoThuanTuMuaBanChungKhoanDauTu
                        , d.LaiLoTuMuaChungKhoanKD, d.LaiTuHoatDongKhac, d.ThuNhapHDKhac, d.ChiPhiHoatDongKhac, d.ThuNhapTuGopVon
                        , d.TongThuNhapKD, d.LaiLoCongTyLienKetLienDoanh, d.ChiPhiHoatDong, d.ChiPhiNhanVien, d.ChiPhiKhauHao
                        , d.ChiPhiHoatDongKhac01, d.LoiNhuanRongTuHDKinhDoanh, d.ChiPhiDuPhong, d.ChiPhiDuPhongRuiRoTinDung, d.KhoanXuLytheoCauTrucNganHang, d.DuPhongChungCacKhoanCamKetVaNo
                        , d.DuPhongGiamGiaChungKhoan, d.ThuHoiNoDaXuLy, d.TongLoiNhuanKeToan, d.ThuNhapTuCacKhoanNo, d.LoiNhuanTuCacCTLienKet, d.TongLoiNhuanTruocThue, d.ChiPhiThueTNDN
                        , d.ChiPhiThueHienThanh, d.ChiPhiThueHoanLai, d.LoiNhuanSauThue, d.LoiIchCoDongThieuSo, d.LoiNhuanSauThueCoDongCTme, d.LaiCoBanCoPhieu
                        , d.LaiLoSuyGiamCoPhieu);
                }
            }

            foreach (DataRow item in dt.Rows)
            {
                dtg_data.Rows.Add(item.ItemArray);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            new login().Show();
        }
    }
}
