Arrow NewArrow = GetArrow();
Console.WriteLine($"The price of your arrow is {NewArrow.GetCost()} gold.");


Arrow GetArrow()
{
ArrowHeadType ah = GetArrowHead();
FletchingType ft = GetFletchingType();
float Arrowlength = GetArrowLength();
return new Arrow(ah, ft, Arrowlength);
}




ArrowHeadType GetArrowHead()
{
Console.Write("What kind of arrowhead would you like? steel, wood or obsidian?");
string UserArrowHeadChoice = Console.ReadLine().ToLower();
return UserArrowHeadChoice switch
{
"steel" => ArrowHeadType.steel,
"wood" => ArrowHeadType.wood,
"obsidian" => ArrowHeadType.obsidian,
_ => ArrowHeadType.invalid
};

}

FletchingType GetFletchingType()
{
Console.Write("What kind of fletching would you like? plastic, turkeyfeathers or goosefeathers?");
string UserFletchingChoice = Console.ReadLine().ToLower();
return UserFletchingChoice switch
{
"plastic" => FletchingType.plastic,
"wood" => FletchingType.turkeyfeathers,
"obsidian" => FletchingType.goosefeathers,
_ => FletchingType.invalid
};
}

float GetArrowLength()
{
Console.Write("What length should the arrow be?");
string UserArrowLengthChoice = Console.ReadLine();
return Convert.ToInt32(UserArrowLengthChoice);
}




class Arrow
{


    // Fields
    private ArrowHeadType _ArrowHead;
    private FletchingType _Fletching;
    private float _Arrowlength; //Price 0.05 gold per centimeter

    // Properties
    public ArrowHeadType ArrowHeadType { 
        get { return ArrowHeadType; }
        set { ArrowHeadType = value; }
    }

    public FletchingType FletchingType
    {
        get { return FletchingType; }
        set { FletchingType = value; }
    }

    public float Arrowlength { 
        get { return Arrowlength; } 
        set {  Arrowlength = value; }
    }






/*  Get Methods
    public ArrowHeadType GetArrowhead() => _ArrowHead;

    public FletchingType GetFletchingType() => _Fletching;
    public float GetLength() => _Arrowlength;
*/







    public float GetCost()
    {
        // Costs for arrowheads: steel 10 gold, wood 3 gold, obsidian 5 gold
        // Fletching cost: plastic 10 g, turkey feathers 5 gold, goose feather 3 gold.
        // Price 0.05 gold per centimeter

        float ArrowHeadCost = _ArrowHead switch
        {
            ArrowHeadType.steel => 10,
            ArrowHeadType.wood => 3,
            ArrowHeadType.obsidian => 5
        };

        float FletchingCost = _Fletching switch
        {
            FletchingType.plastic => 10,
            FletchingType.turkeyfeathers => 5,
            FletchingType.goosefeathers => 3
        };

        float lengthcost = 5 * _Arrowlength;
        return ArrowHeadCost + FletchingCost + lengthcost;
    }






    // Constructor
    public Arrow(ArrowHeadType ArrowHead, FletchingType Fletching, float Arrowlength)
    {
        this._ArrowHead = ArrowHeadType.steel;
        this._Fletching = FletchingType.goosefeathers;
        Arrowlength = 60;
    }



}

public enum ArrowHeadType
{  //costs for arrowheads: steel 10 gold, wood 3 gold, obsidian 5 gold
    steel, wood, obsidian, invalid
}


public enum FletchingType
{ // Fletching cost: plastic 10 g, turkey feathers 5 gold, goose feather 3 gold.
    plastic, turkeyfeathers, goosefeathers, invalid
}




