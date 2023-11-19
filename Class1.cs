
using System.Xml;

public class Point
{
    public int X { get;}
    public int Y { get;}
    public Point(int x, int y)
    {
        X = x; 
        Y = y;
    }

    public Point()
    {
        X=0;
        Y=0;
    }
}

public class Colour
{
    public int Red { get; }
    public int Green { get; }
    public int Blue { get; }

    public Colour(int red, int green, int blue){ 
        Red = red; 
        Green = green; 
        Blue = blue;
    }
    public static Colour White(){
        Colour white = new(255, 255, 255);
        return white;
    }
    public static Colour Black(){ 
        Colour black = new(0, 0, 0);
        return black; 
    }

}
