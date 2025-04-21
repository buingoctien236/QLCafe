using System;
using System.Collections.Generic;
using System.Data;
using BusinessLogicLayer;

namespace DataAccessLayer
{
    public class MenuDAL
    {
        private static MenuDAL instance;

        public static MenuDAL Instance
        {
            get
            {
                if (instance == null)
                { instance = new MenuDAL(); }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public MenuDAL()
        {
           
        }

        public List<Menu> LoadMenuList()
        {
            List<Menu> menuList = new List<Menu>();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("SELECT * FROM menu");

            foreach (DataRow row in dataTable.Rows)
            {
                Menu menu = new Menu(row);
                menuList.Add(menu);
            }

            return menuList;
        }
    }
}
