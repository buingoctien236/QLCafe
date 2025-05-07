using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BusinessLogicLayer;
namespace DataAccessLayer

{
    public class InvoiceDAL
    {
        private static InvoiceDAL instance;

        public static InvoiceDAL Instance {
            get
            {
                if (instance == null)
                {
                    instance = new InvoiceDAL();
                }
                return InvoiceDAL.instance;
            }
            set
            {
                InvoiceDAL.instance = value;
            }
        }
        private InvoiceDAL() { }
        public int getHoaDonTheoID(int id) {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM invoices where desks_id = " + id );
            if (data.Rows.Count > 0)
            {
               Invoice invoice = new Invoice(data.Rows[0]);
                return invoice.Invoice_id;
            }
            return -1;
        }


    }
}
