using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnChuyenNganhA
{
    public partial class Test2 : Form
    {
        public Test2()
        {
            InitializeComponent();
        }

        private void Test2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.BIDV' table. You can move, or remove it, as needed.
            this.bIDVTableAdapter.Fill(this.dataSet1.BIDV);

            List<Data02> tenVT = new DataBUS().GetAll02();
            cbx_congty.DataSource = tenVT;
            cbx_congty.DisplayMember = "company";
            //List<string> companies = new List<string>() {
            //    "FPT","BIDV","VP_Bank","VinaMilk","Techcom_Bank","Vietcom_Bank","Vietin_Bank","SCB","OCB_Bank","MB_Bank"
            //};
            //comboBox1.DataSource = companies;
            cbx_nam.Text = "chon nam";
            //List<Data> nam = new DataBUS().GetAllBIDV();
            //comboBox2.DataSource = nam;
            //comboBox2.DisplayMember = "Nam";
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbx_congty.Text == "BIDV")
            {
                List<Data> bidv = new DataBUS().GetAllBIDV();
                dgv_data1.DataSource = bidv;
            }
            else if (cbx_congty.Text == "FPT")
            {
                List<Data> FPT = new DataBUS().GetAllFPT();
                dgv_data1.DataSource = FPT;
            }
            else if (cbx_congty.Text == "MB BANK")
            {
                List<Data> vp = new DataBUS().GetAllMB_Bank();
                dgv_data1.DataSource = vp;
            }
            else if (cbx_congty.Text == "OCB BANK")
            {
                List<Data> vp = new DataBUS().GetAllOCB_Bank();
                dgv_data1.DataSource = vp;
            }
            else if (cbx_congty.Text == "SCB")
            {
                List<Data> vp = new DataBUS().GetAllSCB();
                dgv_data1.DataSource = vp;
            }
            else if (cbx_congty.Text == "TECHCOM BANK")
            {
                List<Data> vp = new DataBUS().GetAllTechcom();
                dgv_data1.DataSource = vp;
            }
            else if (cbx_congty.Text == "VIETCOM BANK")
            {
                List<Data> vp = new DataBUS().GetAllVietcom();
                dgv_data1.DataSource = vp;
            }
            else if (cbx_congty.Text == "VIETIN BANK")
            {
                List<Data> vp = new DataBUS().GetAllVietin();
                dgv_data1.DataSource = vp;
            }
            else if (cbx_congty.Text == "VP BANK")
            {
                List<Data> vp = new DataBUS().GetAllVP_Bank();
                dgv_data1.DataSource = vp;
            }
            else if (cbx_congty.Text == "VINA MILK")
            {
                List<Data> vp = new DataBUS().GetAllVP_Bank();
                dgv_data1.DataSource = vp;
            }
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbx_congty.Text == "BIDV")
            {
                string nam = cbx_nam.Text.Trim();
                List<Data> bidv = new DataBUS().GetDetailsBIDV(nam);
                dgv_data1.DataSource = bidv;
                List<Data04> bidv2 = new DataBUS().GetAllBIDV02(nam);
                dgv_data2.DataSource = bidv2;
                
            }
            else if (cbx_congty.Text == "FPT")
            {
                string nam = cbx_nam.Text.Trim();
                List<Data> FPT = new DataBUS().GetDetailsFPT(nam);
                dgv_data1.DataSource = FPT;
                List<Data04> bidv2 = new DataBUS().GetAllFPT02(nam);
                dgv_data2.DataSource = bidv2;
            }
            else if (cbx_congty.Text == "MB BANK")
            {
                string nam = cbx_nam.Text.Trim();
                List<Data> vp = new DataBUS().GetDetailsMB(nam);
                dgv_data1.DataSource = vp;
                List<Data04> bidv2 = new DataBUS().GetAllMB_Bank02(nam);
                dgv_data2.DataSource = bidv2;
            }
            else if (cbx_congty.Text == "OCB BANK")
            {
                string nam = cbx_nam.Text.Trim();
                List<Data> vp = new DataBUS().GetDetailsOCB(nam);
                dgv_data1.DataSource = vp;
                List<Data04> bidv2 = new DataBUS().GetAllOCB02(nam);
                dgv_data2.DataSource = bidv2;
            }
            else if (cbx_congty.Text == "SCB")
            {
                string nam = cbx_nam.Text.Trim();
                List<Data> vp = new DataBUS().GetDetailsSCB(nam);
                dgv_data1.DataSource = vp;
                List<Data04> bidv2 = new DataBUS().GetAllSCB02(nam);
                dgv_data2.DataSource = bidv2;
            }
            else if (cbx_congty.Text == "TECHCOM BANK")
            {
                string nam = cbx_nam.Text.Trim();
                List<Data> vp = new DataBUS().GetDetailsTechcom(nam);
                dgv_data1.DataSource = vp;
                List<Data04> bidv2 = new DataBUS().GetAllTechcom02(nam);
                dgv_data2.DataSource = bidv2;
            }
            else if (cbx_congty.Text == "VIETCOM BANK")
            {
                string nam = cbx_nam.Text.Trim();
                List<Data> vp = new DataBUS().GetDetailsVietcom(nam);
                dgv_data1.DataSource = vp;
                List<Data04> bidv2 = new DataBUS().GetAllVietcom02(nam);
                dgv_data2.DataSource = bidv2;
            }
            else if (cbx_congty.Text == "VIETIN BANK")
            {
                string nam = cbx_nam.Text.Trim();
                List<Data> vp = new DataBUS().GetDetailsVietin(nam);
                dgv_data1.DataSource = vp;
                List<Data04> bidv2 = new DataBUS().GetAllVietin02(nam);
                dgv_data2.DataSource = bidv2;
            }
            else if (cbx_congty.Text == "VP BANK")
            {
                string nam = cbx_nam.Text.Trim();
                List<Data> vp = new DataBUS().GetAllVP_Bank();
                dgv_data1.DataSource = vp;
                List<Data04> bidv2 = new DataBUS().GetAllVP02(nam);
                dgv_data2.DataSource = bidv2;
            }
            else if (cbx_congty.Text == "VINA MILK")
            {
                string nam = cbx_nam.Text.Trim();
                List<Data> vp = new DataBUS().GetDetailsVinaMilk(nam);
                dgv_data1.DataSource = vp;
                List<Data04> bidv2 = new DataBUS().GetAllVinaMilk02(nam);
                dgv_data2.DataSource = bidv2;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new login().Show();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Test().Show();
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ImportData().Show();
        }
    }
}
