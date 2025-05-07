using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BusinessLogicLayer;
namespace DataAccessLayer
{
    public class ItemtbDAL
    {

        private static ItemtbDAL instance;
        public static ItemtbDAL Instance
        {
            get { if (instance == null) instance = new ItemtbDAL(); return ItemtbDAL.instance; }
            private set => instance = value;
        } // noi bo dc set , ngoai k dc 
        private ItemtbDAL() { } // khoi tao constructor
        public List<Itemtb> GetListItemByTable(int id)
        {
      

            List<Itemtb> listItem = new List<Itemtb>();
            string query = "select f.ten_mon, bi.so_luong, f.gia_ban, CAST(f.gia_ban * bi.so_luong AS SIGNED) As totalPrice from invoice_items as bi, invoices as b, menu as f where bi.invoice_id = b.invoice_id AND bi.menu_id = f.menu_id AND b.tinh_trang =0 and b.desks_id = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Itemtb itemtb = new Itemtb(item);
                listItem.Add(itemtb);
            }

            return listItem;
        }
    }
}
