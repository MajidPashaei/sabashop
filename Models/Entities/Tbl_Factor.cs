using System;

namespace sabashop.Models.Entities
{
    public class Tbl_Factor
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public DateTime CreateTime { get; set; }
        public long Price { get; set; }
        public bool StatusPay { get; set; }
        public DateTime PayTime { get; set; }
        public int RFactor { get; set; }
    }
}