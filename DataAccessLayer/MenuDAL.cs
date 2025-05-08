using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BusinessLogicLayer;
namespace DataAccessLayer
{
    public class MenuDAL
    {

        private static MenuDAL instance;
        public static MenuDAL Instance
        {
            get { if (instance == null) instance = new MenuDAL(); return MenuDAL.instance; }
            private set => instance = value;
        } // noi bo dc set , ngoai k dc 
        private MenuDAL() { } // khoi tao constructor



        public List<Menu> GetListMenuByTable(int id)
        {


            List<Menu> listMenu = new List<Menu>();
            string query = "select f.name, bi.count, f.price, f.price * bi.count AS totalPrice from BillInfo as bi, Bill as b, Food as f where bi.idBill = b.id AND bi.idFood = f.id and b.status = 0 and b.idTable = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}
