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

app.MapGet("/api/items", async (EFCoreContext context) =>
    {
        return await context.Items.Include(i => i.Category).Include(i => i.Supplier).ToListAsync();
    }
);

app.Run();
