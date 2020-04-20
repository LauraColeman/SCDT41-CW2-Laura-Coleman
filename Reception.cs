using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW22
{
    class Reception 
    {

        private string username;
        private string password;
        private string practice;
        private string name;

        public string UserName { get => username; set => username = value; }
        public string passWord { get => password; set => password = value; }
        public string Practice { get => practice; set => practice = value; }
        public string Name { get => name; set => name = value; }

        //Constructor for receptionists
        public Reception(string name, string practice, int room, string username, string password)

        {
            this.username = UserName;
            this.password = passWord;
            this.practice = Practice;
            this.name = Name;
        }


        //Method to Log In
        public void LogIn()
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

                if (username != UserName && password != passWord)
                    Attempts++;
                else
                    break;
            }

            //Display the result
            if (Attempts > 2)
                Console.WriteLine("Login failure");
            else
                Console.WriteLine("Welcome {0}", Name);

            Console.ReadKey();

        }

        //Method to book appointments
        //Method to edit patients
        //Method to view patients



    }
}
