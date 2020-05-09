using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Reflection;

namespace SCDT41CW
{
    class Admin
    {
        private string aName;
        private string aUsername;
        private string aPassword;

        //Constructor to create admin object.


        public Admin(string name, string username, string password)
        {
            this.aName = name;
            this.aUsername = username;
            this.aPassword = password;

        }

        public Admin()
        {
        }


        //Log In Function

        public void adminLogIn() //Restricts access to an admin and presents functions in a method.
        {


            //Login attempts counter
            int Attempts = 0;

            //Loop to limit login attempts into system.
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter username");
                string username = Console.ReadLine();
                Console.WriteLine("Enter password");
                string password = Console.ReadLine();

                if (username != aUsername && password != aPassword)
                    Attempts++;
                else
                    break;
            }

            //Display the result
            if (Attempts > 2)
                Console.WriteLine("Login failure. {0} Attempts Remaining", Attempts);
            else
                Console.WriteLine("Welcome {0}", aName);

            //Leads to menu of admin functions.
            Console.WriteLine("Press 1 to ADD PRACTICE. Press 2 to DELETE PRACTICE. Press 3 to EDIT NURSES. Press 4 to EDIT DENTISTS. Press 5 to VIEW CREDENTIAL CHANGE REQUESTS");
            AdminOptions();
        }


        //Switch case to allow access to different methods depending on admins choice from the menu.
        public void AdminOptions()
        {
            int x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1: //ADD Practices
                    practice practices = new practice();

                    practices.addPractice();

                    break;

                case 2://DELETE Practices

                    practice Dpractice = new practice();

                    Dpractice.deletePractice();

                    break;


                case 3://EDIT Nurses

                    nurseOption();

                    break;


                case 4://EDIT Dentists

                    dentistOption();


                    break;

                case 5://View tickets requesting change in credentials


                    ViewCredentials();

                    break;

            }


            Console.ReadKey();



        }



        public void dentistOption()
        {
            Dentist test = new Dentist();
            Console.WriteLine("Press 1 to ADD Dentist");
            Console.WriteLine("Press 2 to EDIT Dentist");
            Console.WriteLine("Press 3 to DELETE Dentist");
            string denChoice = Console.ReadLine();

            if (denChoice == "1")
            {
                test.AddDen();

            }

            else if (denChoice == "2")
            {

                test.editDen();

            }

            else if (denChoice == "3")
            {
                test.deleteDentist();
            }

            else
            {
                Console.WriteLine("Input not recognised. Please try Again");
                dentistOption();

            }

        }

        public void nurseOption()
        {
            Nurse test = new Nurse();

            Console.WriteLine("Press 1 to ADD nurse");
            Console.WriteLine("Press 2 to EDIT nurse");
            Console.WriteLine("Press 3 to DELETE nurse");
            string nurChoice = Console.ReadLine();

            if (nurChoice == "1")
            {
                test.AddNurse();

            }

            else if (nurChoice == "2")
            {

                test.editNurse();


            }

            else if (nurChoice == "3")
            {


                test.deleteNur();
            }

            else
            {
                Console.WriteLine("Input not recognised. Please try Again");
                nurseOption();

            }
        }






        //Allows admin to view and delete tickets.
        private void ViewCredentials()
        {
            //Calls dictionary from Reception Class
            Nurse nur = new Nurse();
            Dictionary<string, string> userTic = nur.userTickets;

            foreach (var pair in userTic)
            {
                Console.WriteLine("{0}, {1}.", pair.Key, pair.Value);

            }

            Console.WriteLine("Delete Tickets? y or n");
            string opt = Console.ReadLine();

            if (opt == "y")
            {
                Console.WriteLine("Enter practice LOCATION to DELETE.");
                string tChoice = Console.ReadLine();

                if (userTic.ContainsKey(tChoice))
                {
                    userTic.Remove(tChoice);

                }

                else
                {
                    Console.WriteLine("Ticket not recognised. Please try again.");
                    ViewCredentials();
                }

            }
            else if (opt == "n")
            {
                Console.WriteLine("Thank You. Goodbye.");

            }

        }




    }
}















