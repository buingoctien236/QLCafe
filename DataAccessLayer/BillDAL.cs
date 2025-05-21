using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BusinessLogicLayer;
namespace DataAccessLayer

{
    public class BillDAL
    {
        private static BillDAL instance;

        public static BillDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BillDAL();
                }
                return BillDAL.instance;
            }
            set
            {
                BillDAL.instance = value;
            }
        }
        private BillDAL() { }
        public int GetUnckeckBillIdByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Bill where idTable = " + id + " AND status = 0");
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }


        public void CheckOut(int id,float totalPrice)
        {
            string query = "UPDATE dbo.Bill SET dateCheckOut = GetDate(), status = 1,totalPrice ="+totalPrice+"  WHERE id = " +id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void InsertBill(int id)
        {
            
            DataProvider.Instance.ExecuteNonQuery("exec InsertBill @idTable", new object[] { id });
        }


        public int GetMaxIDBill()
        {

            return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(id) FROM dbo.Bill");

        }




        public DataTable GetBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExecuteQuery("exec GetListByDate @DateCheckIn , @DateCheckOut ", new object[] { checkIn, checkOut });
        }
    }
}
