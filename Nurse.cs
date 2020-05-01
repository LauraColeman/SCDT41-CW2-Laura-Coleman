using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Reflection;

namespace CW22
{
    class Nurse : Staff
    {


        //base to access constructor from Staff abstract class.
        public Nurse(string name, string practice, int room, string username, string password) : base(name, practice, room, username, password)

        {
         }

        public Nurse()
        {
        }

        //List to store nurses
        private static List<Nurse> nurseStaff = new List<Nurse>();

       

        //Make accessible from Program.
        public static List<Nurse> nurse
        {
            get { return nurseStaff; }

        }




        //FOR RECEPTIONIST
        //Method to edit nurse details and assign practice and room
        public void editNurse()
        {
            List<Nurse> nurseEd = Nurse.nurse;

            Console.WriteLine("What details would you like to edit?");
            Console.WriteLine("Press 1 for NAME. \n Press 2 for PRACTICE.\n Press 3 for ROOM \n press 4 for USERNAME \n Press 5 for PASSWORD");

            //Displays details of nurses to edit.

            foreach (var names in nurseEd)
            {
                Console.WriteLine(names);
            }

            int x = int.Parse(Console.ReadLine());
            switch (x)
            {

                case 1: //Name

                    Console.WriteLine("Enter Nurses' FULL NAME to Edit Name.");
                    string choice = Console.ReadLine();


                    //Sets new value for property of object in list.

                    if (staffName.Contains(choice))
                    {

                        Console.WriteLine("Enter a new Name");
                        string newName = Console.ReadLine();

                         //LINQ to replace
                        nurseEd.First(d => d.staffName == choice).staffName = newName;
                        Console.WriteLine("Nurse {0} details updated", staffName);
                    }

                    break;

                case 2: //Name

                    Console.WriteLine("Enter Nurses' FULL NAME to Edit Practice.");
                    string choice2 = Console.ReadLine();

                    //Sets new value for property of object in list.

                    if (staffName.Contains(choice2))
                    {

                        Console.WriteLine("Enter Nurses' FULL NAME to assign a new Practice");
                        string newPrac = Console.ReadLine();

                        nurseEd.First(d => d.staffName == choice2).staffPractice = newPrac;
                        Console.WriteLine("Nurse {0} details updated", staffName);
                    }

                    break;
                case 3: //Name

                    Console.WriteLine("Enter Nurses' FULL NAME to Edit Room Assignment.");
                    string choice3 = Console.ReadLine();

                    //Sets new value for property of object in list.

                    if (staffName.Contains(choice3))
                    {

                        Console.WriteLine("Assign a new Room");
                        int newRoom = Convert.ToInt32(Console.ReadLine());

                        nurseEd.First(d => d.staffName == choice3).staffRoom = newRoom;
                        Console.WriteLine("Nurse {0} details updated", staffName);
                    }

                    break;

                case 4: //Name

                    Console.WriteLine("Enter Nurses' FULL NAME to Edit Username.");
                    string choice4 = Console.ReadLine();

                    //Sets new value for property of object in list.

                    if (staffName.Contains(choice4))
                    {

                        Console.WriteLine("Assign a new Username");
                        string newUname = Console.ReadLine();

                        nurseEd.First(d => d.staffName == choice4).userName = newUname;
                        Console.WriteLine("Nurse {0} details updated", staffName);
                    }

                    break;
                case 5: //Name

                    Console.WriteLine("Enter Nurses' FULL NAME to Edit their Password.");
                    string choice5 = Console.ReadLine();

                    //Sets new value for property of object in list.

                    if (staffName.Contains(choice5))
                    {

                        Console.WriteLine("Assign a new Password");
                        string newPass = Console.ReadLine();

                        nurseEd.First(d => d.staffName == choice5).userPassword = newPass;
                        Console.WriteLine("Nurse {0} details updated", staffName);
                    }

                    break;
            }

        }

        public void deleteNur()
        {
            List<Nurse> nurseDel = Nurse.nurse;
            
            nurseDel.Add(new Nurse() { staffName = "Tester", staffPractice = "Taunton", staffRoom = 1, userName = "test", userPassword = "test" });


            //Retrieve and print list of Nurse names.
            foreach (var names in nurseDel.Select(d => d.staffName))
            {
                Console.WriteLine(names);
            }
            
            Console.WriteLine("Choose a nurse to Delete.");
            string deleteN = Console.ReadLine();

            
                //if a match is found, object/patient will be removed from list.Overcomes casting error.
                if (staffName == deleteN)
                {
                nurseDel.RemoveAll(x => x.staffName == deleteN);
                Console.WriteLine("Staff successfully deleted from system.");
                
            }

                else
                {
                    Console.WriteLine("That name is not recognised, please try again.");
                   

                }

            }

        public void LogIn()
        {
            //calls lists with login info
            List<Nurse> nurseO = Nurse.nurse;
            List<dentist> dentistsO = dentist.den;

            //Test staff members
            nurseO.Add(new Nurse() { staffName = "Tester", staffPractice = "Taunton", staffRoom = 1, userName = "test", userPassword = "test" });
            nurseO.Add(new Nurse() { staffName = "Nurse2", staffPractice = "Street", staffRoom = 3, userName = "nursetwo", userPassword = "nursetwo" });


            //Login attempts counter
            int Attempts = 3;
            

            //Using reflection to get username and password values from objects.
            Type typeOfMyObject = nurseO.GetType();
            PropertyInfo[] properties = typeOfMyObject.GetProperties();
            //Loop to limit login attempts into system.
            foreach (PropertyInfo staff in properties)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Enter username");
                    string user = Console.ReadLine();
                    Console.WriteLine("Enter password");
                    string pass = Console.ReadLine();

                    object value = staff.GetValue(userName);
                    object val = staff.GetValue(userPassword);

                    if (user != Convert.ToString(value) || pass != Convert.ToString(val))
                        Attempts-=1;
                    {
                        Console.WriteLine("Incorrect details. {0} Attempts remaining", Attempts);

                    }
                   
                }

                //Display the result
                if (Attempts > 2)
                    Console.WriteLine("Login failure. Please close the programme and try again or contact an admin.");
                else
                    break;
                    Console.WriteLine("Login successful. Welcome {0}", userName);

                Nurse tests = new Nurse();
                NurseFunctions();
                
            }
            
        }

        private void NurseFunctions()
        {
            Appointment choice = new Appointment();
            Reception func = new Reception();
            Console.WriteLine("Press 1 to VIEW PATIENTS. Press 2 to VIEW APPOINTMENTS. Press 3 to ADD NOTES to Appointment");
            string select = Console.ReadLine();

            if (select == "1")
            {
                func.ViewPatients();

            }

            
            else if (select == "2")
            {
                choice.viewApps();

            }

            else if (select == "3")
            {
                choice.AddNotes();
            }


            else
            {
                Console.WriteLine("Input not recognised, please try again.");
                NurseFunctions();

            }
        }







    }





}

       
    





