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
            //List to store Nurses information.
            
           
        //List for dentists.
            List<dentist> denStaff = new List<dentist>();
            //List for patients.
            List<Patient> patients = new List<Patient>();



            Console.WriteLine("Press 1 for admin access. Press 2 for nurse access. Press 3 for doctor access. Press 4 for Reception access.");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Admin admin = new Admin("administrator", "admin", "admin");
                admin.adminLogIn();



            }

            else if (choice == "2") //Nurses
            {
                //calling list of nurses.
                List<Nurse> nurses = Nurse.nurses;
                Nurse nurse1 = new Nurse("NURSEONE", "Taunton", 1, "one", "one");
                nurses.Add(nurse1);
                Nurse nurse2 = new Nurse("NURSETWO", "Street", 1, "two", "two");
                nurses.Add(nurse2);

                nurse1.LogIn();


            }

            else if (choice == "3") //Doctor
            {



            }

            else if (choice == "4") //Receptionist
            {



            }


           

        }
    }

}






