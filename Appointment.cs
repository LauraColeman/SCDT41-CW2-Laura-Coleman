using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCDT41CW
{
    class Appointment
    {
        private string name;
        private string practice;
        private string treatment;
        private string date;
        private string dent;
        private string notes;

        public string Name { get => name; set => name = value; }
        public string Practice { get => practice; set => practice = value; }
        public string Treatment { get => treatment; set => treatment = value; }
        public string Date { get => date; set => date = value; }
        public string Dent { get => dent; set => dent = value; }
        //Notes cant be accessed by receptionist
        public string Notes { get => notes; set => notes = value; }


        public Appointment(string pName, string pPractice, string treatment, string date, string den, string notes)
        {
            this.Name = pName;
            this.Practice = pPractice;
            this.treatment = treatment;
            this.date = date;
            this.Dent = den;
            this.notes = notes;
        }

        public Appointment()
        {
        }



        //Store appointments and reference and access with key

        private static List<Appointment> Books = new List<Appointment>();


        //Make dictionary accessible/call elsewhere.
        public static List<Appointment> Booking
        {
            get { return Books; }

        }

        //dummy data




        public void viewApps()
        {

            Books.Add(new Appointment("PATTWO", "Taunton", "Band 1", "20/07/2020, 12:00", "dONE", "Notes for Nurses/Dentists only"));


            for (int i = 0; i < Books.Count; i++)
            {

                Console.WriteLine(Books.ToString());
            }





        }


        public void Book()
        {
            Console.WriteLine("Enter the name of the patient");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the practice of the patient");
            string prac = Console.ReadLine();
            Console.WriteLine("Enter the treatment requested");
            string treat = Console.ReadLine();
            Console.WriteLine("Enter the date and time of the appointment in the format of DD/MM/YYYY, HOURS/SECOND");
            string day = Console.ReadLine();
            Console.WriteLine("Enter the dentist for the appointment");
            string dnt = Console.ReadLine();


            //Creates new appointment object and adds to dictionary.
            //Notes left null to restrict access to receptionist.
            Books.Add(new Appointment(name,prac,treat,day,dnt, notes = "Notes for Nurses/Dentists only"));




        }


        public void AddNotes()
        {
            //Adds test patient appointments to list.
            Books.Add(new Appointment("PATTWO", "Taunton", "Band 1", "20/07/2020, 12:00", "dONE", "Notes for Nurses/Dentists only"));

            Books.Add(new Appointment("PATTWO", "Taunton", "Band 2", "20/07/2020, 12:00", "dTWO", "Notes for Nurses/Dentists only"));

            Books.Add(new Appointment("PATTHREE", "Street", "Band 3", "20/07/2020, 12:00", "dONE", "Notes for Nurses/Dentists only"));

            Console.WriteLine("Enter the FULL NAME of the patient whos appointment you wish to add notes");
            Console.WriteLine();

            //Loop to print list to select from. 
            foreach (var p in Books)
            {

                Console.WriteLine("Appointment: {0},{1},{2},{3},{4}", p.Name, p.Practice, p.Treatment, p.Date, p.Dent, p.Notes);
            }

            Console.WriteLine();

            string patient = Console.ReadLine();

          

          

            //Checks if patient exists and return appointment

            if (name.Contains(patient))
            {

                Console.WriteLine("Enter additional notes");
                string newNote = Console.ReadLine();
                Console.WriteLine("Please enter your name");
                string sName = Console.ReadLine();

                //LINQ to add note to object and timestamp
                Booking.First(d => d.name == patient).notes = newNote + sName + DateTime.Now.ToString("hh:mm:ss");

            }

            else
            {
                Console.WriteLine("Appointment could not be found, please try again");
                AddNotes();
            }





        }



        public void CancelApp()
        {
            //Calls List
            List<Appointment> apps = Appointment.Booking;

            Console.WriteLine("Type the FULL NAME of the patient to CANCEL the appointment");
            string nameChoice = Console.ReadLine();
            //Checks if input is in dictionary

            foreach (var o in apps)
            {
                //if a match is found, object/patient will be removed from list.
                if (name == nameChoice)
                {
                    apps.Remove(o);
                    Console.WriteLine("Appointment for {0} Cancelled", nameChoice);

                }

                else
                {
                    Console.WriteLine("That name is not recognised, please try again.");
                    CancelApp();

                }

            }
        }



    }
}
