
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer;


namespace DataAccessLayer
{
    public class TableDAL
    {
        private static TableDAL instance;
        public static TableDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TableDAL();
                }
                return TableDAL.instance;
            }
             set
            {
                TableDAL.instance = value;
            }

        }


        public TableDAL()
        {
            // Constructor logic here
        }
        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("SELECT * FROM desks");
            foreach (DataRow item in dataTable.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }
    }
}

