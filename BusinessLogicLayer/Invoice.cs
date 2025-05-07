using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;
namespace BusinessLogicLayer
{
    public class Invoice
    {
        public Invoice(int invoice_id, DateTime? time_checkin, DateTime? time_checkout
            ,decimal tong_tien,string ca_lam,string tinh_trang) { 
            this.invoice_id = invoice_id;
            this.time_checkin = time_checkin;
            this.time_checkout = time_checkout;
            this.tong_tien = tong_tien;
            this.ca_lam = ca_lam;
            this.tinh_trang = tinh_trang;
        }
        public Invoice(DataRow row)
        {
            this.invoice_id = Convert.ToInt32(row["invoice_id"]);

            this.time_checkin = row["time_checkin"] != DBNull.Value
                ? (DateTime?)Convert.ToDateTime(row["time_checkin"])
                : null;

            this.time_checkout = row["time_checkout"] != DBNull.Value
                ? (DateTime?)Convert.ToDateTime(row["time_checkout"])
                : null;

            this.tong_tien = Convert.ToDecimal(row["tong_tien"]);
            this.ca_lam = row["ca_lam_id"]?.ToString();
            this.tinh_trang = row["tinh_trang"]?.ToString();
        }

        private int invoice_id;
        private DateTime? time_checkin;
        private DateTime? time_checkout;
        private  decimal tong_tien;
        private string ca_lam;
        private string tinh_trang;

        public int Invoice_id { get => invoice_id; set => invoice_id = value; }
        public DateTime? Time_checkin { get => time_checkin; set => time_checkin = value; }
        public DateTime? Time_checkout { get => time_checkout; set => time_checkout = value; }
        public decimal Tong_tien { get => tong_tien; set => tong_tien = value; }
        public string Ca_lam { get => ca_lam; set => ca_lam = value; }
        public string Tinh_trang { get => tinh_trang; set => tinh_trang = value; }

    }
}
