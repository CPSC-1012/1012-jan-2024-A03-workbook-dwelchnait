// See https://aka.ms/new-console-template for more information
Console.WriteLine("\nTic-Tac-Toe\n");

/****************** driver ***********************************/

//2D array to represent the game board
string[,] gameBoard = new string[5, 5];

InitializeBoard(gameBoard);
//DisplayGameBoard(gameBoard);

PlayGame(gameBoard);

/****************** methods ***********************************/

static void InitializeBoard(string[,] gameBoard)
{
    int cellId = 1;
    for(int r = 0; r < 5; r++)
    {
        for (int c = 0; c < 5; c++)
        {
            if(c == 1 || c == 3)
            {
                gameBoard[r, c] = "|";
            }
            else if (r == 1 || r == 3)
            {
                gameBoard[r, c] = "-";
            }
            else
            {
                gameBoard[r, c] = cellId.ToString();
                cellId++;
            }
        }
    }
}

static void DisplayGameBoard(string[,] gameBoard)
{
    for (int r = 0; r < 5; r++)
    {
        for (int c = 0; c < 5; c++)
        {
            Console.Write(gameBoard[r, c]);
        }
        Console.WriteLine();
    }
}

static void PlayGame(string[,] gameBoard)
{
    DisplayGameBoard(gameBoard);
    int turns = 0;
    int cellId = 1;
    bool valid = false;
    while (turns < 9)
    {
        if (turns % 2 == 0)
        {
            cellId = PromptForCell("PLayer X select an unused cell number:\t");
            valid = PlaceSymbol("X", cellId, gameBoard);
        }
        else
        {
            cellId = PromptForCell("PLayer O select an unused cell number:\t");
            valid = PlaceSymbol("O", cellId, gameBoard);
        }
        DisplayGameBoard(gameBoard);
        if (valid)
        {
            //TODO: here is where the method for deciding a win has happened it called
            turns++;
        }
       
    }
}

static int PromptForCell(string prompt)
{
    string inputValue = "";
    Console.Write($"\n{prompt}");
    inputValue = Console.ReadLine();
    return int.Parse(inputValue);
}

static bool PlaceSymbol(string symbol, int cellid, string[,] gameBoard)
{
    //remember the values for rows and columns are indexes
    //therefore row 1 is index 0, column 1 is index 0
    bool valid = true;
    switch (cellid)
    {
        case 1:
            {
                if (gameBoard[0,0].Equals("X") || gameBoard[0, 0].Equals("O"))
                {
                    Console.WriteLine("\nCell has already be choosen. Select an unused cell\n");
                    valid = false;
                }
                else
                {
                    gameBoard[0, 0] = symbol;
                }
             
                break;
            }
        case 2:
            {
                if (gameBoard[0, 2].Equals("X") || gameBoard[0, 2].Equals("O"))
                {
                    Console.WriteLine("\nCell has already be choosen. Select an unused cell\n");
                    valid = false;
                }
                else
                {
                    gameBoard[0, 2] = symbol;
                }
                break;
            }
        case 3:
            {
                if (gameBoard[0, 4].Equals("X") || gameBoard[0, 4].Equals("O"))
                {
                    Console.WriteLine("\nCell has already be choosen. Select an unused cell\n");
                    valid = false;
                }
                else
                {
                    gameBoard[0, 4] = symbol;
                }
                break;
            }
        case 4:
            {
                if (gameBoard[2, 0].Equals("X") || gameBoard[2, 0].Equals("O"))
                {
                    Console.WriteLine("\nCell has already be choosen. Select an unused cell\n");
                    valid = false;
                }
                else
                {
                    gameBoard[2, 0] = symbol;
                }
                break;
            }
        case 5:
            {
                if (gameBoard[2, 2].Equals("X") || gameBoard[2, 2].Equals("O"))
                {
                    Console.WriteLine("\nCell has already be choosen. Select an unused cell\n");
                    valid = false;
                }
                else
                {
                    gameBoard[2, 2] = symbol;
                }
                break;
            }
        case 6:
            {
                if (gameBoard[2, 4].Equals("X") || gameBoard[2, 4].Equals("O"))
                {
                    Console.WriteLine("\nCell has already be choosen. Select an unused cell\n");
                    valid = false;
                }
                else
                {
                    gameBoard[2, 4] = symbol;
                }
                break;
            }
        case 7:
            {
                if (gameBoard[4, 0].Equals("X") || gameBoard[4, 0].Equals("O"))
                {
                    Console.WriteLine("\nCell has already be choosen. Select an unused cell\n");
                    valid = false;
                }
                else
                {
                    gameBoard[4, 0] = symbol;
                }
                break;
            }
        case 8:
            {
                if (gameBoard[4, 2].Equals("X") || gameBoard[4, 2].Equals("O"))
                {
                    Console.WriteLine("\nCell has already be choosen. Select an unused cell\n");
                    valid = false;
                }
                else
                {
                    gameBoard[4, 2] = symbol;
                }
                break;
            }
        case 9:
            {
                if (gameBoard[4, 4].Equals("X") || gameBoard[4, 4].Equals("O"))
                {
                    Console.WriteLine("\nCell has already be choosen. Select an unused cell\n");
                    valid = false;
                }
                else
                {
                    gameBoard[4, 4] = symbol;
                }
                break;
            }
        default:
            {
                Console.WriteLine("You cell choice is incorrect. Choice value 1-9");
                valid=false;
                break;
            }

    }
    return valid;
}
