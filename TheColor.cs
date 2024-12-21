namespace MyNamespace;

class Program
{
    public static void Main(string[] args)
    {
        Color Snow = Color.White;
        Color GimmeAColor = new Color(10, 150, 200);
        
        
        
        Console.WriteLine($"Snow exists of: Red: {Snow.Redb}, Green: {Snow.Greenb}, Blue: {Snow.Blueb}");
        Console.WriteLine($"GimmeAColort exists of: Red: {GimmeAColor.Redb}, Green: {GimmeAColor.Greenb}, Blue: {GimmeAColor.Blueb}");
    }
    
    
}


class Color
{
    
// Constructor
    public Color(byte red, byte green, byte blue)
    {
        Redb = red;
        Greenb = green;
        Blueb = blue;
    }
    
// properties  
    public byte Redb { get;  }
    public byte Greenb { get; }
    public byte Blueb { get; }
 

    public static Color White { get; } = new Color(255, 255, 255);
    public static Color Black { get; } = new Color(0, 0, 0);
    public static Color Red { get; } = new Color(255, 0, 0);
    public static Color Blue { get; } = new Color(0, 0, 255);
    public static Color Yellow { get; } = new Color(255, 255, 0);
    public static Color Green { get; } = new Color(0, 255, 0);
    public static Color Orange { get; } = new Color(255, 128, 255);
    public static Color Purple { get; } = new Color(150, 0, 255);
    
    
    

}


