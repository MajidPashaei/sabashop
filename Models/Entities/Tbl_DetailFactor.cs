namespace sabashop.Models.Entities
{
    public class Tbl_DetailFactor
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdProduct { get; set; }
        public int Count { get; set; }
        public long TotalPrice { get; set; }
        public long RFactor { get; set; }
    }
}