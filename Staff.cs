using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace CW22
{
    abstract class Staff
    {

        //Shared values between nurses and dentists. 
        //Can be accessed from nurse and dentist classes.

        private string name;
        private string practice;
        private int room;
        private string username;
        private string password;


        public string staffName
        {
            get { return name; }
            set { name = value; }
        }

        public string staffPractice
        {
            get { return practice; }
            set { practice = value; }
        }

        public int staffRoom
        {
            get { return room; }
            set { room = value; }
        }

        public string userName
        {
            get { return username; }
            set { username = value; }
        }

        public string userPassword
        {
            get { return password; }
            set { password = value; }
        }

        //Constructor for nurses and dentists

        public Staff(string name, string practice, int room, string username, string password)
        {
            this.name = name;
            this.practice = practice;
            this.room = room;
            this.username = username;
            this.password = password;



        }

        public Staff()
        {

        }

        //override to print objects of list, not just class/namespace name.
        public override string ToString()
        {
            //calls lists
            List<Nurse> nurseO = Nurse.nurse;
            List<dentist> dentistsO = dentist.den;

            //Prints
            return "Name: " + staffName + "Practice: " + practice + "Room: " + room + "Username: " + username + "Password: " + password;

        }

        //Shared method between Nurses and Dentists. Admin and receptionists have other functions contained in method/s.
        public void LogIn()
        {
            //calls lists with login info
            List<Nurse> nurseO = Nurse.nurse;
            List<dentist> dentistsO = dentist.den;

            //Test staff members
            Nurse nurse1 = new Nurse("Tester", "Taunton", 1, "Test", "Test");
            nurseO.Add(nurse1);
            Nurse nurse2 = new Nurse("Nurse2", "Street", 3, "two", "two");
            nurseO.Add(nurse2);


            //Login attempts counter
            int Attempts = 0;

            //Loop to limit login attempts into system.
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter username");
                string username = Console.ReadLine();
                Console.WriteLine("Enter password");
                string password = Console.ReadLine();

                if (username != userName && password != userPassword && Attempts > 0)
                {
                    Attempts +=1;

                    Console.WriteLine("Login failure {0} Attempts Remaining", Attempts);
                }
                else
                    break;

                Console.WriteLine("Welcome {0}", username);

            }

            //Display the result


        }

        //Method to view all patients.  
        //Access list of patients and print contents.

        public void ViewPatients()
        {
            List<Patient> patients = Patient.pats;

            Type type = typeof(Patient);

            // Loop over properties.
            foreach (PropertyInfo propertyInfo in type.GetProperties())
            {
                Console.WriteLine(propertyInfo);



            }





        }


        


    }
    }
