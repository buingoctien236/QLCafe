using System.Data;

namespace BusinessLogicLayer
{
    public class Table 
    {
        public Table(int id, string name, int status)
        {
            this.Desk_id = id;
            this.Tinh_trang = status;
            this.Ten_ban = name;
        }

        public Table(DataRow row) 
        {
            this.desk_id = (int)row["desks_id"];
            this.ten_ban = row["ten_ban"].ToString();
            this.tinh_trang = (int)row["tinh_trang"];
        }

        private int desk_id;
        private int tinh_trang;
        private string ten_ban;

        public int Desk_id { get => desk_id; set => desk_id = value; }
        public int Tinh_trang { get => tinh_trang; set => tinh_trang = value; }
        public string Ten_ban { get => ten_ban; set => ten_ban = value; }
    }
}
