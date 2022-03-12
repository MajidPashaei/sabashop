namespace sabashop.Models.VmModels
{
    public class Vm_Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Count { get; set; }
        public int CategoryId { get; set; }
        public int SiteCategoryId { get; set; }
        public long Price { get; set; }
        public int Offer { get; set; }
        public bool status { get; set; }
    }
}