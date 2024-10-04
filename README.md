Visual Studio (package manager)
1 create dotnet core project
2 install entityframework core
	NuGet\Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 8.0.8
	NuGet\Install-Package Microsoft.EntityFrameworkCore.Design -Version 8.0.8
	NuGet\Install-Package Microsoft.EntityFrameworkCore.Tools -Version 8.0.8
3 Add DbContext class
4 Add connection
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=BLOCKCHAINCAMBO\SQLDEV2216;database=POS;trusted_connection=true;TrustServerCertificate=Yes");
        }
5 Add DbSet Model
6 Add-Migration MigrationName
7 Update-Database

VSCode (cli)
1 install dotnet
2 check version dotnet --version
3 project template -> dotnet new --list
4 create project (dotnet new console -n DemoEFCore)
5 build (dotnet build)
6 run (dotnet run)
7 add entity framework core libs
	dotnet add package Microsoft.EntityFrameworkCore.Tools --version 8.0.8
	dotnet add package Microsoft.EntityFrameworkCore.Design --version 8.0.8
	dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 8.0.8
	dotnet tool install --global dotnet-ef --version 8.*
8 Add DbContext class
9 Add connection
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=BLOCKCHAINCAMBO\SQLDEV2216;database=Demo;trusted_connection=true;TrustServerCertificate=Yes");
        }
10 Add DbSet Model
11 Add migrations (dotnet ef migrations add InitModel)
12 Update database (dotnet ef database update)
