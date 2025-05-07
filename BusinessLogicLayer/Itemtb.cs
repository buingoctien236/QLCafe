using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
     public class Itemtb
    {
        public Itemtb(string food_name, int count, int price, float total_price = 0)
        {
            this.food_name = food_name;
            this.count = count;
            this.price = price;
            this.total_price = total_price;
        }
        private int count;
        private int price;
        private string food_name;
        private float total_price;



        public Itemtb(DataRow row)
        {
            this.food_name = row.Field<string>("ten_mon");
            this.count = row.Field<int>("so_luong");
            this.price = row.Field<int>("gia_ban");
            this.total_price = row.Field<long>("totalPrice");
        }
        public string Food_name { get => food_name; set => food_name = value; }
        public int Count { get => count; set => count = value; }
        public int Price { get => price; set => price = value; }
        public float Total_price { get => total_price; set => total_price = value; }
    }
}
