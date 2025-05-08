using System.Data;

namespace BusinessLogicLayer
{
    public class Table 
    {
        public Table(int id,string name ,string stastus) {
            this.Name = name;
            this.ID = id;
            this.Status = stastus;
        }
        public Table(DataRow row)
        {
            this.Name = row["name"].ToString();
            this.ID = (int)row["id"];
            this.Status = row["status"].ToString();
        }
        private string name;
        private int iD;
        private string status;

        public string Name { get => name; set => name = value; }
        public int ID { get => iD; set => iD = value; }
        public string Status { get => status; set => status = value; }
    }
}
