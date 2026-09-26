# Product Management - ASP.NET Core MVC

A small Product Management application matching the supplied UI screenshot.

## Stack
- ASP.NET Core MVC (.NET 8)
- Entity Framework Core 8
- SQLite
- Razor Views
- HTML/CSS

## Features
- Add product
- Store products in SQLite database
- Show products list
- Success message after adding
- Delete product
- Seeded sample products: Apple and Banana

## Run
1. Install .NET 8 SDK.
2. Open a terminal in this folder.
3. Run:

```bash
dotnet restore
dotnet run
```

4. Open the localhost URL shown by ASP.NET Core.

The SQLite database `products.db` is created automatically on first run.
