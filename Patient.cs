using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCDT41CW
{
    class Patient
    {

        private string name;
        private string address;
        private string practice;
        private string gender;
        private string phone;


        //Make private values accessible
        public string pName { get => name; set => name = value; }
        public string pAddr { get => address; set => address = value; }
        public string pPractice { get => practice; set => practice = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Phone { get => phone; set => phone = value; }


       

        //Constructor
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

        //override to print objects of list, not just class/namespace name.
        public override string ToString()
        {

            //Prints
            return "Name: " + name + "Address: " + address + "Practice: " + practice + "Gender: " + gender + "Phone: " + phone;

        }


        //Allow list to be accessed from other classes
        private static List<Patient> patients = new List<Patient>();

        
        public static List<Patient> pats
        {
            get { return patients; }

        }


        public void ViewPatients()
        {

            
            //Test - Add patients to list
            pats.Add(new Patient("PATONE", "2 Road, Taunton, TA5", "Taunton", "Female", "111"));

            pats.Add(new Patient("PATTWO", "4 Road, Taunton, TA10", "Taunton", "Female", "222"));

            pats.Add(new Patient("PATTHREE", "6 Road, Street, BA16", "Street", "Female", "333"));


            //Loop to print list. 

            foreach (var p in pats)
            {

                Console.WriteLine(p.ToString());
            }


        }


        public void DeletePatient()
        {
            List<Patient> patients = Patient.pats;
            Console.WriteLine("Choose a Patient to Delete.");

            //Retrieve and print list of patients names.
            foreach (var names in patients.Select(d => d.pName))
            {
                Console.WriteLine(names);
            }

            string choice = Console.ReadLine();

            //checks if input is in list.
            if (patients.Any(x => x.pName == choice))
            {  //Removes if match is found
                patients.Single(x => x.pName == choice);
                Console.WriteLine("Staff successfully deleted from system.");
            }


            else
            {
                Console.WriteLine("That name is not recognised, please try again.");
                DeletePatient();

            }

        }


        public void AddPatient()
        {
            //Calls list to add new user.
            List<Patient> patients = Patient.pats;


            Console.WriteLine("Enter NAME of new patient");
            string fullName = Console.ReadLine();
            Console.WriteLine("Enter ADDRESS of new patient");
            string newAddress = Console.ReadLine();
            Console.WriteLine("Enter PRACTICE of new patient");
            string newPractice = Console.ReadLine();
            Console.WriteLine("Enter GENDER of new patient");
            string newGender = Console.ReadLine();
            Console.WriteLine("Enter PHONE NUMBER of new patient");
            string newPhone = Console.ReadLine();

            //Creates object from input
            patients.Add(new Patient(fullName, newAddress, newPractice, newGender, newPhone));
            Console.WriteLine("Patient successfully added to system");
            //Checks patient is added to list
            foreach (var pa in patients)
            {
                Console.WriteLine(pName, pAddr, pPractice, Gender, Phone);
            }

        }

        public void AmendOptions()
        {


            Console.WriteLine("What details would you like to edit?");
            Console.WriteLine("Press 1 for NAME. \n Press 2 for ADDRESS.\n Press 3 for PRACTICE \n press 4 for GENDER \n Press 5 for PHONE NUMBER");
            Console.ReadLine();

            foreach (var p in patients)
            {

                Console.WriteLine(p.ToString());
            }

            int x = int.Parse(Console.ReadLine());
            switch (x)
            {

                case 1: //Name


                    Console.WriteLine("Enter the FULL NAME of the patient to edit their name.");

                    string choice = Console.ReadLine();

                    //Sets new value for property of object in list.

                    if (pName.Contains(choice))
                    {

                        Console.WriteLine("Enter new name");
                        string newPname = Console.ReadLine();

                        pats.First(d => d.pName == choice).pName = newPname;
                        Console.WriteLine("Details chnaged sucessfully");

                    }



                    break;


                case 2://Address


                    Console.WriteLine("Enter the FULL NAME of the patient to edit their address.");
                    string choice2 = Console.ReadLine();

                    //Sets new value for property of object in list.

                    if (pName.Contains(choice2))
                    {

                        Console.WriteLine("Enter new address");
                        string newAddr = Console.ReadLine();

                        pats.First(d => d.pName == choice2).pAddr = newAddr;

                    }


                    break;


                case 3://Practice


                    Console.WriteLine("Enter the FULL NAME of the patient to edit their Practice.");
                    string choice3 = Console.ReadLine();

                    if (pName.Contains(choice3))
                    {

                        Console.WriteLine("Assign a new Practice");
                        string newPract = Console.ReadLine();

                        pats.First(d => d.pName == choice3).pPractice = newPract;

                    }

                    break;


                case 4://Gender

                    Console.WriteLine("Enter the FULL NAME of the patient to edit their Gender.");
                    string choice4 = Console.ReadLine();

                    if (pName.Contains(choice4))
                    {

                        Console.WriteLine("Enter new gender");
                        string newGen = Console.ReadLine();

                        pats.First(d => d.pName == choice4).Gender = newGen;

                    }

                    break;

                case 5://Phone


                    Console.WriteLine("Enter the FULL NAME of the patient to edit their Phone Number.");
                    string choice5 = Console.ReadLine();

                    if (pName.Contains(choice5))
                    {

                        Console.WriteLine("Enter the new Phone Number of the patient");
                        string newPhone = Console.ReadLine();

                        pats.First(d => d.pName == choice5).Phone = newPhone;

                    }

                    //For the purpose of testing patients have been edited
                    //ViewPatients();

                    break;


            }

        }





    }
}
