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
    public class InvoiceItemDAL
    {
        private static InvoiceItemDAL instance;
        public static InvoiceItemDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new InvoiceItemDAL();
                }
                return InvoiceItemDAL.instance;
            }
            set
            {
                InvoiceItemDAL.instance = value;
            }
        }

        public InvoiceItemDAL()
        {

        }

        public List<InvoiceItem>getInvoiceInfoList(int id)
        {
            List<InvoiceItem> invoiceitemList = new List<InvoiceItem>();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("SELECT * FROM invoice_items where invoice_id = " + id );

            foreach (DataRow row in dataTable.Rows)
            {
                InvoiceItem item = new InvoiceItem(row);
                invoiceitemList.Add(item);
            }

            return invoiceitemList;
        }



    }
}
