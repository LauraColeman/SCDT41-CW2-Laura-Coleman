﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CW22
{
    class dentist : Staff
    {
        //base to access constructor from Staff abstract class.
        public dentist(string name, string practice, int room, string username, string password) : base(name, practice, room, username, password)

        {

        }

        public dentist()
        {
        }

        private static List<dentist> denStaff = new List<dentist>();




        //Make accessible from Program.
        public static List<dentist> den
        {
            get { return denStaff; }

        }

        //Edit dentists
        //Method to edit nurse details and assign practice and room
        public void editDen()
        {
            List<dentist> denEd = dentist.den;

            Console.WriteLine("What details would you like to edit?");
            Console.WriteLine("Press 1 for NAME. \n Press 2 for PRACTICE.\n Press 3 for ROOM \n press 4 for USERNAME \n Press 5 for PASSWORD");

            //Displays details of nurses to edit.

            foreach (var names in denEd)
            {
                Console.WriteLine(names);
            }

            int x = int.Parse(Console.ReadLine());
            switch (x)
            {

                case 1: //Name

                    Console.WriteLine("Choose a Dentists' Name to Edit.");
                    string choice = Console.ReadLine();


                    //Sets new value for property of object in list.

                    if (staffName.Contains(choice))
                    {

                        Console.WriteLine("Enter a new Name");
                        string newName = Console.ReadLine();

                        denEd.First(d => d.staffName == choice).staffName = newName;

                    }

                    break;

                case 2: //Name

                    Console.WriteLine("Choose a Dentists' Name to Edit Practice.");
                    string choice2 = Console.ReadLine();

                    //Sets new value for property of object in list.

                    if (staffName.Contains(choice2))
                    {

                        Console.WriteLine("Assign a new Practice");
                        string newPrac = Console.ReadLine();

                        denEd.First(d => d.staffName == choice2).staffPractice = newPrac;

                    }

                    break;
                case 3: //Name

                    Console.WriteLine("Choose a Dentists' Name to Edit Room Assignment.");
                    string choice3 = Console.ReadLine();

                    //Sets new value for property of object in list.

                    if (staffName.Contains(choice3))
                    {

                        Console.WriteLine("Assign a new Room");
                        int newRoom = Convert.ToInt32(Console.ReadLine());

                        denEd.First(d => d.staffName == choice3).staffRoom = newRoom;

                    }

                    break;

                case 4: //Name

                    Console.WriteLine("Choose a Dentists' Name to Edit Username.");
                    string choice4 = Console.ReadLine();

                    //Sets new value for property of object in list.

                    if (staffName.Contains(choice4))
                    {

                        Console.WriteLine("Assign a new Username");
                        string newUname = Console.ReadLine();

                        denEd.First(d => d.staffName == choice4).userName = newUname;

                    }

                    break;
                case 5: //Name

                    Console.WriteLine("Choose a dentists' Name to Edit their Password.");
                    string choice5 = Console.ReadLine();

                    //Sets new value for property of object in list.

                    if (staffName.Contains(choice5))
                    {

                        Console.WriteLine("Assign a new Password");
                        string newPass = Console.ReadLine();

                        denEd.First(d => d.staffName == choice5).userPassword = newPass;

                    }

                    break;
            }

        }

        public void deleteDen()
        {
            List<dentist> dentists = dentist.den;

            //Retrieve and print list of patients names.
            foreach (var names in dentists.Select(d => d.staffName))
            {
                Console.WriteLine(names);
            }



            Console.WriteLine("Choose a dentist to Delete.");
            string delete = Console.ReadLine();

            foreach (var o in dentists)
            {
                //if a match is found, object/patient will be removed from list.
                if (staffName == delete)
                {
                    dentists.Remove(o);


                }

                else
                {
                    Console.WriteLine("That name is not recognised, please try again.");
                    deleteDen();

                }

            }
        }
    }
}