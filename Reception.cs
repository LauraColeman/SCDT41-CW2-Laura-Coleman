using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCDT41CW
{
    class Reception
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



        //Receptionist functions

        private void RecOptions()
        {
            Patient pat = new Patient();
            Console.WriteLine("Press 1 to VIEW PATIENTS. Press 2 to EDIT PATIENTS. Press 3 to BOOK APPOINTMENT. Press 4 to CANCEL APPOINTMENT.Press 5 to VIEW APPOINTMENTS. Press 6 to REQUEST USERNAME OR PASSWORD CHANGE");
            int x = int.Parse(Console.ReadLine());
            switch (x)
            {

                case 1: //VIEW Patients
                    Console.WriteLine("VIEW ALL PATIENTS");
                   

                    pat.ViewPatients();



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



        private void EditPatients()
        {
            Patient pa = new Patient();

            Console.WriteLine("Press 1 to ADD PATIENTS. Press 2 to EDIT PATIENTS. Press 3 to DELETE PATIENTS.");
            string input = Console.ReadLine();

            if (input == "1")
            {
                pa.AddPatient();

            }


            else if (input == "2")
            {

                pa.AmendOptions();

            }


            else if (input == "3")
            {
                pa.DeletePatient();

            }

        }








        public void RequestCredentials()
        {
            Nurse nurs = new Nurse();
            
            //calls dictionary from staff class
            Dictionary<string, string> userTic = nurs.userTickets;

            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Do you want to change you username, password or both?");
            string option = Console.ReadLine();
            userTic.Add(name, option);
            Console.WriteLine("Thank you. Request sent to admin.");


        }








    }
}
