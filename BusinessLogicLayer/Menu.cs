using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
     public class Menu
    {   public Menu(string foodName, int count, float price, float totalPrice =0 )
        {
            this.FoodName = foodName;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }

        private int count;
        private float price;
        private string foodName;
        private float total_price;

        public Menu(DataRow row)
        {
            this.FoodName = row["name"].ToString();
            this.Count = (int)row["count"];
            this.Price = (float)Convert.ToDouble(row["price"]);
            this.TotalPrice = (float)Convert.ToDouble(row["totalPrice"]);



        }
        public int Count { get => count; set => count = value; }
        public float Price { get => price; set => price = value; }
        public string FoodName { get => foodName; set => foodName = value; }
        public float TotalPrice { get => total_price; set => total_price = value; }
    }
}
