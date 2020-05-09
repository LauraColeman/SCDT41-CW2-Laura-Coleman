using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCDT41CW
{
    class Staff
    {

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


        //Dictionary for credential reset tickets
        private Dictionary<string, string> userTicks = new Dictionary<string, string>();


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




    }
}
