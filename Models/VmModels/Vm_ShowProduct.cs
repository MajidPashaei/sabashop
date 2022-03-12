using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sabashop.Models.VmModels
{
    public class Vm_ShowProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Vm_MoreImageProduct>    MoreImage                   { get; set; }
        public string                       CategoryName                { get; set; }
        public string                       SiteCategory                { get; set; }
        public long                         price                       { get; set; }
        public int                          Count                       { get; set; }
        public int                          offer                       { get; set; }
        public string                       Image                       { get; set; }
        
        
        

    }
}