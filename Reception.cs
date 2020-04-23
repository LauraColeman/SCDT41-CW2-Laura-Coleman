using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

      

        //Configures list of patientsto be viewed/manipulated
        

        public List<Patient> method()
        {

            List<Patient> patients = Patient.pats;

            
            Patient pONE = new Patient("PATONE", "2 Road, Taunton, TA5", "Taunton", "Female", "111");
            patients.Add(pONE);
            Patient pTWO = new Patient("PATTWO", "4 Road, Taunton, TA10", "Taunton", "Female", "222");
            patients.Add(pTWO);
            Patient pTHREE = new Patient("PATTHREE", "6 Road, Taunton, TA2", "Taunton", "Female", "333");
            patients.Add(pTHREE);


            foreach (object o in patients)
            {
                Console.WriteLine(o);
            }

            return patients;

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
            foreach(KeyValuePair<string, string> receptionist in dict)
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
            if (Attempts > 2)
                Console.WriteLine("Login failure");
            else
                Console.WriteLine("Welcome {0}", username);
                RecOptions();

            Console.ReadKey();

        }

      
        
    

        public void RecOptions()
        {

            Console.WriteLine("Press 1 to VIEW PATIENTS.\n Press 2 to EDIT PATIENTS.\n Press 3 to BOOK APPOINTMENT. \n Press 4 to CANCEL APPOINTMENT.");
            int x = int.Parse(Console.ReadLine());
            switch (x)
            {
                
                case 1: //VIEW Patients
                    Console.WriteLine("VIEW ALL PATIENTS");


                    method();

                        
                    
                        break;



                case 2://EDIT Patients


                    break;



                case 3://BOOK Appointment

                    
                    break;



                case 4://CANCEL Appointment


                    break;




            }




        }
    }
}