namespace NoughtsAndCrosses;

public class Board
{

    private Place[,] board;
    private Boolean winCheck;

    public Board()
    {
        board = new Place[3, 3];
        winCheck = false;
        generateBoard();
    }

    public void generateBoard()
    {
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                board[row, col] = new Place();
            }
        }
    }
    
    public void startGame()
    {
        while (!winCheck)
        {
            displayBoard();
            makeMove();
        }
    }

    public void displayBoard()
    {
        string middleLine = "---+---+---";
        Console.Write(board[0,0].mark + "  | " + board[0,1].mark + " |  "+ board[0,2].mark + "\n");
        Console.WriteLine(middleLine);
        Console.Write(board[1,0].mark + "  | " + board[1,1].mark + " |  "+ board[1,2].mark + "\n");
        Console.WriteLine(middleLine);
        Console.Write(board[2,0].mark + "  | " + board[2,1].mark + " |  "+ board[2,2].mark + "\n");
    }

    public void makeMove()
    {
        
    }
    
}