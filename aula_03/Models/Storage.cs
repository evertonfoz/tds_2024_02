namespace Aula03.Models;

public class StorageModel
{
    public int StorageID { get; set; }
    public string FoodItem { get; set; }
    public int Quantity { get; set; }
    public string Sigla { get; set; }          
    public string Room { get; set; }  // cozinha, dispensa...       
    public string StorageArea { get; set; }  // geladeira, armario... 
    public string SpecificLocation { get; set; } // prateleira de cima, prateleira do meio...

    public StorageModel(int storageID, string foodItem, int quantity, string sigla, string room, string storageArea, string specific)
    {
        StorageID = storageID;
        FoodItem = foodItem;
        Quantity = quantity;
        Sigla = sigla;
        Room = room;
        StorageArea = storageArea;
        SpecificLocation = specific;
    }

    public StorageModel()
    {
    }

    public override string ToString()
    {
        return $"[{StorageID}, {Quantity}{Sigla} {FoodItem} stored at {SpecificLocation} in {StorageArea}, {Room}]";
    }

    public override bool Equals(object? obj)
    {
        if (obj is StorageModel other)
        {
            return other.StorageID == StorageID;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return StorageID.GetHashCode();
    }
}
