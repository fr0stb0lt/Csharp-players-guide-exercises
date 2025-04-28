class Game {

  public static void Main(string[] args)
  {
    
    
    bool exit = false;
    bool playerOneTurn = true; 
    string[] board = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
    bool hasWon()
    {
      bool hrow1 = board[0] == board[1] && board[1] == board[2];
      bool hrow2 = board[3] == board[4] && board[4] == board[5];
      bool hrow3 = board[6] == board[7] && board[7] == board[8];
        
      bool drow1 = board[0] == board[4] && board[4] == board[8];
      bool drow2 = board[6] == board[4] && board[4] == board[2]; 
        
      bool vrow1 = board[0] == board[3] && board[3] == board[6];
      bool vrow2 = board[1] == board[4] && board[4] == board[7];
      bool vrow3 = board[2] == board[5] && board[5] == board[8];
        
      return hrow1 || hrow2 || hrow3 || drow1 || drow2 || vrow1 || vrow2 || vrow3;
    }

    void PrintBoard()
    {
    
      //rows
      for (var i = 0; i < 3; i ++){ 
      
      
        //column
        for (var j = 0; j < 3; j ++)
        {
          Console.Write("|" + (board[i * 3 + j]));
        

        }
        Console.WriteLine("|");
      
      
      }

    }




    Console.WriteLine("Welcome to Tic-Tac-Toe!");
    
                      
    
    
    while (!exit)
    {
      PrintBoard();
      if (playerOneTurn)
      {
        Console.Write("Player 1: Enter a fieldnumber to fill with X:");
      }
      else
      {
        Console.WriteLine("Player 2: Enter a fieldnumber to fill with O:");
      }
      
      string playerChoice = Console.ReadLine();

      if (board.Contains(playerChoice) && playerChoice != "X" && playerChoice != "O")
      {
        int index = Convert.ToInt32(playerChoice) - 1;

        if(playerOneTurn)
        {
          board[index] = "X";

          if (hasWon())
          {
            Console.WriteLine("Player 1 won!");
            PrintBoard();
            exit = true;

          }
          
          playerOneTurn = false;
        }
        else 
        {
          board[index] = "O";
          
          if (hasWon())
          {
            Console.WriteLine("Player 2 won!");
            PrintBoard();
            exit = true;
          }
          playerOneTurn = true;
        }
        
      }
  
    } 

  } 
  
}


  
  
  
  


 
 

  
  
