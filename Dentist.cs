using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCDT41CW
{
    class Dentist : Staff
    {


        //base to access constructor from Staff abstract class.
        public Dentist(string name, string practice, int room, string username, string password) : base(name, practice, room, username, password)

        {
        }

        public Dentist()
        {
        }

        private static List<Dentist> denList = new List<Dentist>();
        public static List<Dentist> dentists
        {
            get { return denList; }

        }



        public void denLogIn()
        {

            //Login attempts counter
            int Attempts = 3;

            //Loop to limit login attempts into system.
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter username");
                string username = Console.ReadLine();
                Console.WriteLine("Enter password");
                string password = Console.ReadLine();


                //Takes 1 off the account number. Displays attempts remaining. Programme ends when 0 is reached.
                if (username != userName && password != userPassword)
                {
                    Attempts -= 1;
                    Console.WriteLine("Incorrect username or password. {0} Attempts Remaining.", Attempts);

                }
                else { break; }
            }

            //Display the result
            if (Attempts == 0)
                Console.WriteLine("Login failure. Restart the programme or contact an admin to reset your username and password.");
            else
                Console.WriteLine("Welcome {0}", staffName, staffPractice);
            DenFunctions();


            Console.ReadKey();

        }


        public void Add()
        {

            List<Dentist> denList = new List<Dentist>();



            foreach (var nur in denList)
            {
                Console.WriteLine("Nurse: {0},{1},{2},{3},{4}", nur.staffName, nur.staffPractice, nur.staffRoom, nur.userName, nur.userPassword);
            }

        }

        public void deleteDentist()
        {


            denList.Add(new Dentist("Test", "Test", 2, "Testdel", "Testdel"));


            //Retrieve and print list of Nurse names.
            foreach (var names in denList.Select(d => d.staffName))
            {
                Console.WriteLine(names);
            }

            Console.WriteLine("Choose a nurse to Delete.");
            string deleteN = Console.ReadLine();

            if (denList.Any(x => x.staffName == deleteN))
            {  //Single ensures staff with same name but different details remain.
                denList.Single(x => x.staffName == deleteN);
                Console.WriteLine("Staff successfully deleted from system.");
            }


            else
            {
                Console.WriteLine("That name is not recognised, please try again.");


            }

        }


        //FOR RECEPTIONIST
        //Method to edit nurse details and assign practice and room
        public void editDen()
        {

            //Testdata. Adds nurses to list
            denList.Add(new Dentist("Test", "Taunton", 3, "Test", "Test"));
           denList.Add(new Dentist("Two", "Street", 2, "Two", "Two"));

            Console.WriteLine("What details would you like to edit?");
            Console.WriteLine("Press 1 for NAME. \n Press 2 for PRACTICE.\n Press 3 for ROOM \n press 4 for USERNAME \n Press 5 for PASSWORD");

            //Displays details of nurses to edit.

            foreach (var nur in denList)
            {
                Console.WriteLine("Nurse: {0},{1},{2},{3},{4}", nur.staffName, nur.staffPractice, nur.staffRoom, nur.userName, nur.userPassword);
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
                        denList.First(d => d.staffName == choice).staffName = newName;
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

                        denList.First(d => d.staffName == choice2).staffPractice = newPrac;
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

                        denList.First(d => d.staffName == choice3).staffRoom = newRoom;
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

                       denList.First(d => d.staffName == choice4).userName = newUname;
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

                        denList.First(d => d.staffName == choice5).userPassword = newPass;
                        Console.WriteLine("Nurse {0} details updated", staffName);
                    }

                    break;
            }

        }


        public void AddDen()
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


            denList.Add(new Dentist(fullName, newPractice, newRoom, newUsername, newPassword));

            //Test that nurse is added
            foreach (var nur in denList)
            {
                Console.WriteLine("Nurse: {0},{1},{2},{3},{4}", nur.staffName, nur.staffPractice, nur.staffRoom, nur.userName, nur.userPassword);

            }


        }

        //Dictionary for credential reset tickets
        private Dictionary<string, string> userTicks = new Dictionary<string, string>();


      
        

        private void DenFunctions()
        {
            Appointment ap = new Appointment();

            Patient pat = new Patient();
            Console.WriteLine("Press 1 to VIEW PATIENTS. Press 2 to VIEW APPOINTMENTS. Press 3 to ADD NOTES to Appointment. Press 4 to REQUEST CHANGE CREDENTIALS");
            string select = Console.ReadLine();

            if (select == "1")
            {
                pat.ViewPatients();

            }


            else if (select == "2")
            {
                ap.viewApps();

            }

            else if (select == "3")
            {
                ap.AddNotes();
            }

            else if (select == "4")
            {
                RequestCredentials();
            }
            else
            {
                Console.WriteLine("Input not recognised, please try again.");
                DenFunctions();

            }
        }

        
    }
}
