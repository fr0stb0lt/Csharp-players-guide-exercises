
/*
Boss Battle The Locked Door 100 XP

The fourth pedestal demands constructing a door class with a locking mechanism that requires a unique
numeric code to unlock. You have done something similar before without using a class, but the locking
mechanism is new.The door should only unlock if the passcode is the right one. The following statements
describe how the door works.
• An open door can always be closed.
• A closed (but not locked) door can always be opened.
• A closed door can always be locked.
• A locked door can be unlocked, but a numeric passcode is needed, and the door will only unlock if
the code supplied matches the door’s current passcode.
• When a door is created, it must be given an initial passcode.
• Additionally, you should be able to change the passcode by supplying the current code and a new
one.The passcode should only change if the correct, current code is given.


Objectives:
[x] Define a Door class that can keep track of whether it is locked, open, or closed.

[x] Make it so you can perform the four transitions defined above with methods.

[x] Build a constructor that requires the starting numeric passcode.

[] Build a method that will allow you to change the passcode for an existing door by supplying the
current passcode and new passcode. Only change the passcode if the current passcode is correct.

[] Make your main method ask the user for a starting passcode, then create a new Door instance.Allow
the user to attempt the four transitions described above (open, close, lock, unlock) and change the
code by typing in text commands.

*/



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

    public int LockCode { get => LockCode; set => LockCode = value; }
    
    
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


        CurrentDoorState = DoorState.Unlocked; 
        Console.WriteLine("The door is now locked"); 
        return this;
        
    }

    public Door ChangeLockCode()
    {
        Console.WriteLine("Please enter the old lock code:");
        var userInput = Convert.ToInt32(Console.ReadLine());
        


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
