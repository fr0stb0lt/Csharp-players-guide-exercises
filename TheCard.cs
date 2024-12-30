namespace The_Card;


public class Program
{
    public static void Main(string[] args)
    {
        

       foreach (cardColor color in Enum.GetValues(typeof(cardColor)))
       {
           foreach (cardRank rank in Enum.GetValues(typeof(cardRank)))
           {
               
               Card card = new Card(color, rank);
               Console.WriteLine($"{color}: {rank}");
               card.IsFace();
           }
           
       }

    }
    
}


public class Card
{
    
    
    public cardColor color { get; }
    public cardRank rank { get; }



    public Card(cardColor color, cardRank rank)
    {
        this.color = color;
        this.rank = rank;
    }


    public bool IsFace()
    {
        if (rank <= cardRank.Ten)
        {
            Console.WriteLine("This card is a number card.");
            return true;
        }
        else
        {
            Console.WriteLine("This card is a face card.");
            return false;
        }
        
    }
    
    
}   
    

public enum cardColor
{
    Red,
    Green,
    Blue,
    Yellow
}

public enum cardRank
{
    One = 1,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Dollarsign,
    Percentage,
    Caret,
    Ampersand
}
