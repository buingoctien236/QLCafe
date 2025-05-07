using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace BusinessLogicLayer
{
    public class InvoiceItem
    {

        public InvoiceItem(int item_id, int so_luong, decimal don_gia)
        {
            this.item_id = item_id;
            this.so_luong = so_luong;
            this.don_gia = don_gia;

        }
        public InvoiceItem(DataRow row) {
            this.item_id = row.Field<int>("item_id");
            this.so_luong = row.Field<int>("so_luong");
            this.don_gia = row.Field<decimal>("don_gia");

        }
        private int item_id;
        private int so_luong;
        private decimal don_gia;

        public int Item_id { get => item_id; set => item_id = value; }
        public int So_luong { get => so_luong; set => so_luong = value; }
        public decimal Don_gia { get => don_gia; set => don_gia = value; }
    }
}
