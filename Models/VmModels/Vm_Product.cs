using Microsoft.AspNetCore.Http;

namespace sabashop.Models.VmModels
{
    public class Vm_Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public int CategoryId { get; set; }
        public int SiteCategoryId { get; set; }
        public string Image { get; set; }
        public IFormFile Img { get; set; }
        public long Price { get; set; }
        public int Offer { get; set; }
        public bool status { get; set; }
    }
}