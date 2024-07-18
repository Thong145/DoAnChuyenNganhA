using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnChuyenNganhA
{
    class DataBUS
    {
        public List<Data> GetAllBIDV()
        {
            List<Data> bidv = new DataDAO().SelectAllBIDV();
            return bidv;
        }

        public List<Data04> GetAllBIDV02(string nam)
        {
            List<Data04> bidv = new DataDAO().SelectAllBIDV02(nam);
            return bidv;
        }

        public List<Data04> GetAllFPT02(string nam)
        {
            List<Data04> bidv = new DataDAO().SelectAllFPT02(nam);
            return bidv;
        }

        public List<Data04> GetAllMB_Bank02(string nam)
        {
            List<Data04> bidv = new DataDAO().SelectAllMB_Bank02(nam);
            return bidv;
        }

        public List<Data04> GetAllOCB02(string nam)
        {
            List<Data04> bidv = new DataDAO().SelectAllOCB_Bank02(nam);
            return bidv;
        }
        public List<Data04> GetAllSCB02(string nam)
        {
            List<Data04> bidv = new DataDAO().SelectAllSCB02(nam);
            return bidv;
        }
        public List<Data04> GetAllTechcom02(string nam)
        {
            List<Data04> bidv = new DataDAO().SelectAllTechcom02(nam);
            return bidv;
        }
        public List<Data04> GetAllVietcom02(string nam)
        {
            List<Data04> bidv = new DataDAO().SelectAllVietcom_Bank02(nam);
            return bidv;
        }

        public List<Data04> GetAllVietin02(string nam)
        {
            List<Data04> bidv = new DataDAO().SelectAllVietin_Bank02(nam);
            return bidv;
        }

        public List<Data04> GetAllVinaMilk02(string nam)
        {
            List<Data04> bidv = new DataDAO().SelectAllVinamilk02(nam);
            return bidv;
        }

        public List<Data04> GetAllVP02(string nam)
        {
            List<Data04> bidv = new DataDAO().SelectAllVP_Bank02(nam);
            return bidv;
        }

        public List<Data> GetAllFPT()
        {
            List<Data> bidv = new DataDAO().SelectAllFPT();
            return bidv;
        }

        public List<Data> GetAllMB_Bank()
        {
            List<Data> bidv = new DataDAO().SelectAllMB_Bank();
            return bidv;
        }

        public List<Data> GetAllOCB_Bank()
        {
            List<Data> bidv = new DataDAO().SelectAllOCB_Bank();
            return bidv;
        }

        public List<Data> GetAllSCB()
        {
            List<Data> bidv = new DataDAO().SelectAllSCB();
            return bidv;
        }

        public List<Data> GetAllTechcom()
        {
            List<Data> bidv = new DataDAO().SelectAllTechcom_bank();
            return bidv;
        }

        public List<Data> GetAllVietcom()
        {
            List<Data> bidv = new DataDAO().SelectAllVietcom_Bank();
            return bidv;
        }

        public List<Data> GetAllVietin()
        {
            List<Data> bidv = new DataDAO().SelectAllVietin_Bank();
            return bidv;
        }

        public List<Data> GetAllVinamilk()
        {
            List<Data> bidv = new DataDAO().SelectAllVinaMilk();
            return bidv;
        }

        public List<Data> GetAllVP_Bank()
        {
            List<Data> bidv = new DataDAO().SelectAllVP_Bank();
            return bidv;
        }

        public List<Data02> GetAll02()
        {
            List<Data02> bidv = new DataDAO().SelectAll02();
            return bidv;
        }

        public List<Data03> GetAll03()
        {
            List<Data03> bidv = new DataDAO().SelectAll03();
            return bidv;
        }

        public List<Data02> GetDetails(string giatri)
        {
            List<Data02> bidv = new DataDAO().Search(giatri);
            return bidv;
        }

        public List<Data> GetDetailsBIDV(string id)
        {
            List<Data> bidv = new DataDAO().SelectByNamBIDV(id);
            return bidv;
        }

        public List<Data> GetDetailsFPT(string id)
        {
            List<Data> bidv = new DataDAO().SelectByNamFPT(id);
            return bidv;
        }
        public List<Data> GetDetailsMB(string id)
        {
            List<Data> bidv = new DataDAO().SelectByNamMB_Bank(id);
            return bidv;
        }
        public List<Data> GetDetailsOCB(string id)
        {
            List<Data> bidv = new DataDAO().SelectByNamOCB_Bank(id);
            return bidv;
        }
        public List<Data> GetDetailsSCB(string id)
        {
            List<Data> bidv = new DataDAO().SelectByNamSCB(id);
            return bidv;
        }
        public List<Data> GetDetailsTechcom(string id)
        {
            List<Data> bidv = new DataDAO().SelectByNamTechcom(id);
            return bidv;
        }
        public List<Data> GetDetailsVietcom(string id)
        {
            List<Data> bidv = new DataDAO().SelectByNamVietcom(id);
            return bidv;
        }
        public List<Data> GetDetailsVietin(string id)
        {
            List<Data> bidv = new DataDAO().SelectByNamVietin(id);
            return bidv;
        }
        public List<Data> GetDetailsVinaMilk(string id)
        {
            List<Data> bidv = new DataDAO().SelectByNamVinaMilk(id);
            return bidv;
        }
        public List<Data> GetDetailsVP(string id)
        {
            List<Data> bidv = new DataDAO().SelectByNamVP_Bank(id);
            return bidv;
        }
    }
}
