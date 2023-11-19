// Level 24 BOSS BATTLE -The Catacombs of the class
//The Point
using System.Drawing;

Point p1 = new Point(2, 3);
Point p2 = new Point(-4, 0);

DisplayPoint(p1);
DisplayPoint(p2);

ChallengeEnd();

// The Colour
Colour colour1 = new(125, 125, 125);
Colour white = Colour.White();

DisplayColour(colour1);
DisplayColour(white);

ChallengeEnd();

// The Card





// Challenge end method
void ChallengeEnd()
{
    Console.WriteLine();
    Console.WriteLine("**********");
}

// The point
void DisplayPoint(Point p)
{
    Console.WriteLine($"({p.X}, {p.Y})");
}

void DisplayColour(Colour colour)
{
    Console.WriteLine($"{colour.Red}, {colour.Green}, {colour.Blue}");
}