namespace Aula03.Models;

public class CategoryModel
{
    public int CategoryID { get; set; }

    public string? Name { get; set; }
    public string? Description { get; set; }

    public List<ItemModel>? Items { get; set; }

    //sugestão: Talvez remover o categoryID ajudaria a evitar a necessidade de 
    //informar o ID manualmente ao criar novos objetos, permitindo que o banco 
    //de dados gere esse valor automaticamente.
    public CategoryModel(int categoryID, string name, string description)
    {
        CategoryID = categoryID;
        Name = name;
        Description = description;
    }

    public CategoryModel()
    {
    }

    public override string ToString()
    {
        return $"[{CategoryID}, {Name}, {Description}]";
    }

    public override bool Equals(object? obj)
    {
        if (obj is CategoryModel other)
        {
            return other.CategoryID == CategoryID;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return CategoryID.GetHashCode();
    }
}
