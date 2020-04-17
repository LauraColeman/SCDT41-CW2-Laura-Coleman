using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2
{
    class Program
    {
        static void Main(string[] args)
        {

            //System Admin Log In




            //Dentists Log In

            dentist den1 = new dentist("Dennis Doe", "Taunton", 1, "dennis", "dennis");
            dentist den2 = new dentist("Dennis Two", "Taunton", 2, "dennistwo", "dennistwo");
            dentist den3 = new dentist("Dennis Three", "Taunton", 3, "dennisthree", "dennisthree");
            dentist den4 = new dentist("Dennis Four", "Street", 1, "dennisfour", "dennisfour");
            dentist den5 = new dentist("Dennis Five", "Street", 2, "dennisfive", "dennisfive");
            dentist den6 = new dentist("Dennis Six", "Street", 3, "dennissix", "dennissix");
            dentist den7 = new dentist("Dennis Seven", "Wells", 1, "dennisseven", "dennisseven");
            dentist den8 = new dentist("Dennis Eight", "Wells", 2, "denniseight", "denniseight");
            dentist den9 = new dentist("Dennis Nine", "Wells", 3, "dennisnine", "dennisnine");

            den1.DentistLogIn();







            //Nurses Log In
    
            Nurse Nurse1 = new Nurse("Jane Doe", "Taunton", 1, "jane", "jane");
            Nurse Nurse2 = new Nurse("Jane Two", "Taunton", 2, "janetwo", "janetwo");
            Nurse Nurse3 = new Nurse("Jane Three", "Taunton", 3, "janethree", "janethree");
            Nurse Nurse4 = new Nurse("Jane Four", "Street", 1, "janefour", "janefour");
            Nurse Nurse5 = new Nurse("Jane Five", "Street", 2, "janefive", "janefive");
            Nurse Nurse6 = new Nurse("Jane Six", "Street", 3, "janesix", "janesix");
            Nurse Nurse7 = new Nurse("Jane Seven", "Wells", 1, "janeseven", "janeseven");
            Nurse Nurse8 = new Nurse("Jane Eight", "Wells", 2, "janeeight", "janeeight");
            Nurse Nurse9 = new Nurse("Jane Nine", "Wells", 3, "janenine", "janenine");


            Nurse1.NurseLogIn();


        }
    }
}
