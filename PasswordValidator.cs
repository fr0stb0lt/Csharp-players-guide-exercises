


namespace ThePasswordValidator { 


    
    public class Program()
    {
        public static void Main(string[] args) {
            
            bool exit = false;
            while (!exit)
            {


                Console.WriteLine("Enter password to validate:");
                string chosenPassword = Console.ReadLine();


                if (chosenPassword.ToLower() == "exit")
                {
                    exit = true;
                }
                else
                {
                


                    PasswordValidator validation = new PasswordValidator();
                    char[] password = chosenPassword.ToCharArray();
                    validation.Validate(password);
                }

            }
        }


    }



    public class PasswordValidator
    {

        public void Validate(char[] password)
        {
            
            if (password.Length < 6)
            {
                Console.WriteLine("Password must contain at least 6 characters.");
                return;
            } 
            if (password.Length >= 13)
            {
                Console.WriteLine("Password must be 13 character or less.");
                return;
            }
            
            if (!password.Any(c => char.IsLower(c)))
            {
                Console.WriteLine("Password must contain at least one lowercase letter.");
                return;
            }
                
                
            if (!password.Any(c => char.IsUpper(c)))
            {
                Console.WriteLine("Password must contain at least one uppercase letter.");
                return;
            }
            
            
            if (password.Any(c => c is 'T' or '&')){
                Console.WriteLine("Password cannot contain 'T' or '&'.");
                return;

            }

            
        }
    }
}
