using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Core.Model
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public DateTime Created {  get; set; }
        public DateTime Updated { get; set; }
        public void Display()
        {
            Console.WriteLine("id:{0}, name:{1}", CategoryId, CategoryName); ;
        }
    }
}
