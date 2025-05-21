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

        public Category GetCategoryByID(int id)
        {
            Category category = null;
            string query = "select * from dbo.FoodCategory where id = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                category = new Category(item);
            }
            return category;
        }
        public bool InsertCategory(string name)
        {
            string query = string.Format("insert into dbo.FoodCategory (name) values (N'{0}')", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateCategory(int id, string name)
        {
            string query = string.Format("update dbo.FoodCategory set name = N'{0}' where id = {1}", name, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteCategory(int id)
        {
            string query = "delete dbo.FoodCategory where id = " + id;
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


    }
}
