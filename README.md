1 create dotnet core project
2 install entityframework core
	NuGet\Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 8.0.8
	NuGet\Install-Package Microsoft.EntityFrameworkCore.Design -Version 8.0.8
	NuGet\Install-Package Microsoft.EntityFrameworkCore.Tools -Version 8.0.8
3 Add DbContext class
4 Add connection
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=BLOCKCHAINCAMBO\SQLDEV2216;database=Demo;trusted_connection=true;TrustServerCertificate=Yes");
        }
5 Add DbSet Model
6 Add-Migration MigrationName
7 Update-Database
