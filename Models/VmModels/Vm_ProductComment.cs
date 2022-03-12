namespace sabashop.Models.VmModels
{
    public class Vm_ProductComment
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdProduct { get; set; }
        public string Body { get; set; }
        public string AdminRespons { get; set; }
        public string Status { get; set; }
        public bool ShowStatus { get; set; }
    }
}