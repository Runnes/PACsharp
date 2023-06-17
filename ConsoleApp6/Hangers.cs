namespace ConsoleApp6;

public abstract class Hanger
{
    public List<Clothing> Clothes { get; set; }

    public abstract void AddClothing(Clothing clothing);
    public abstract void RemoveClothing(Clothing clothing);
}

public class SingleHanger : Hanger
{
    public SingleHanger()
    {
        Clothes = new List<Clothing>();
    }

    public override void AddClothing(Clothing clothing)
    {
        if (clothing.Type == "Shirt" || clothing.Type == "Blouse")
        {
            Clothes.Add(clothing);
        }
        else
        {
            throw new ArgumentException("Invalid type of hanger, you need double for that");
        }
    }

    public override void RemoveClothing(Clothing clothing)
    {
        Clothes.Remove(clothing);
    }
}



public class DoubleHanger : Hanger
{
   public bool hasShirtOrBlouse;
   public bool hasTrousersOrSkirt;

   public DoubleHanger()
   {
       Clothes = new List<Clothing>();
       hasShirtOrBlouse = false;
       hasTrousersOrSkirt = false;
   }

   public override void AddClothing(Clothing clothing)
   {
       if (clothing.Type == "Shirt" || clothing.Type == "Blouse")
       {
           if (!hasShirtOrBlouse)
           {
               Clothes.Add(clothing);
               hasShirtOrBlouse = true;
           }
           else
           {
               throw new InvalidOperationException("Hanger already has a shirt or blouse");
           }
       }
       else if (clothing.Type == "Trousers" || clothing.Type == "Skirt")
       {
           if (!hasTrousersOrSkirt)
           {
               Clothes.Add(clothing);
               hasTrousersOrSkirt = true;
           }
           else
           {
               throw new InvalidOperationException("Hanger already has trousers or a skirt");
           }
       }
       else
       {
           throw new ArgumentException("Invali");
       }
   }

   public override void RemoveClothing(Clothing clothing)
   {
       Clothes.Remove(clothing);

       if (clothing.Type == "Shirt" || clothing.Type == "Blouse")
       {
           hasShirtOrBlouse = false;
       }
       else if (clothing.Type == "Trousers" || clothing.Type == "Skirt")
       {
           hasTrousersOrSkirt = false;
       }
   }
}