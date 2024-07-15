namespace NoughtsAndCrosses;

public class Place
{
    public char mark { get; set; }
    public bool isEmpty { get; set; }

    public Place()
    {
        bool isEmpty = true;
        mark = ' ';
    }
}