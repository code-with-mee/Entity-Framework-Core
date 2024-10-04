using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Core.Model
{
    public class SaleDetail
    {
        public int SaleDetailId {  get; set; }
        public Sale? Sale { get; set; }
        public Product? Product { get; set; }
        public int Quantity { get; set; }
        public float TotalPrice {  get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
