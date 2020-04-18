using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2
{
    class practice
    {
        public string location;
        public string address;
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
            practiceInfo.Add(key,val); //adds input to dictionary.


        }

    }
}
