using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Core.Model
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public Employee? Employee { get; set; }
        public Supplier? Supplier { get; set; }
        public float Amount {  get; set; }
        public float AmountPaid {  get; set; }
        public float AmountRemain {  get; set; }
        public DateTime Created {  get; set; }
        public DateTime Updated { get; set; }
    }
}
