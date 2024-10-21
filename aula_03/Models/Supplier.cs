namespace Aula03.Models;

public class SupplierModel
{
    public int SupplierID { get; set; }
    public string? Name { get; set; }
    public string? Cellphone { get; set; }
    public string? Address { get; set; }
<<<<<<< HEAD
    public List<ItemModel>? Items { get; set; }
=======
>>>>>>> origin/main

    public SupplierModel(int suplierID, string name, string cellphone, string address)
    {
        SupplierID = suplierID;
        Name = name;
        Cellphone = cellphone;
        Address = address;
    }

    public SupplierModel()
    {
    }

    public override string ToString()
    {
        return $"[{SupplierID}, {Name}, {Cellphone}, {Address}]";
    }

    public override bool Equals(object? obj)
    {
        if (obj is SupplierModel other)
        {
            return other.SupplierID == SupplierID;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return SupplierID.GetHashCode();
    }
}
