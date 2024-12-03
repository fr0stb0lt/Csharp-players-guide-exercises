// Game variables
using System;

int distance_manticore = 0;

int city_health = 15;
int manticore_health = 10;
int damage = 0;

int turncounter = 1;

bool GameOver = false; 

// Game functions


   int cannon_Damage()
{
    if (turncounter % 3 == 0 && turncounter % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        damage = 10;
        Console.WriteLine("The cannon is espected to inflict 10 damage");
        return damage;
    }
    else if (turncounter % 3 == 0 || turncounter % 5 == 0)
    {

        Console.ForegroundColor = ConsoleColor.Red;
        damage = 3;
        Console.WriteLine("The cannon is espected to inflict 3 damage");
        return damage;
    }    
    else
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        damage = 1;
        Console.WriteLine("The cannon is espected to do 1 damage");
        return damage;
    }
}


    // Status

    void game_state()
{
    if (turncounter > 1 && manticore_health > 0)
    {
        city_health--;
    }
   


    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine("-----------------------------------------------------");
    Console.WriteLine($"STATUS: Round: {turncounter}  City: {city_health}/15  Manticore: {manticore_health}/10");
    cannon_Damage();
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine($"Enter Desired cannon range:");
    int user_range = Convert.ToInt32(Console.ReadLine());

    if ( user_range > distance_manticore)
    {

        Console.WriteLine($"That round OVERSHOT the target");


    }
    else if(user_range < distance_manticore)
    {
        Console.WriteLine($"That round FELL SHORT of the target");
            
    }
    else
    {
        Console.WriteLine($"That round was a DIRECT HIT!");

        // function to deal damage
        manticore_health = manticore_health - damage;
    }



}


// Game start


// Ask player 1 for a valid distance and store this in a var
while (distance_manticore == 0)
{
     

    Console.WriteLine("Player 1, enter a number between 0 and 100");
    int player1_distance = Convert.ToInt32(Console.ReadLine());


    if (player1_distance > 0 && player1_distance <= 100)
    {
        Console.WriteLine("Thank you for entering a valid distance.");
        Console.Clear();
        distance_manticore = player1_distance;

    }


}



// Player 2 turn
Console.WriteLine("Player 2 it is your turn.");


// Game
while (GameOver == false)
{
    game_state();



    turncounter++;
}
