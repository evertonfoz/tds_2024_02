namespace BackendDotNet.Models.Models;

public class CategoryEntity
{
    public int CategoryEntityId { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }

    public CategoryEntity()
    {
    }

    public CategoryEntity(int categoryId, string name, string description)
    {
        CategoryEntityId = categoryId;
        Name = name;
        Description = description;
    }

    public override string ToString()
    {
        return $"[{CategoryEntityId}, {Name}, {Description}]";
    }

    public override bool Equals(object? obj)
    {
        if (obj is CategoryEntity other)
        {
            return other.CategoryEntityId == CategoryEntityId;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return CategoryEntityId.GetHashCode();
    }
}
