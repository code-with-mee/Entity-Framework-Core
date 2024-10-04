using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Core.Model
{
    public class Product
    {
        public int ProductId {  get; set; }
        public string? ProductName {  get; set; }
        public Category? Category { get; set; }
        public float CostPrice {  get; set; }
        public float SellingPrice {  get; set; }
        public string? Unit {  get; set; }
        public DateTime Created {  get; set; }
        public DateTime Updated { get; set; }

        public void Display()
        {
            Console.WriteLine("id{0}, name:{1}, category:{2}, costprice:{3}, sellingprice:{4}",
                ProductId,ProductName,Category.CategoryName,CostPrice,SellingPrice);
        }
    }
}
