using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sabashop.Models.VmModels
{
    public class Vm_User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Pass { get; set; }
        public string ActiveCode { get; set; } 
        public string Avatar { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Captcha { get; set; }
        
        
        
        
    }
}