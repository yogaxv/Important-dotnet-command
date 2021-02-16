# Important-dotnet-command


Create SLN & Project :
```
dotnet new sln

dotnet new
dotnet new webapi -n <Name of Project>
dotnet new webapi -n Commander

dotnet sln bnefit-v1.sln add Contracts\Contracts.csproj
```

Open Project in VS :
```
coder -r Commander
```

instal ef (EntityFramework)
```
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design 
dotnet add package Microsoft.EntityFrameworkCore.SqlServer 
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection
dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson
dotnet add package Microsoft.AspNetCore.JsonPatch
```

For detail check : 
https://www.nuget.org/packages?q=entityframework

Check If EF Works 
```
dotnet ef
```

it will show unicorn

if above command not work, try using : 
```
dotnet tool install --global dotnet-ef
```

make migration
```
dotnet ef migrations add <Name Of Migrations>
dotnet ef migrations add InitialMigration
```

remove migration
```
dotnet ef migrations remove
```

do migrations
```
dotnet ef database update
```

Build Project
```
dotnet build
```

Run Project
```
dotnet run
dotnet watch run
```


## Create Model based on existing table 

using .NET Core CLI:
```sh
dotnet ef dbcontext scaffold "server=localhost;port=3306;user=root;password=mypass;database=sakila" MySql.Data.EntityFrameworkCore -o sakila -t actor -t film -t film_actor -t language -f

dotnet ef dbcontext scaffold "Server=localhost,1433;Initial Catalog=EPROPERTY_FO_001_MARKETINGJUAL;User ID=sa;Password=pass;" Microsoft.EntityFrameworkCore.SqlServer -o EPROPERTY_FO_001_MARKETINGJUAL -t MS_RESERVASI -f 
```

Package Manager Console in Visual Studio:

```sh
Scaffold-DbContext "server=localhost;port=3306;user=root;password=mypass;database=sakila" MySql.Data.EntityFrameworkCore -OutputDir Sakila -Tables actor,film,film_actor,language -f 
```

Create Model based on existing table using EF Core,MS SQL PM 
```sh
Scaffold-DbContext "server=PC\SQL2012;user=test;password=test123;database=student" Microsoft.EntityFrameworkCore.SqlServer -OutputDir student-Tables stu.names,stu.grades -f
```

# Kinds Of Problem I face when learn this Project

Problem : Visual Studio Code Not show Errors:
Fixing : try to reinstal C# Extension

## Based
https://code-maze.com/net-core-series/
http://codingsonata.com/build-restful-apis-using-asp-net-core-and-entity-framework-core/
https://www.c-sharpcorner.com/blogs/create-apis-using-net-core-31
