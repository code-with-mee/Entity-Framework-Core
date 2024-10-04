using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Core.Model
{
    public class Supplier
    {
        public int SupplierId {  get; set; }
        public string? SupplierName {  get; set; }
        public string? Phone {  get; set; }
        public string? Address {  get; set; }
        public DateTime? Created {  get; set; }
        public DateTime? Updated { get; set; }

        public void Display()
        {
            Console.WriteLine("id:{0}, name:{1}, phone:{2}, address:{3}",
                SupplierId,SupplierName,Phone,Address);
        }
    }
}
