using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2
{
    class Nurse : Staff 
    {
        //base to access constructor from Staff abstract class.
        public Nurse(string name, string practice, int room, string username, string password) :base(name, practice, room, username, password)

        {
            
        }

        //constructor from abstract class

        Nurse Nurse1 = new Nurse ("Jane Doe", "Taunton", 1, "jane","jane"); 
        Nurse Nurse2 = new Nurse("Jane Doe", "Taunton", 2, "jane", "jane");
        Nurse Nurse3 = new Nurse("Jane Doe", "Taunton", 3, "jane", "jane");
        Nurse Nurse4 = new Nurse("Jane Doe", "Street", 1, "jane", "jane");
        Nurse Nurse5 = new Nurse("Jane Doe", "Street", 2, "jane", "jane");
        Nurse Nurse6 = new Nurse("Jane Doe", "Street", 3, "jane", "jane");
        Nurse Nurse7 = new Nurse("Jane Doe", "Wells", 1, "jane", "jane");
        Nurse Nurse8 = new Nurse("Jane Doe", "Wells", 2, "jane", "jane");
        Nurse Nurse9 = new Nurse("Jane Doe", "Wells", 3, "jane", "jane");


    }
}
