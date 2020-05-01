using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace CW22
{
   class Patient
    {
        //address, legal name, gender or contact number. 

        private string name;
        private string address;
        private string practice;
        private string gender;
        private string phone;



        public string pName { get => name; set => name = value; }
        public string pAddr { get => address; set => address = value; }
        public string pPractice { get => practice; set => practice = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Phone { get => phone; set => phone = value; }


        //Override to print list of objects instead of class name into console.

        public override string ToString()
        {
            Reception recep = new Reception();
            List<Patient> patients = Patient.pats;
            return "Person: " + pName + "Address: " + pAddr + "Practice: " + pPractice + "Gender: " + Gender + "Phone: " + Phone;

        }


        public Patient(string name, string address, string practice, string gender, string phone)

        {
            this.name = pName;
            this.address = pAddr;
            this.practice = pPractice;
            this.gender = Gender;
            this.phone = Phone;
        }

        public Patient()
        {
        }


        //Allow list to be accessed from other classes
        private static List<Patient> patients = new List<Patient>();

       
        public static List<Patient> pats
        {
            get { return patients; }

        }


      

        }

    }

