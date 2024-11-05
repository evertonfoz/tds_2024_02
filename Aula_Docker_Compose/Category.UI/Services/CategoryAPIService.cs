using BackendDotNet.Models.Models;
using System.Net.Http.Json;

namespace Category.UI.Services;

public class CategoryAPIService(HttpClient httpClient)
{
    private readonly HttpClient _httpClient = httpClient;

    public async Task<List<CategoryEntity>> GetCategoriesAsync()
    {
        var result = await _httpClient.GetFromJsonAsync<List<CategoryEntity>>("api/categories");
        return result??[];
    }

    public async Task<CategoryEntity?> GetCategoryByIdAsync(int id)
    {
        return await _httpClient.GetFromJsonAsync<CategoryEntity>($"api/categories/{id}");
    }

    public async Task AddCategoryAsync(CategoryEntity category)
    {
        await _httpClient.PostAsJsonAsync("api/categories", category);
    }

    public async Task UpdateCategoryAsync(CategoryEntity category)
    {
        await _httpClient.PutAsJsonAsync($"api/categories/{category.CategoryEntityId}", category);
    }

    public async Task DeleteCategoryAsync(int id)
    {
        await _httpClient.DeleteAsync($"api/categories/{id}");
    }
}
