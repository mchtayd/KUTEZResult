using DataAccess.Abstract;
using DataAccess.Database;
using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class BraceletDal // : IRepository<Bracelet>
    {
        static BraceletDal braceletDal;
        SqlServices sqlServices;
        SqlDataReader dataReader;

        private BraceletDal()
        {
            sqlServices = SqlDatabase.GetInstance();
        }
        public string Add(Bracelet entity)
        {
            try
            {
                dataReader = sqlServices.StoreReader("BraceletAdd",
                    new SqlParameter("@bracelet", entity.BraceletNo),
                    new SqlParameter("@bigDiameter", entity.BigDiameter),
                    new SqlParameter("@smallDiameter", entity.SmallDiameter));

                dataReader.Close();
                return "OK";
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
                sqlServices.Stored("BraceletDelete", new SqlParameter("@id", id));
                return "OK";
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
                dataReader = sqlServices.StoreReader("BraceletGetList", new SqlParameter("@braceletNo", braceletNo));
                Bracelet item = null;
                while (dataReader.Read())
                {
                    item = new Bracelet(
                        dataReader["ID"].ConInt(),
                        dataReader["BRACELET"].ConInt(),
                        dataReader["BIG_DIAMETER"].ConInt(),
                        dataReader["SMALL_DIAMETER"].ConInt());
                }
                dataReader.Close();
                return item;
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
                List<Bracelet> bracelets = new List<Bracelet>();
                dataReader = sqlServices.StoreReader("BraceletGetList");
                while (dataReader.Read())
                {
                    bracelets.Add(new Bracelet(
                        dataReader["ID"].ConInt(),
                        dataReader["BRACELET"].ConInt(),
                        dataReader["BIG_DIAMETER"].ConInt(),
                        dataReader["SMALL_DIAMETER"].ConInt()));
                }
                dataReader.Close();
                return bracelets;
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
                dataReader = sqlServices.StoreReader("BraceletUpdate",
                    new SqlParameter("@id",entity.Id),
                    new SqlParameter("@bracelet", entity.BraceletNo),
                    new SqlParameter("@bigDiameter", entity.BigDiameter),
                    new SqlParameter("@smallDiameter", entity.SmallDiameter));

                dataReader.Close();
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public static BraceletDal GetInstance()
        {
            if (braceletDal == null)
            {
                braceletDal = new BraceletDal();
            }
            return braceletDal;
        }
    }
}
