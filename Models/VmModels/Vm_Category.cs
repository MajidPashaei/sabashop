using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sabashop.Models.VmModels
{
    public class Vm_Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FatherId { get; set; }
        public string FatherName { get; set; }
        public int GrandFatherId { get; set; }
        public string GrandFatherName { get; set; }
    }
}