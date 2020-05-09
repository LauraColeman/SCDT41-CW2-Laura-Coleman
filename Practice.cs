using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Reflection;


namespace SCDT41CW
{
    class practice
    {

        public string key;
        public string val;

        //Dictionary to store location and address.

        Dictionary<string, string> practiceInfo = new Dictionary<string, string>()
        {
            {"Taunton","4 High Street, TA2 0ND"},
            {"Street","2 High Street, BA16 0QN"}
        };


        //Method to allow user input to add practice.

        public void addPractice()
        {
            Console.WriteLine("Enter the LOCATION of the new practice");
            key = Console.ReadLine();
            Console.WriteLine("Enter ADDRESS of the new practice");
            val = Console.ReadLine();
            practiceInfo.Add(key, val); //adds input to dictionary.


            //Testing purpose to see practice has been added
            //viewPractice();
        }


        //Method to view all practices

        public void viewPractice()
        {
            Console.WriteLine("Currently registered practices");
            foreach (var pair in practiceInfo)
            {

                Console.WriteLine("{0}, {1}.", pair.Key, pair.Value);
            }
        }


        public void deletePractice()
        {
            Console.WriteLine("Enter practice LOCATION to DELETE.");

            //Retrieve and print list of patients names.
            foreach (var pair in practiceInfo)
            {

                Console.WriteLine("{0}, {1}.", pair.Key, pair.Value);
            }

            string pChoice = Console.ReadLine();

            //checks if input is in list.
            if (practiceInfo.ContainsKey(pChoice))
            {

                //if a match is found, practice will be removed from dictionary.

                practiceInfo.Remove(pChoice);
                Console.WriteLine("Practice Deleted");
            }

            else
            {

                Console.WriteLine("That practice does not exist, please try again.");
                deletePractice();
            }

        }
    }
}
