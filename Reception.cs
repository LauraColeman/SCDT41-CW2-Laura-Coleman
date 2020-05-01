using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CW22
{
    class Reception : Patient
    {

        private string username;
        private string password;


        public string UserName { get => username; set => username = value; }
        public string passWord { get => password; set => password = value; }


        //Constructor for receptionists
        public Reception(string username, string password)

        {
            this.username = UserName;
            this.password = passWord;

        }

        public Reception()
        {
        }

        public void receptionistUsers()
        {



        }


        public override string ToString()
        {
            Reception recep = new Reception();
            List<Patient> patients = Patient.pats;
            return "Person: " + pName + "Address: " + pAddr + "Practice: " + pPractice + "Gender: " + Gender + "Phone: " + Phone;

        }

        //Method to Log In

        public void LogIn()
        {


            //Dictionary to store receptionists logins.
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("TauntonRec", "TauntonRec");
            dict.Add("StreetRec", "StreetRec");
            //Login attempts counter

            int Attempts = 0;

            //Loop to limit login attempts into system.
            foreach (KeyValuePair<string, string> receptionist in dict)
            {

                Console.WriteLine("Enter username");
                string username = Console.ReadLine();
                Console.WriteLine("Enter password");
                string password = Console.ReadLine();

                if (username != receptionist.Key && password != receptionist.Value)
                    Attempts++;
                else
                    break;
            }

            //Display the result
            if (Attempts >= 1)
                Console.WriteLine("Login failure {0} Attempts Remaining", Attempts);
            else
                Console.WriteLine("Welcome {0}", username);
            RecOptions();

            Console.ReadKey();

        }




        //Configures list of patients to be viewed/manipulated

        public List<Patient> ViewPatients()
        {

            List<Patient> patients = Patient.pats;


            Patient pONE = new Patient("PATONE", "2 Road, Taunton, TA5", "Taunton", "Female", "111");
            patients.Add(pONE);
            Patient pTWO = new Patient("PATTWO", "4 Road, Taunton, TA10", "Taunton", "Female", "222");
            patients.Add(pTWO);
            Patient pTHREE = new Patient("PATTHREE", "6 Road, Street, BA16", "Street", "Female", "333");
            patients.Add(pTHREE);

            //Loop to print list. 
            //ToString override called to prevent class being printed instead of objects in list.

            for (int i = 0; i < pats.Count; i++)
            {

                Console.WriteLine(pats.ToString());
            }


            return patients;
        }


        //Receptionist functions

        private void RecOptions()
        {

            Console.WriteLine("Press 1 to VIEW PATIENTS. Press 2 to EDIT PATIENTS. Press 3 to BOOK APPOINTMENT. Press 4 to CANCEL APPOINTMENT.Press 5 to VIEW APPOINTMENTS. Press 6 to REQUEST USERNAME OR PASSWORD CHANGE");
            int x = int.Parse(Console.ReadLine());
            switch (x)
            {

                case 1: //VIEW Patients
                    Console.WriteLine("VIEW ALL PATIENTS");


                    ViewPatients();



                    break;



                case 2://EDIT Patients

                    EditPatients();


                    break;



                case 3://BOOK Appointment

                    Appointment app = new Appointment();
                    app.Book();


                    break;



                case 4://CANCEL Appointment


                    Appointment appCan = new Appointment();

                    appCan.CancelApp();

                    break;

                case 5: //VIEW APPS

                    Appointment appView = new Appointment();
                    appView.viewApps();



                    break;

                case 6:

                    RequestCredentials();

                    break;
            }




        }

     private  Dictionary<string, string> userTicks = new Dictionary<string, string>();

        



        //Make accessible from Program.
        public Dictionary<string, string> userTickets
        {
            get { return userTicks; }

        }


        public void RequestCredentials()
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Do you want to change you username, password or both?");
            string option = Console.ReadLine();
            userTicks.Add(name, option);
            Console.WriteLine("Thank you. Request sent to admin.");


        }

       




        private void EditPatients()
        {
            

            Console.WriteLine("Press 1 to ADD PATIENTS. Press 2 to EDIT PATIENTS. Press 3 to DELETE PATIENTS.");
            string input = Console.ReadLine();

            if (input == "1")
            {
                AddPatient();

            }


            else if (input == "2")
            {
                
                AmendOptions();

            }


            else if (input == "3")
            {
                DeletePatient();

            }

        }


        private void AddPatient()
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
            Patient newPat = new Patient(fullName, newAddress, newPractice, newGender, newPhone);
            patients.Add(newPat);
            ViewPatients();



        }


        private void DeletePatient()
        {
            List<Patient> patients = Patient.pats;
            Console.WriteLine("Choose a Patient to Delete.");

            //Retrieve and print list of patients names.
            foreach (var names in patients.Select(d => d.pName))
            {
                Console.WriteLine(pName);
            }

            string choice = Console.ReadLine();

            //checks if input is in list.
            if (pName.Contains(choice))
            {
                foreach (var o in patients)
                {
                    //if a match is found, object/patient will be removed from list.
                    if (pName == choice)
                    {
                        patients.Remove(o);
                        Console.WriteLine("Patient successfully removed");


                    }
                    else
                    {
                        Console.WriteLine("That patient is not recognised. Please try again.");
                        DeletePatient();
                    }

                }

            }


        }

        //Edit Patient Details

      


        public void AmendOptions()
        {


            Console.WriteLine("What details would you like to edit?");
            Console.WriteLine("Press 1 for NAME. \n Press 2 for ADDRESS.\n Press 3 for PRACTICE \n press 4 for GENDER \n Press 5 for PHONE NUMBER");
            Console.ReadLine();

            //Retrieve and print list of patients details.
            foreach (var names in pats)
            {
                Console.WriteLine(names);
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

