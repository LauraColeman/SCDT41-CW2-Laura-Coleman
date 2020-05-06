using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Reflection;

namespace CW22
{
    class Program
    {
        

        static void Main(string[] args)
        {
            
            

            Console.WriteLine("Press 1 for admin access. Press 2 for nurse access. Press 3 for doctor access. Press 4 for Reception access.");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Admin admin = new Admin("administrator", "admin", "admin");
                admin.adminLogIn();



            }

            else if (choice == "2") //Nurses
            {
                //Issues with login loop. Talk about in eval.
                //Create new dentist objects to be logged in..
                //Need to be added to list to be edited.
                Nurse Nurse1 = new Nurse("Jane Doe", "Taunton", 1, "jane", "jane");
                Nurse Nurse2 = new Nurse("Jane Two", "Taunton", 2, "janetwo", "janetwo");

                //Test Log In Works. Details would need to be looped through to prevent requiring every nurse to log in.
                Nurse1.NurseLogIn();

            }

            else if (choice == "3") //Dentist
            {
                //Issues with login loop. Talk about in eval.
                //Create new dentist objects to be logged in..

                dentist den1 = new dentist("Dennis Doe", "Taunton", 1, "dennis", "dennis");
                dentist den2 = new dentist("Dennis Two", "Taunton", 2, "dennistwo", "dennistwo");

                den1.DentistLogIn();





            }

            else if (choice == "4") //Receptionist
            {
                Reception recss = new Reception();
                recss.LogIn();



            }




        }
    }

}
