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
                //calling list of nurses.
                
                Nurse nurseLog = new Nurse();
                nurseLog.LogIn();



            }

            else if (choice == "3") //Dentist
            {
               
                dentist denLog = new dentist();
                denLog.LogIn();
                




            }

            else if (choice == "4") //Receptionist
            {
                Reception recss = new Reception();
                recss.LogIn();



            }




        }
    }

}
