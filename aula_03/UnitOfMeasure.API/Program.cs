using Aula03.Models;
using Aula03.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

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

app.MapGet("/api/unitsofmeasure", async (EFCoreContext context) =>
    {
        return await context.UnitsOfMeasure.ToListAsync();
    }
);
app.MapPost("/api/unitsofmeasure", async (EFCoreContext context, UnitOfMeasureModel unitOfMeasure) =>
{
    context.UnitsOfMeasure.Add(unitOfMeasure);
    await context.SaveChangesAsync();
    return Results.Created($"/api/unitsofmeasure/{unitOfMeasure.UnitOfMeasureID}", unitOfMeasure);
});
app.MapGet("/api/unitsofmeasure/{id}", async (EFCoreContext context, int id) =>
{
    var unitOfMeasure = await context.UnitsOfMeasure.FindAsync(id);
    return unitOfMeasure is not null ? Results.Ok(unitOfMeasure) : Results.NotFound();
});
app.MapPut("/api/unitsofmeasure/{id}", async (EFCoreContext context, int id, UnitOfMeasureModel updatedUnitOfMeasure) =>
{
    var existingUnit = await context.UnitsOfMeasure.FindAsync(id);

    if (existingUnit is null)
    {
        return Results.NotFound();
    }

    existingUnit.Name = updatedUnitOfMeasure.Name;
    existingUnit.Abbreviation = updatedUnitOfMeasure.Abbreviation;
    existingUnit.Quantity = updatedUnitOfMeasure.Quantity;

    await context.SaveChangesAsync();
    return Results.NoContent();
});
app.MapDelete("/api/unitsofmeasure/{id}", async (EFCoreContext context, int id) =>
{
    var unitOfMeasure = await context.UnitsOfMeasure.FindAsync(id);

    if (unitOfMeasure is null)
    {
        return Results.NotFound();
    }

    context.UnitsOfMeasure.Remove(unitOfMeasure);
    await context.SaveChangesAsync();
    return Results.NoContent();
});

// app.MapGet("/weatherforecast", () =>
// {
//     var forecast =  Enumerable.Range(1, 5).Select(index =>
//         new WeatherForecast
//         (
//             DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
//             Random.Shared.Next(-20, 55),
//             summaries[Random.Shared.Next(summaries.Length)]
//         ))
//         .ToArray();
//     return forecast;
// })
// .WithName("GetWeatherForecast")
// .WithOpenApi();

app.Run();
