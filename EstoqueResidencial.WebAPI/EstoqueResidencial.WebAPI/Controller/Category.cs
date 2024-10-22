using EstoqueResidencia.EFCore.DataContext;
using EstoqueResidencial.Model.Model;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EstoqueResidencial.WebAPI.Controller;

[Route("api/categories")]
[ApiController]
public class CategoryController : ControllerBase {
    private readonly EstoqueResidencialEFCoreContext context;
    public CategoryController(EstoqueResidencialEFCoreContext context)
    {
        this.context = context;
    }


    [HttpGet]
    public async Task<IActionResult> GetAll() {
        var categories = await context.Categories.ToListAsync();
        return Ok(categories);
    }



    [HttpGet("getByID")]
    public async Task<IActionResult> GetByID(int categoryID) {
        CategoryModel? category = await context.Categories.FindAsync(categoryID);
        return Ok(category);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CategoryModel category) {
        context.Add(category);
        await context.SaveChangesAsync(); 
        return  Created("", category);   
    }

    [HttpDelete] 
    public async Task<IActionResult> DeleteById(int categoryID) {
        CategoryModel? category = await context.Categories.FindAsync(categoryID);
        if (category != null) {
            context.Remove(category);
            await context.SaveChangesAsync();
            return Ok();
        }
        return NoContent();
    }

    [HttpPut]
    public async Task<IActionResult> Update(CategoryModel category) {
        context.Entry(category).State = EntityState.Modified;
        await context.SaveChangesAsync();
        return Ok(category);
    }
}