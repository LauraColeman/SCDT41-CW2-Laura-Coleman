using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CW2
{
    class Program
    {
     


        static void Main(string[] args)
        {


            Console.WriteLine("Press 1 for admin access. Press 2 for nurse access. Press 3 for doctor access");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Admin admin = new Admin("administrator", "admin", "admin");
                admin.adminLogIn();


            }

            else if (choice == "2")
            {

                Test Nurse1 = new Test();
                Nurse1.LogIn2();



            }


            else if(choice == "3")
            {


            }


            //Add other choice for patients?
            












        }
    }
}


