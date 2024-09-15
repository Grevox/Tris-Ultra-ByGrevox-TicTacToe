using Tic_tac_toe;

public class TicTacToe
{
    
    public static void Main(String[] args)
    {
        Console.WriteLine("TicTacToe by Grevox");
        Console.WriteLine("                   ");
        Console.WriteLine("                   ");
        Console.WriteLine("                   ");
        Console.WriteLine("                   ");
        Console.WriteLine("                   ");
        Console.WriteLine("                   ");
        Console.WriteLine("                   ");
        Console.WriteLine("                   ");
        Console.WriteLine("                   ");
        Console.WriteLine("                   ");
        Console.WriteLine("press C to change color or S to start the game  ");
        string CS = Console.ReadLine();
        if(CS == "C" || CS == "c") 
        {
            colorchange();
        
        }
        else if (CS == "S" || CS == "s")
        {
            callmeplease();

        }
        else if (CS == null)
        {
            Console.WriteLine("not a valid answer, please select one, or I'll come to your house and I'll play for you");
            callmeplease();
        }
        else if (CS == "secretfound")
        {
            Console.WriteLine("congrats! if u found this secret trough the terminal or looking inside the code, congrats!");
            Console.WriteLine("I'll probably make another game here LOL");
            Console.ReadLine();
            callmeplease();

        }
        else if (CS != "S" || CS != "s" && CS != "C"|| CS != "c" && CS != "secretfound") 
        {
            Console.WriteLine("this is not a valid answer. (there is a secret \n[not too secret]\n message when u write secretfound at the start, when it asks u if u want to start the game");
        
        }
        



    }

    public const string player = "Player1 always starts first";
    public static void colorchange() 
    {
        Console.WriteLine("choose a color:");
        Console.WriteLine(" W for white and B for Black or blue for blue");
        string colorchos = Console.ReadLine();
        if (colorchos == "w" || colorchos == "W") 
        {
            ConsoleColor backgroundColor = Console.BackgroundColor;
            { Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.Black; }

        }
        else if (colorchos == "B" || colorchos == "b")
        {
            ConsoleColor backgroundColor = Console.BackgroundColor;
            { Console.BackgroundColor = ConsoleColor.Black;  Console.ForegroundColor = ConsoleColor.White; };
            

        }
        else if (colorchos == "yellow")
        {
            ConsoleColor backgroundColor = Console.BackgroundColor;
            { Console.BackgroundColor = ConsoleColor.Yellow;}
        }
        else if (colorchos == "blue")
        {
            ConsoleColor backgroundColor = Console.BackgroundColor;
            { Console.BackgroundColor = ConsoleColor.Blue; Console.ForegroundColor = ConsoleColor.Black; };
        }

        callmeplease();
        
    
    
    }
    public static void callmeplease()
    {


        
        Console.CursorSize = 100;
        Console.CursorVisible = false;
        Console.SetWindowSize(5000, 5000);
        Console.Title = "Tic tac toe [TyToM]";
        Console.WriteLine("Hello, this, is tic tac toe in the terminal!!! ");
        Console.WriteLine("[Press enter to continue]");
        Console.ReadLine();
        Console.WriteLine(player);
        Console.ReadLine();

        var P1 = new Pl1();


    }
    
    }



