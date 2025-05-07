using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BusinessLogicLayer;

namespace DataAccessLayer
{
    public class DrinkTypeDAL
    {
        private static DrinkTypeDAL instance;

        public static DrinkTypeDAL Instance
        {
            get
            {
                if (instance == null) instance = new DrinkTypeDAL();
                return instance;
            }
        }

        public List<DrinkType> LoadDrinkTypes()
        {
            List<DrinkType> list = new List<DrinkType>();

            string query = "SELECT loai_id, mo_ta FROM drinktypes";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                DrinkType dt = new DrinkType
                {
                    Loai_id = row["loai_id"].ToString(),
                    Mo_ta = row["mo_ta"].ToString()
                };
                list.Add(dt);
            }

            return list;
        }
    }
}
