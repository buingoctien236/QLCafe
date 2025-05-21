
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
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from TableFood");
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }
        public void SwitchTable(int id1, int id2)
        {
            
            DataProvider.Instance.ExecuteQuery("SwitchTable @idTable1 , @idTable2" ,new object[] {id1,id2});
        }



        public bool InsertTable(string name)
        {
            string query = string.Format("insert into TableFood (name) values (N'{0}')", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateTable(int id, string name)
        {
            string query = string.Format("update TableFood set name = N'{0}' where id = {1}", name, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteTable(int id)
        {
            string query = string.Format("delete TableFood where id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }





    }
}

