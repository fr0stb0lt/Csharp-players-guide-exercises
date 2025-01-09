namespace theDoor;


class Program
{

    public static void Main(string[] args)
    {
        bool exit = false;

        
        Console.WriteLine("You stand in front of a magical door, with a keypad on the side.");
        
        Door door = new Door(1234);
        while (!exit)
        {
            
            Console.WriteLine($"What would you like to do? The door is currently {door.GetDoorState()}");
            Console.WriteLine("Available actions:");
            Console.WriteLine("1: Try to open the door:");
            Console.WriteLine("2: Close the door:");
            Console.WriteLine("3: Lock the door:");
            Console.WriteLine("4: Unlock the door:");
            Console.WriteLine("5: Change lock code:");

            string doorChoice = Console.ReadLine();
            door = doorChoice switch
            {
                "1" => door.OpenDoor(),
                "2" => door.CloseDoor(),
                "3" => door.LockDoor(),
                "4" => door.UnLockDoor(),
                "5" => door.ChangeLockCode()

            };


        }

    }






}


class Door
{
    
    private int _lockCode;

    public int LockCode { get => _lockCode; set => _lockCode = value; }
    
    
    public Door(int lockCode)
    {
        LockCode = lockCode;
    }


    
    
    
    

    public DoorState CurrentDoorState = DoorState.Open;


    public DoorState GetDoorState()
    {

        return CurrentDoorState;

    }




    // Opening the door
    public Door OpenDoor()
    {
        switch (CurrentDoorState)
        {
            case DoorState.Closed:
                CurrentDoorState = DoorState.Open;
                Console.WriteLine("The door is now open");
                break;
            case DoorState.Unlocked:
                CurrentDoorState = DoorState.Open;
                Console.WriteLine("The door is now open");
                break;
            case DoorState.Locked:
                Console.WriteLine("The door is locked.");


                // code to enter keycode
                break;
            default:
                Console.WriteLine("The door was already open...");
                break;
        }
        
        return this;
    }

    public Door CloseDoor()
    {
        switch (CurrentDoorState)
        {
            case DoorState.Open:
                CurrentDoorState = DoorState.Closed;
                Console.WriteLine("The door is now closed");
                break;
            case DoorState.Locked:
                Console.WriteLine("The door is closed and locked.");
                break;
            default:
                Console.WriteLine("The door was already closed...");
                break;
        }
        
        return this;
    }


    public Door LockDoor()
    {
        CurrentDoorState = DoorState.Locked; 
        Console.WriteLine("The door is now locked"); 
        return this;
        
    }
    
    public Door UnLockDoor()
    {
        Console.WriteLine("Please enter the lock code:");
        int userInput = Convert.ToInt32(Console.ReadLine());
        if(userInput == _lockCode)
        {
            CurrentDoorState = DoorState.Unlocked; 
            Console.WriteLine("Lock code correct. Door unlocked.");
        } else
        {
            Console.WriteLine("Lock code incorrect. Access denied.");
        }
        
       
        return this;
        
    }

    public Door ChangeLockCode()
    {
        Console.WriteLine("Please enter the old lock code:");
        int userInput = Convert.ToInt32(Console.ReadLine());
        if (userInput == _lockCode)
        {
            Console.WriteLine("Lock code correct. Please enter the new lock code:");
            var userCode = Convert.ToInt32(Console.ReadLine());
            _lockCode = userCode;
            
        }
        else
        {
            Console.WriteLine("Lock code incorrect.");
        }


        return this;

    }
    
    
    
    
    
  public enum DoorState
    {
        Open,
        Closed,
        Locked,
        Unlocked
    }

    




}
