using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class Menu
    {
        public Menu(int id, string tenMon, int giaBan, string hinhAnh, string loaiId, string tinhTrang)
        {
            this.Menu_id = id;
            this.Ten_mon = tenMon;
            this.Gia_ban = giaBan;
            this.Hinh_anh = hinhAnh;
            this.Loai_id = loaiId;
            this.Tinh_trang = tinhTrang;
        }

        public Menu(DataRow row)
        {
            this.Menu_id = row.Field<int>("menu_id");
            this.Ten_mon = row.Field<string>("ten_mon");
            this.Gia_ban = row.Field<int>("gia_ban");
            this.Hinh_anh = row.Field<string>("hinh_anh");
            this.Loai_id = row.Field<string>("loai_id");
            this.Tinh_trang = row.Field<string>("tinh_trang");
        }

        private int menu_id;
        private string ten_mon;
        private int gia_ban;
        private string hinh_anh;
        private string loai_id;
        private string tinh_trang;

        public int Menu_id { get => menu_id; set => menu_id = value; }
        public string Ten_mon { get => ten_mon; set => ten_mon = value; }
        public int Gia_ban { get => gia_ban; set => gia_ban = value; }
        public string Hinh_anh { get => hinh_anh; set => hinh_anh = value; }
        public string Tinh_trang { get => tinh_trang; set => tinh_trang = value; }
        public string Loai_id { get => loai_id; set => loai_id = value; }
    }
}