ChestStatus currentChestStatus = ChestStatus.Locked;
// set default state to Locked

bool DoingIt = true;

while (DoingIt == true)
{

    Console.WriteLine($"The chest is currently {currentChestStatus}, What would you like to do with the chest?");
    string userInput = Console.ReadLine();
    
    if (userInput == "exit") { DoingIt = false; }

    if ((userInput == "lock" )&& (currentChestStatus == ChestStatus.Closed) )
    {
        currentChestStatus = ChestStatus.Locked;
        Console.WriteLine("The chest is locked.");
    }
    if ((userInput == "unlock") && (currentChestStatus == ChestStatus.Locked))
    {
        currentChestStatus = ChestStatus.Unlocked;
        Console.WriteLine("The chest is unlocked.");
    }
    if ((userInput == "close") && (currentChestStatus == ChestStatus.Open))
    {
        currentChestStatus = ChestStatus.Closed;
        Console.WriteLine("The chest is closed.");
    }
    if ((userInput == "open") && (currentChestStatus == ChestStatus.Unlocked))
    {
        currentChestStatus = ChestStatus.Open;
        Console.WriteLine("The chest is opened.");
    }
    

}
