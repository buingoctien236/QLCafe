using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer;
namespace DataAccessLayer
{
    public class AccountDAL
    {
        private static AccountDAL instance;
        public static AccountDAL Instance
        {
            get { if (instance == null) instance = new AccountDAL(); return AccountDAL.instance; }
            private set => instance = value;
        }
        private AccountDAL() { }
        public bool Login(string userName, string passWord)
        {
            string query = "Login @userName , @passWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });


            return result.Rows.Count > 0; //neu co du lieu thi dang nhap thanh cong
        }
        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Account WHERE userName = '" + userName + "'");
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }



        public bool UpdateAccount(string userName, string displayName, string pass, string newPass)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec UpdateAccount @userName , @displayName , @password , @newPassword ", new object[] { userName, displayName, pass, newPass });
            return result > 0; //neu co du lieu thi  thanh cong
        }


        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT UserName, DisplayName, Type FROM dbo.Account");
        }





        //Admin --Them Accout
        public bool InsertAccount(string userName, string displayName, int type)
        {
            string query = string.Format("insert   dbo.Account (UserName,DisplayName,Type) values (N'{0}' ,N'{1}',N'{2}')" ,userName,displayName,type);
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName, displayName, type });
            return result > 0;
        }
        public bool CheckUserNameExists(string userName)
        {
            string query = "SELECT COUNT(*) FROM Account WHERE UserName = @userName";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { userName });
            int count = Convert.ToInt32(result);
            return count > 0;
        }

        //Admin --Sua Account
        public bool UpdateAccount(string userName, string displayName, int type)
        {
            string query = string.Format("update   dbo.Account set DisplayName =N'{1}' ,type =N'{2}' where  UserName = N'{0}' ", userName,displayName,type);
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName, displayName, type });
            return result > 0;
        }

        //Admin --Xoa Account
        public bool DeleteAccount(string userName )
        {
            string query = string.Format("delete   dbo.Account where UserName = N'{0}'", userName);
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName });
            return result > 0;
        }
    }
}
