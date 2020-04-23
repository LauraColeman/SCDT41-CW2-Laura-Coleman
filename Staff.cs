﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        //Shared method between Nurses and Dentists. Admin and receptionists have other functions contained in method/s.
        public void LogIn()
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

                if (username != userName && password != userPassword)
                    Attempts++;
                else
                    break;
            }

            //Display the result
            if (Attempts > 2)
                Console.WriteLine("Login failure");
            else
                Console.WriteLine("Welcome {0}, {1} Practice", staffName,practice);
            
        }

        //Method to view all patients.  
        //Access list of patients and print contents.

        public void ViewPatients()
        {
            List<Patient> patients = Patient.pats;

            foreach (object o in patients)
            {
                Console.WriteLine(o);
            }

            
        }

        //View Appointments
        //Add Notes to Appointments



    }
}