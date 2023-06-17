using ConsoleApp6;


Wardrobe.Instance.SetAmtHangers(10);
Wardrobe.Instance.HowManyHangers();
Hanger hangerSingle = new SingleHanger();

// Clothing shirt = new Shirt();

// Wardrobe.Instance.AddHanger(hangerSingle);
// Console.WriteLine(Wardrobe.Instance.ReturnList());

Clothing shirt = new Shirt { ID = 1, Brand = "Karol" };
hangerSingle.AddClothing(shirt);
Wardrobe.Instance.AddHanger(hangerSingle);

Clothing trousers = new Trousers{ID =2, Brand = "Polska"};
Hanger hangerDouble = new DoubleHanger();
hangerDouble.AddClothing(trousers);
Wardrobe.Instance.AddHanger(hangerDouble);


Clothing blouse = new Blouse { ID = 3, Brand = "Csharp" };
hangerDouble.AddClothing(blouse);
// hangerDouble.AddClothing(blouse);//test na dwa razy dodanie clothingu tego samego/
// Clothing skirt2 = new Skirt { ID = 3, Brand = "xxxxx" }; //proba dodania innej rzeczy z tej samej "kategorii"
// hangerDouble.AddClothing(skirt2);
Wardrobe.Instance.AddHanger(hangerDouble);



Hanger hangerDouble2 = new DoubleHanger();
Wardrobe.Instance.AddHanger(hangerDouble2);


Wardrobe.Instance.Print();
//
Wardrobe.Instance.GetClothing(2); //TO USUWA/wyciaga z szafy - najwazniejsza linijka - do pokazania
Wardrobe.Instance.Print();
Wardrobe.Instance.HowManyHangers();

// Console.WriteLine(Wardrobe.Instance.HasEmptyHanger("Double"));
// Console.WriteLine(Wardrobe.Instance.HasEmptyHanger("Trousers"));

// Wardrobe.Instance.HasEmptyHanger("Trousers");
Console.WriteLine(Wardrobe.Instance.HasEmptyHanger2("Trousers"));
