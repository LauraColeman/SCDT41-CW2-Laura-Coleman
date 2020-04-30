using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Reflection;

namespace CW22
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



            }


            Console.ReadKey();



        }


        public void dentistOption()
        {
            dentist test = new dentist();
            Console.WriteLine("Press 1 to ADD Dentist");
            Console.WriteLine("Press 2 to EDIT Dentist");
            Console.WriteLine("Press 3 to DELETE Dentist");
            string denChoice = Console.ReadLine();

            if (denChoice == "1")
            {
                AddDentist();

            }

            else if (denChoice == "2")
            {
                
                test.editDen();

            }

            else if (denChoice == "3")
            {
                test.deleteDen();
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
                AddNurse();

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





        public void AddNurse()
        {


            Console.WriteLine("Enter NAME of new User");
            string fullName = Console.ReadLine();
            Console.WriteLine("Enter PRACTICE of new User");
            string newPractice = Console.ReadLine();
            Console.WriteLine("Enter ROOM of new User");
            int newRoom = Convert.ToInt32(Console.ReadLine()); //cast to accept int
            Console.WriteLine("Enter USERNAME of new User");
            string newUsername = Console.ReadLine();
            Console.WriteLine("Enter PASSWORD NUMBER of new User");
            string newPassword = Console.ReadLine();

            //call nurse list and add inputted values
            List<Nurse> nurse = Nurse.nurse;
            Nurse newNurse = new Nurse(fullName, newPractice, newRoom, newUsername, newPassword);
            nurse.Add(newNurse);

        }

        public void AddDentist()
        {


            Console.WriteLine("Enter NAME of new User");
            string fullName = Console.ReadLine();
            Console.WriteLine("Enter PRACTICE of new User");
            string newPractice = Console.ReadLine();
            Console.WriteLine("Enter ROOM of new User");
            int newRoom = Convert.ToInt32(Console.ReadLine()); //cast to accept int
            Console.WriteLine("Enter USERNAME of new User");
            string newUsername = Console.ReadLine();
            Console.WriteLine("Enter PASSWORD NUMBER of new User");
            string newPassword = Console.ReadLine();

            //call nurse list and add inputted values
            List<dentist> dentists = dentist.den;
            dentist newDen = new dentist(fullName, newPractice, newRoom, newUsername, newPassword);
            dentists.Add(newDen);

        }

       
            }
    }














