using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer;
using System.Data;
namespace DataAccessLayer
{
    public class FoodDAL
    {
        private static FoodDAL instance;
        public static FoodDAL Instance
        {
            get
            {
                if (instance == null) instance = new FoodDAL();
                return instance;
            }
        }
        public FoodDAL() { }
        public List<Food> GetFoodByCategory(int id)
        {
            List<Food> list = new List<Food>();
            string query = "select * from Food where idCategory = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }
        public List<Food> GetListFood()
        {
            List<Food> list = new List<Food>();
            string query = "select * from Food";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }

        public bool InsertFood(string name, int id, float price)
        {
            string query = "insert into Food (name, idCategory, price) values (N'" + name + "', " + id + ", " + price + ")";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0; // them thanh cong tra true 

        }
        public bool UpdateFood(int idFood, string name, int idCategory, float price)
        {
            string query = "update Food set name = N'" + name + "', idCategory = " + idCategory + ", price = " + price + " where id = " + idFood;
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteFood(int idFood)
        {
            BillInfoDAL.Instance.DeleteBillInfoByFoodID(idFood);
            string query = "delete Food where id = " + idFood;
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public List<Food> SearchFoodByName(string name)
        {
            List<Food> list = new List<Food>();
            string query = string.Format("select * from Food where name like N'%" + name + "%'");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }
    }
}
