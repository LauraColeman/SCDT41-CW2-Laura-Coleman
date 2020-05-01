using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2
{
    class Nurse : Staff 
    {

        
        //base to access constructor from Staff abstract class.
        public Nurse(string name, string practice, int room, string username, string password) :base(name, practice, room, username, password)

        {
            
        }

        








        //constructor from abstract class

      




        public void NurseLogIn()
        {

            //Login attempts counter
            int Attempts = 0;

            //Loop to limit login attempts into system.
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter username");
                string username = Console.ReadLine();
                Console.WriteLine("Enter password");
                string password = Console.ReadLine();

                if (username != userName && password != userPassword)
                    Attempts++;
                else
                    break;
            }

            //Display the result
            if (Attempts > 2)
                Console.WriteLine("Login failure");
            else
                Console.WriteLine("Welcome {0}", staffName);

            Console.ReadKey();

        }
    }

}
