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
Colour white = Colour.White;
Colour black = Colour.Black();


DisplayColour(colour1);
DisplayColour(white);
DisplayColour(black);

ChallengeEnd();

// The Card
CreateDeck();

ChallengeEnd();

// The Door
Console.WriteLine("Set a password with 4 numbers..");

int newPassword = Convert.ToInt32(Console.ReadLine());

Door door1 = new(newPassword);

while (true)
{
    Console.WriteLine("Change door state. Or change password..");
    string input = Console.ReadLine();

    switch (input)
    {
        case "open":
            door1.Open();
            break;
        case "close":
            door1.Close();
            break;
        case "lock":
            door1.Lock(); 
            break;
        case "unlock":
            Console.WriteLine("Enter password");
            int password = Convert.ToInt32(Console.ReadLine());
            door1.Unlock(password);
            break;
        case "change password":
            Console.WriteLine("Please enter the current password");
            int crrntPsswrd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the new password");
            int nwPsswrd = Convert.ToInt32(Console.ReadLine());
            door1.ChangePassword(crrntPsswrd, nwPsswrd);
            break;
        default: 
            Console.WriteLine("Unknown command");
            break;
    }

    Console.WriteLine($"The door is currently {door1.State}");

}




// METHODS
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

// The Card
void CreateDeck()
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 14; j++) {

            Card card = new Card((CardColour)i, (Rank)j);
            Console.WriteLine($"The card {card.Colour} {card.Rank}");

        }
    }
}

public enum CardColour
{
    Red, Green, Blue, Yellow
}

public enum Rank
{
    One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Dollar, Percent, Power, Ampersand
}

public enum DoorState { Open, Closed, Locked}