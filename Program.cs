using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CW22
{
    class Program
    {




        static void Main(string[] args)
        {

            List<Nurse> nurseStaff = new List<Nurse>();


        Console.WriteLine("Press 1 for admin access. Press 2 for nurse access. Press 3 for doctor access. Press 4 for Reception access.");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Admin admin = new Admin("administrator", "admin", "admin");
                admin.adminLogIn();



            }

            else if (choice == "2") //Nurses
            {
               
                Nurse Nurse1 = new Nurse("Jane Doe", "Taunton", 1, "jane", "jane");
                nurseStaff.Add(Nurse1);

                Nurse1.LogIn();
               


            }

            else if(choice == "3") //Doctor
            {
                


            }

            else if (choice == "4") //Receptionist
            {



            }

        }
    }

}






