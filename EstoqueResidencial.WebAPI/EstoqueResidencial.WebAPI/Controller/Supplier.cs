using EstoqueResidencia.EFCore.DataContext;
using EstoqueResidencial.Model.Model;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EstoqueResidencial.WebAPI.Controller;

[Route("api/suppliers")]
[ApiController]
public class SupplierController : ControllerBase {
    private readonly EstoqueResidencialEFCoreContext context;
    public SupplierController(EstoqueResidencialEFCoreContext context)
    {
        this.context = context;
    }


    [HttpGet]
    public async Task<IActionResult> GetAll() {
        var suppliers = await context.Suppliers.ToListAsync();
        return Ok(suppliers);
    }



    [HttpGet("getByID")]
    public async Task<IActionResult> GetByID(int supplierID) {
        SupplierModel? supplier = await context.Suppliers.FindAsync(supplierID);
        return Ok(supplier);
    }

    [HttpPost]
    public async Task<IActionResult> Create(SupplierModel supplier) {
        context.Add(supplier);
        await context.SaveChangesAsync(); 
        return  Created("", supplier);   
    }

    [HttpDelete] 
    public async Task<IActionResult> DeleteById(int supplierID) {
        SupplierModel? supplier = await context.Suppliers.FindAsync(supplierID);
        if (supplier != null) {
            context.Remove(supplier);
            await context.SaveChangesAsync();
            return Ok();
        }
        return NoContent();
    }

    [HttpPut]
    public async Task<IActionResult> Update(SupplierModel supplier) {
        context.Entry(supplier).State = EntityState.Modified;
        await context.SaveChangesAsync();
        return Ok(supplier);
    }
}