using Microsoft.AspNetCore.Http;

namespace sabashop.Models.VmModels
{
    public class Vm_Logotitle
    {
        public int Id { get; set; }
        public string Logo { get; set; }
        public IFormFile Image { get; set; }
        public string Title { get; set; }
        
    }
}