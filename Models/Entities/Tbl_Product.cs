namespace sabashop.Models.Entities
{
    public class Tbl_Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Count { get; set; }
        public int CategoryId { get; set; }
        public int SiteCategoryId { get; set; }
        public long Price { get; set; }
        public int Offer { get; set; }
        public bool status { get; set; }
    }
}