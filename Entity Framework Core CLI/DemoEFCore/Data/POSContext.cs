using Microsoft.EntityFrameworkCore;

public class POSContext : DbContext
{
    public DbSet<Category> Categories {get;set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"data source=BLOCKCHAINCAMBO\SQLDEV2216;database=POS2;trusted_connection=true;TrustServerCertificate=Yes");
    }
}