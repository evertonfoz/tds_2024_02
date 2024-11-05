using BackendDotNet.Models.Models;
using BackendDotNet.Persistence.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.WithOrigins("http://localhost:5054", "http://10.0.0.145:5001/") // URL do frontend Blazor
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<EFCoreContext>(options => options.UseNpgsql(
    builder.Configuration.GetConnectionString("DefaultConnection")
));


var app = builder.Build();

app.UseCors();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseHttpsRedirection();

// CRUD Endpoints para "categories"

// Listar todas as categorias
app.MapGet("/api/categories", async (EFCoreContext context) =>
    {
        return await context.Categories.ToListAsync();
    }
);

// Obter uma categoria específica por ID
app.MapGet("/api/categories/{id}", async (EFCoreContext context, int id) =>
{
    var category = await context.Categories.FindAsync(id);
    return category is not null ? Results.Ok(category) : Results.NotFound();
});


// Criar uma nova categoria
app.MapPost("/api/categories", async (EFCoreContext context, CategoryEntity category) =>
{
    context.Categories.Add(category);
    await context.SaveChangesAsync();
    return Results.Created($"/api/categories/{category.CategoryEntityId}", category);
});

// Atualizar uma categoria existente
app.MapPut("/api/categories/{id}", async (EFCoreContext context, int id, CategoryEntity updatedCategory) =>
{
    var category = await context.Categories.FindAsync(id);
    if (category is null) return Results.NotFound();

    category.Name = updatedCategory.Name;
    category.Description = updatedCategory.Description;

    await context.SaveChangesAsync();
    return Results.Ok(category);
});

// Remover uma categoria existente
app.MapDelete("/api/categories/{id}", async (EFCoreContext context, int id) =>
{
    var category = await context.Categories.FindAsync(id);
    if (category is null) return Results.NotFound();

    context.Categories.Remove(category);
    await context.SaveChangesAsync();
    return Results.NoContent();
});


app.Run();

// dotnet ef migrations add InitialMigration --project Persistence --startup-project Category.API
// dotnet ef database update --project Persistence --startup-project Category.API

// ,
//   "ConnectionStrings": {
//     "DefaultConnection": "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=postgres"
//   }

// docker logs category_api --build