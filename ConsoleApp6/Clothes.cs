namespace ConsoleApp6;

public abstract class Clothing //abstract zeby nie mozna bylo stworzyc instancji, zeby uzyc tylko jako base
{
    public int ID { get; set; }
    public string Brand { get; set; }
    public string Type { get; set; }
}

public class Shirt : Clothing
{
    public Shirt()
    {
        Type = "Shirt";
    }
}

public class Blouse : Clothing
{
    public Blouse()
    {
        Type = "Blouse";
    }
}

public class Trousers : Clothing
{
    public Trousers()
    {
        Type = "Trousers";
    }
}

public class Skirt : Clothing
{
    public Skirt()
    {
        Type = "Skirt";
    }
}