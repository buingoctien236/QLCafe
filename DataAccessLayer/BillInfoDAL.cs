using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer;
namespace DataAccessLayer
{
    public class BillInfoDAL
    {
        private static BillInfoDAL instance;
        public static BillInfoDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BillInfoDAL();
                }
                return BillInfoDAL.instance;
            }
            set
            {
                BillInfoDAL.instance = value;
            }
        }

        public BillInfoDAL()
        {

        }

        public void DeleteBillInfoByFoodID(int id)
        {
            DataProvider.Instance.ExecuteQuery("Delete BillInfo where idFood = " +id);
        }
        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("SELECT * FROM billinfo where idBill = " + id);

            foreach (DataRow row in dataTable.Rows)
            {
                BillInfo info = new BillInfo(row);
                listBillInfo.Add(info);
            }

            return listBillInfo;
        }

        public void InsertBillInfo(int idBill, int idFood, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("InsertBillInfo @idBill , @idFood , @count", new object[] { idBill, idFood, count });


        }


    }
}
