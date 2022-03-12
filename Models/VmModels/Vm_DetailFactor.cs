namespace sabashop.Models.VmModels
{
    public class Vm_DetailFactor
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdProduct { get; set; }
        public int Count { get; set; }
        public long TotalPrice { get; set; }
        public int RFactor { get; set; }
    }
}