using Microsoft.AspNetCore.Http;

namespace sabashop.Models.VmModels
{
    public class Vm_Slider
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public IFormFile Img { get; set; }
        public string LinkTO { get; set; }
    }
}