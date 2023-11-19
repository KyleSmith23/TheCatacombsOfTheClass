
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
    public static Colour White { get; } = new(255, 255, 255);
    public static Colour Black(){ 
        Colour black = new(0, 0, 0);
        return black; 
    }

}

public class Card
{
    public CardColour Colour { get; }
    public Rank Rank {  get; }

    public Card(CardColour colour, Rank rank){
        Colour = colour;
        Rank = rank;
    }

    public bool IsCardNumber => Rank <= Rank.Ten;
    public bool IsCardSymbol => !IsCardNumber;
    
}

public class Door
{
    public DoorState State { get; private set; }
    private int _currentPassword;

    public Door(int initialPassword) { 
        State = DoorState.Closed;
        _currentPassword = initialPassword;    
    }

    public void ChangePassword(int currentPassword, int newPassword)
    {
        if (currentPassword == _currentPassword) { _currentPassword = newPassword; }
        else { Console.WriteLine("Incorrect Password"); }

    }

    public void Close(){ if (State == DoorState.Open){ State = DoorState.Closed;} }
    public void Open() { if (State == DoorState.Closed) { State = DoorState.Open; } }
    public void Lock() { if (State == DoorState.Closed) { State = DoorState.Locked;} }
    public void Unlock(int password) {
        if (State == DoorState.Locked && password == _currentPassword)
        {
            State = DoorState.Closed;
        }
        else { Console.WriteLine("Password incorrect"); }
    }
}