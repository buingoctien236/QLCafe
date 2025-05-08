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
    }
}
