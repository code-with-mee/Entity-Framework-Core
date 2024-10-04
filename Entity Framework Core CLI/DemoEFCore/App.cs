public class App
{
    private POSContext db = new POSContext();
    public void Run()
    {
        InsertData();
        ReadData();
    }

    private void InsertData()
    {
        Category category = new Category();
        category.CategoryName = "Drink";
        category.Created = DateTime.Now;
        category.Updated = DateTime.Now;
        db.Categories.Add(category);
        db.SaveChanges();
    }

    private void ReadData()
    {
        foreach(Category category in db.Categories)
        {
            Console.WriteLine(category.CategoryName);
        }
    }
}