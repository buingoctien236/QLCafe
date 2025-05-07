using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace DataAccessLayer
{
    public class DataProvider
    {
        private string connectionSTR = "Server=localhost;Database=qlcafe;User ID=buingoctien;Password=Tien2362003#";
        private static DataProvider instance;

        public static DataProvider Instance { 
            get { if (instance == null) instance = new DataProvider();
                return DataProvider.instance; 
            } 
            private set => instance = value;
        } // noi bo dc set , ngoai k dc }
        private DataProvider() { } // khoi tao constructor



        //Select
        public DataTable ExecuteQuery(string query, object[] prameter = null)
        {
            DataTable data = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connectionSTR))
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                if (prameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, prameter[i]);
                            i++;
                        }
                    }
                }
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(data);  
                conn.Close();
            }
            return data;
        }
        ////Insert, Update, Delete
        //public int ExecuteNonQuery(string query,object[] prameter = null)
        //{
        //    int data = 0;
        //    using (MySqlConnection conn = new MySqlConnection(connectionSTR))
        //    { 
        //    conn.Open();
        //    MySqlCommand command = new MySqlCommand(query, conn);
        //    if(prameter != null)
        //        {
        //            string[] listPara = query.Split(' ');
        //            int i = 0;
        //            foreach (string item in listPara)
        //            {
        //                if (item.Contains('@'))
        //                {
        //                    command.Parameters.AddWithValue(item, prameter[i]);
        //                    i++;
        //                }
        //            }
        //        }
        //    data = command.ExecuteNonQuery();
        //        conn.Close();
        //    }
        //    return data;
        //}
        ////Tinh dong dau ,dem count
        //public object ExecuteScalar(string query, object[] prameter = null)
        //{
        //    object data = 0;
        //    using (MySqlConnection conn = new MySqlConnection(connectionSTR))
        //    {
        //        conn.Open();
        //        MySqlCommand command = new MySqlCommand(query, conn);
        //        if (prameter != null)
        //        {
        //            string[] listPara = query.Split(' ');
        //            int i = 0;
        //            foreach (string item in listPara)
        //            {
        //                if (item.Contains('@'))
        //                {
        //                    command.Parameters.AddWithValue(item, prameter[i]);
        //                    i++;
        //                }
        //            }
        //        }
        //        data = command.ExecuteScalar();
        //        conn.Close();
        //    }
        //    return data;
        //}
    }
}
