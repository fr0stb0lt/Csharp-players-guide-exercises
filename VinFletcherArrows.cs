Arrow NewArrow = GetArrow();
Console.WriteLine($"The price of your arrow is {NewArrow.GetCost()} gold.");


    Arrow GetArrow(){
        Arrow.ArrowHeadType ah = GetArrowHead();
        Arrow.FletchingType ft = GetFletchingType();
        float Arrowlength = GetArrowLength();
        return new Arrow (ah,ft,Arrowlength);
    }




    Arrow.ArrowHeadType  GetArrowHead(){
        Console.Write("What kind of arrowhead would you like? steel, wood or obsidian?");
        string UserArrowHeadChoice = Console.ReadLine().ToLower();
        return UserArrowHeadChoice switch{
        "steel" => Arrow.ArrowHeadType.steel,
        "wood" => Arrow.ArrowHeadType.wood,
        "obsidian" =>Arrow.ArrowHeadType.obsidian,
        _ => Arrow.ArrowHeadType.invalid
            };
            
    }

    Arrow.FletchingType  GetFletchingType(){
        Console.Write("What kind of fletching would you like? plastic, turkeyfeathers or goosefeathers?");
        string UserFletchingChoice = Console.ReadLine().ToLower();
        return UserFletchingChoice switch{
        "plastic" => Arrow.FletchingType.plastic,
        "wood" => Arrow.FletchingType.turkeyfeathers,
        "obsidian" => Arrow.FletchingType.goosefeathers,
        _ => Arrow.FletchingType.invalid
            };
    }

    float GetArrowLength(){
    Console.Write("What length should the arrow be?");
    string UserArrowLengthChoice = Console.ReadLine();
    return Convert.ToInt32(UserArrowLengthChoice);
    }




class Arrow {


    // Fields
    public ArrowHeadType ArrowHead;
    public FletchingType Fletching;
    public float Arrowlength; //Price 0.05 gold per centimeter


    public float GetCost(){
        // Costs for arrowheads: steel 10 gold, wood 3 gold, obsidian 5 gold
        // Fletching cost: plastic 10 g, turkey feathers 5 gold, goose feather 3 gold.
        // Price 0.05 gold per centimeter
        
        float ArrowHeadCost = ArrowHead switch{
            ArrowHeadType.steel => 10,
            ArrowHeadType.wood => 3,
            ArrowHeadType.obsidian => 5
        };

        float FletchingCost = Fletching switch{
            FletchingType.plastic => 10,
            FletchingType.turkeyfeathers => 5,
            FletchingType.goosefeathers => 3
        };

        float lengthcost = 5 * Arrowlength;
        return ArrowHeadCost + FletchingCost + lengthcost;
    }




    // Constructor
    public Arrow(ArrowHeadType ArrowHead, FletchingType Fletching, float Arrowlength) { 
        this.ArrowHead = ArrowHeadType.steel;
        this.Fletching = FletchingType.goosefeathers;
        Arrowlength = 60; 
    }

    public enum ArrowHeadType{  //costs for arrowheads: steel 10 gold, wood 3 gold, obsidian 5 gold
    steel,wood,obsidian,invalid
    }


    public enum FletchingType { // Fletching cost: plastic 10 g, turkey feathers 5 gold, goose feather 3 gold.
    plastic,turkeyfeathers,goosefeathers,invalid
    }

}
