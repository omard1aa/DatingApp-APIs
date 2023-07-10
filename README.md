.Net 7.0, sqlite

Project Creation
dotnet new sln
dotnet new webapi -n API
dotnet sln add API/API.csproj

VSCode Extensions:
C# Extinsions
NuGet Gallery

Packages Installation
EF Core >> `dotnet add package Microsoft.EntityFrameworkCore`

Sqlite >> `dotnet add package Microsoft.EntityFrameworkCore.Sqlite`

EF Core Design >> `dotnet add package Microsoft.EntityFrameworkCore.Design`

Dotnet EF tool >> `dotnet tool install --global dotnet-ef --version 7.0.8`

add migration >> `dotnet ef migrations add Initial -i Data/Migrations`

db migrate >> `dotnet ef database update`

generate ssh `ssh-keygen -t ed25519 -C "your_email@example.com`
