using EstoqueResidencia.EFCore.DataContext;
using EstoqueResidencial.Model.Model;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EstoqueResidencial.WebAPI.Controller;

[Route("api/storages")]
[ApiController]
public class StorageController : ControllerBase {
    private readonly EstoqueResidencialEFCoreContext context;
    public StorageController(EstoqueResidencialEFCoreContext context)
    {
        this.context = context;
    }


    [HttpGet]
    public async Task<IActionResult> GetAll() {
        var storages = await context.Storages.ToListAsync();
        return Ok(storages);
    }



    [HttpGet("getByID")]
    public async Task<IActionResult> GetByID(int storageID) {
        StorageModel? storage = await context.Storage.FindAsync(storageID);
        return Ok(storage);
    }

    [HttpPost]
    public async Task<IActionResult> Create(StorageModel storage) {
        context.Add(storage);
        await context.SaveChangesAsync(); 
        return  Created("", storage);   
    }

    [HttpDelete] 
    public async Task<IActionResult> DeleteById(int storageID) {
        StorageModel? storage = await context.Storages.FindAsync(storageID);
        if (storage != null) {
            context.Remove(storage);
            await context.SaveChangesAsync();
            return Ok();
        }
        return NoContent();
    }

    [HttpPut]
    public async Task<IActionResult> Update(StorageModel storage) {
        context.Entry(storage).State = EntityState.Modified;
        await context.SaveChangesAsync();
        return Ok(storage);
    }
}