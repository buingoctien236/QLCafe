using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Reflection.Metadata;

namespace DataAccessLayer
{
    public class DataProvider
    { //intance chi cho 1 cai tao ra 1 lan

        private static DataProvider instance;

        private string connectionSTR = @"Server=DESKTOP-QAR9UUA;Database=QuanLyQuanCafe;User Id=sa;Password=123;TrustServerCertificate=True";



        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connnection = new SqlConnection(connectionSTR))
            {

                connnection.Open();
                SqlCommand command = new SqlCommand(query, connnection);
                //nhieu para khi dung procedure
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }



                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connnection.Close();

               
            }
            return data;

        }



        //tra ra so dong thanh cong thoi (tra kieu int)
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            SqlConnection connnection = new SqlConnection(connectionSTR);

            connnection.Open();
            SqlCommand command = new SqlCommand(query, connnection);
            //nhieu para khi dung procedure
            if (parameter != null)
            {
                string[] listPara = query.Split(' ');
                int i = 0;
                foreach (string item in listPara)
                {
                    if (item.Contains('@'))
                    {
                        command.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }
            }

            data = command.ExecuteNonQuery();
            connnection.Close();
            return data;
        }

        //dem so dong khi select *
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            SqlConnection connnection = new SqlConnection(connectionSTR);

            connnection.Open();
            SqlCommand command = new SqlCommand(query, connnection);
            //nhieu para khi dung procedure
            if (parameter != null)
            {
                string[] listPara = query.Split(' ');
                int i = 0;
                foreach (string item in listPara)
                {
                    if (item.Contains('@'))
                    {
                        command.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }
            }

            data = command.ExecuteScalar(); // tra ve cot dau cua dong trong bang ket qua
            connnection.Close();
            return data;
        }






        public static DataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DataProvider();
                return DataProvider.instance;
            }
            private set => instance = value;
        } // chi co 1 instance duy nhat , khong cho phep khoi tao instance khac (private set)
          // { set private thi phai khoi tao o day, neu khong se bi loi khi goi den instance }
        ////} // noi bo dc set , ngoai k dc }
        private DataProvider() { } // khoi tao constructor




       

    }
}
