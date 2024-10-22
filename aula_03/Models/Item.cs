namespace Aula03.Models;

public class ItemModel
{
    public int ItemID { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public int CategoryID { get; set; }
    public int SupplierID { get; set; }
    public CategoryModel? Category { get; set; }
    public SupplierModel? Supplier { get; set; }

    public ItemModel(int itemID, string name, string description, decimal price, int categoryID, int supplierID)
    {
        ItemID = itemID;
        Name = name;
        Description = description;
        Price = price;
        CategoryID = categoryID;
        SupplierID = supplierID;
    }

    public ItemModel()
    {
    }

    public override string ToString()
    {
        return $"[{ItemID}, {Name}, {Description}, {Price}, {CategoryID}, {SupplierID}]";
    }

    public override bool Equals(object? obj)
    {
        if (obj is ItemModel other)
        {
            return other.ItemID == ItemID;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return ItemID.GetHashCode();
    }
}