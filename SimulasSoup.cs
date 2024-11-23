using System.Collections;

(Type Type, MainIngredient MainIngredient, Seasoning Seasoning) Soup = GetSoup();
Console.WriteLine($"{Soup.Seasoning} {Soup.MainIngredient} {Soup.Type}");


(Type, MainIngredient, Seasoning) GetSoup(){
    Type type = getUserSoupChoice();
    MainIngredient ingredient = getUserMainIngrChoice();
    Seasoning seasoning = getUserSeasoningChoice();
    return (type,ingredient,seasoning);

}

Type getUserSoupChoice(){
    Console.Write("Soup type? (soup, stew, gumbo): ");
string UserSoupChoice = Console.ReadLine();
return UserSoupChoice switch
{
    "soup" => Type.soup,
    "stew" => Type.stew,
    "gumbo" => Type.gumbo

};
}

MainIngredient getUserMainIngrChoice(){
    Console.Write("Main ingredient? (mushroom,chicken,carrot,potatoes): ");
string UserMainIngrChoice = Console.ReadLine();
return UserMainIngrChoice switch
{
    "mushroom" => MainIngredient.mushroom,
    "chicken" => MainIngredient.chicken,
    "carrot" => MainIngredient.carrot,
    "potatoes" => MainIngredient.potatoes
};
}

Seasoning getUserSeasoningChoice(){
    Console.Write("Seasoning? (spicy, salty, sweet): ");
string UserSeasoningChoice = Console.ReadLine();
return UserSeasoningChoice switch
{
    "spicy" => Seasoning.spicy,
    "salty" => Seasoning.salty,
    "sweet" => Seasoning.sweet,
};
}


Console.WriteLine($"This is your chosen soup: {Soup.Seasoning} {Soup.MainIngredient} {Soup.Type}");

enum Type { soup, stew, gumbo }
enum MainIngredient { mushroom, chicken, carrot, potatoes }
enum Seasoning { spicy, salty, sweet }
