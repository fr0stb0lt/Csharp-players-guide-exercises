
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
[] Make it so you can perform the four transitions defined above with methods.
[] Build a constructor that requires the starting numeric passcode.
[] Build a method that will allow you to change the passcode for an existing door by supplying the
current passcode and new passcode.Only change the passcode if the current passcode is correct.
[] Make your main method ask the user for a starting passcode, then create a new Door instance.Allow
the user to attempt the four transitions described above (open, close, lock, unlock) and change the
code by typing in text commands.
*/

namespace theDoor;


class Program
{

    public static void Main(string[] args)
    {


        Door newDoor = new Door();
        Console.WriteLine("You stand in front of a magical door, with a keypad on the side.");

        // menu with choices
        
        
        //Keep repeating menu
        
        
            Console.WriteLine($"What would you like to do? The door is currently {newDoor.GetDoorState()}");
            Console.WriteLine("Available actions:");
            Console.WriteLine("Try to open the door:");
            Console.WriteLine("Close the door:");
            Console.WriteLine("Lock the door:");
        


    }






}


class Door
{

    //Constructor
    


    DoorState currentDoorState = DoorState.Open;


    public DoorState GetDoorState()
    {

        return currentDoorState;

    }




    // Opening the door
    public void OpenDoor()
    {
        if (currentDoorState == DoorState.Closed)
        {

            currentDoorState = DoorState.Open;
            Console.WriteLine("The door is now open");

        }else if (currentDoorState == DoorState.Locked)
        {
            Console.WriteLine("The door is locked, please enter the keycode to enter:");


            // code to enter keycode



        } else
        {
            Console.WriteLine("The door was already open...");

        }




    }


  public enum DoorState
    {
        Open,
        Closed,
        Locked
    }

    




}
