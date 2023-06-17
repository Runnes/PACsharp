namespace ConsoleApp6;

public sealed class Wardrobe
{
    private int _maxHangers; //underscore jak jest private
    private static Wardrobe _instance;
    private static List<Hanger> _hangers = new List<Hanger>();

    private Wardrobe()
    {
         //private construktor zeby nie mozna bylo stworzyc dodatkowych instancji - tylko jedna
    }

    public static Wardrobe Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Wardrobe();
            }

            return _instance;
        }
    }

    public void SetAmtHangers(int maxHangers)
    {
        this._maxHangers = maxHangers;
    }

    public void HowManyHangers()
    {
        Console.WriteLine(_maxHangers);
    }

    public List<Hanger> ReturnList()
    {
        return _hangers;
    }
    
    public void Print()
    {
        Console.WriteLine("Wardrobe contents:");
        foreach (Hanger hanger in _hangers)
        {
            //Console.WriteLine("- Hanger: {0}", hanger.GetType().Name);
            foreach (Clothing clothing in hanger.Clothes)
            {
                Console.WriteLine("  - Clothing: ID = {0}, Brand = {1}, Type = {2}", clothing.ID, clothing.Brand, clothing.Type);
            }
        }
    }

    public void AddHanger(Hanger hanger)
    {
        if (_hangers.Count < _maxHangers)
        {
            _hangers.Add(hanger);
        }
        else
        {
            throw new InvalidOperationException("Wardrobe is full");
        }
    }
    public Clothing GetClothing(int id)
    {
        foreach (Hanger hanger in _hangers)
        {
            foreach (Clothing clothing in hanger.Clothes)
            {
                if (clothing.ID == id)
                {
                    hanger.RemoveClothing(clothing);
                    return clothing;
                }
            }
        }

        return null;
    }
    
    // public bool HasEmptyHanger(string type)
    // {
    //     foreach (Hanger hanger in _hangers)
    //     {
    //         if (hanger.Clothes.Count == 0 && hanger.GetType().Name.StartsWith(type))
    //         {
    //             return true;
    //         }
    //
    //         if (type == "Double" && hanger is DoubleHanger doubleHanger)
    //         {
    //             if (!doubleHanger.hasShirtOrBlouse || !doubleHanger.hasTrousersOrSkirt)
    //             {
    //                 return true;
    //             }
    //         }
    //     }
    //
    //     return false;
    // }
}
