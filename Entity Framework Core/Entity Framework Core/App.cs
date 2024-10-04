using Entity_Framework_Core.Data;
using Entity_Framework_Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Core
{
    public class App
    {
        POSContext db = new POSContext();
        public void Run()
        {
            InsertData();
            ReadData();
        }

        private void ReadData()
        {
            Category category = new Category();
            category.CategoryName = "Drink";
            db.Categories.Add(category);
            db.SaveChanges();
        }

        private void InsertData()
        {
            foreach (var category in db.Categories)
            {
                category.Display();
            }
        }
    }
}
