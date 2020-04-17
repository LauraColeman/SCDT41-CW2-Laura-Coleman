using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2
{
    class Admin
    {
        private string aName;
        private string aUsername;
        private string aPassword;

        //Constructor to create admin object.

        
        public Admin(string name, string username, string password)
        {
            this.aName = name;
            this.aUsername = username;
            this.aPassword = password;
                        
        }
        
        //Log In Function

        public void adminLogIn() //Restricts access to an admin and presents functions in a method.
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

                if (username != aUsername && password != aPassword)
                    Attempts++;
                else
                    break;
            }

            //Display the result
            if (Attempts > 2)
                Console.WriteLine("Login failure");
            else
                Console.WriteLine("Welcome {0}", aName);



            //Switch case to allow access to different methods depending on admins choice from the menu.

            int x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1: //Option 1

                    Console.WriteLine("Test");

                    break;



                case 2://Option 2


                    break;



                case 3://Option 3




                    break;



                case 4://Option 4

                   
                    break;



                case 5://Option 5
                   

                    break;


            }


            Console.ReadKey();

        }

    }

      
    }




    