using Aula03.Models;
using Aula03.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.WithOrigins("http://localhost:5070") // URL do frontend Blazor
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<EFCoreContext>(options => options.UseSqlite(
    builder.Configuration.GetConnectionString("DefaultConnection")
));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

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
app.MapPost("/api/categories", async (EFCoreContext context, CategoryModel category) =>
{
    context.Categories.Add(category);
    await context.SaveChangesAsync();
    return Results.Created($"/api/categories/{category.CategoryID}", category);
});

// Atualizar uma categoria existente
app.MapPut("/api/categories/{id}", async (EFCoreContext context, int id, CategoryModel updatedCategory) =>
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

app.UseCors();

app.Run();
