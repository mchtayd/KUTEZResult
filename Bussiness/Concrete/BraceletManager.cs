using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class BraceletManager // : IRepository<Bracelet>
    {
        static BraceletManager braceletManager;
        BraceletDal braceletDal;
        string controlText;

        private BraceletManager()
        {
            braceletDal = BraceletDal.GetInstance();
        }

        public string Add(Bracelet entity)
        {
            try
            {
                controlText = Complete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                return braceletDal.Add(entity);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Delete(int id)
        {
            try
            {
                if (id <= 0)
                {
                    return "Lütfen Geçerli Bir Kayıt Seçiniz!";
                }
                return braceletDal.Delete(id);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Bracelet Get(int braceletNo)
        {
            try
            {
                return braceletDal.Get(braceletNo);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Bracelet> GetList()
        {
            try
            {
                return braceletDal.GetList();
            }
            catch (Exception)
            {
                return new List<Bracelet>();
            }
        }

        public string Update(Bracelet entity)
        {
            try
            {
                controlText = Complete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                return braceletDal.Update(entity);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        string Complete(Bracelet bracelet)
        {
            if (bracelet.BraceletNo == 0)
            {
                return "Lütfen Braceket Numarasını Tanımlayınız!";
            }
            if (bracelet.BigDiameter == 0)
            {
                return "Lütfen Big Diameter Değerini Tanımlayınız!";
            }
            if (bracelet.SmallDiameter == 0)
            {
                return "Lütfen Small Diameter Değerini Tanımlayınız!";
            }

            return "";
        }
        public static BraceletManager GetInstance()
        {
            if (braceletManager == null)
            {
                braceletManager = new BraceletManager();
            }
            return braceletManager;
        }
    }
}
