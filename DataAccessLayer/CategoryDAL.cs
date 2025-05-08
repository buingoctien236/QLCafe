using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BusinessLogicLayer;

namespace DataAccessLayer
{
    public class CategoryDAL
    {
        private static CategoryDAL instance;

        public static CategoryDAL Instance
        {
            get
            {
                if (instance == null) instance = new CategoryDAL();
                return instance;
            }
        }
        public CategoryDAL() { }
        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();

            string query = "select *  from dbo.FoodCategory";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);

                list.Add(category);
            }

            return list;
        }
    }
}
