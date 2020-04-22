using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CW22
{
    class Nurse : Staff
    {


        //base to access constructor from Staff abstract class.
        public Nurse(string name, string practice, int room, string username, string password) : base(name, practice, room, username, password)

        {

        }





        //List to store nurses
        private static List<Nurse> nurseStaff = new List<Nurse>();



        //Make accessible from Program.
        public static List<Nurse> nurses
        {
            get { return nurseStaff; }

        }



    }


    }





