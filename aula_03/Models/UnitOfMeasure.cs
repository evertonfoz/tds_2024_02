namespace Aula03.Models;

public class UnitOfMeasureModel
{
    public int UnitOfMeasureID { get; set; }

    public string? Name { get; set; }

    public string? Abbreviation { get; set; }

    public int Quantity { get; set; }

    public UnitOfMeasureModel(int unitOfMeasureID, string name, string abbreviation, int quantity)
    {
        UnitOfMeasureID = unitOfMeasureID;
        Name = name;
        Abbreviation = abbreviation;
        Quantity = quantity;
    }

    public UnitOfMeasureModel()
    {
    }

    public override string ToString()
    {
        return $"[{UnitOfMeasureID}, {Name}, {Abbreviation}, {Quantity}]";
    }

    public override bool Equals(object? obj)
    {
        if (obj is UnitOfMeasureModel other)
        {
            return other.UnitOfMeasureID == UnitOfMeasureID;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return UnitOfMeasureID.GetHashCode();
    }
}