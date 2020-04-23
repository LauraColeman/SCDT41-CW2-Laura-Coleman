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

                List<Nurse> nurses = Nurse.nurse;
                Nurse nurse1 = new Nurse("NURSEONE", "Taunton", 1, "one", "one");
                nurses.Add(nurse1);
                Nurse nurse2 = new Nurse("NURSETWO", "Street", 1, "two", "two");
                nurses.Add(nurse2);
                nurses.ForEach(item => item.LogIn());



            }

            else if (choice == "3") //Doctor
            {
                List<dentist> dens = dentist.den;
                dentist den1 = new dentist("DENONE", "Taunton", 1, "dOne", "dOne");
                dens.Add(den1);
                dentist den2 = new dentist("DENONE", "Taunton", 1, "dTwo", "dTwo");
                dens.Add(den1);
                dens.ForEach(item => item.LogIn());


            }

            else if (choice == "4") //Receptionist
            {
                Reception recss = new Reception();
                recss.LogIn();



            }




        }
    }

}
