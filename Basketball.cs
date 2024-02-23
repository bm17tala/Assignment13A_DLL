using Assignment_13A_DLLs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_13A_DLLs {

    //any class implementing the basketball interface (the basketball class only) must have
    //properties for the number of times the team scored(NumBaskets), times any foul is
    //committed by the team (NumFouls), and functions to increment those two properties when
    //neccessary
    public interface IBasketball {
        int NumBaskets { get; set; }
        int NumFouls { get; set; }
        void Score();
        void CommitFoul();
    }

    //extends Team class, implements IBasketball and ICap interfaces
    public class Basketball : Team, IBasketball, ICap {

        //these are required by the ICap interface
        public float SalaryCap { get; set; }
        public float TotalPayroll { get; set; }
        public float RemainingCapSpace { get; set; }

        public void IncreasePayroll(float payrollIncrease) {
                TotalPayroll += payrollIncrease;
        }

        public void DecreasePayroll(float payrollDecrease) {
                TotalPayroll -= payrollDecrease;
        }

        //these are required by IBasketBall interface
        public int NumBaskets { get; set; }
        public int NumFouls { get; set; }
        public void Score() {
            NumBaskets++;
        }
        public void CommitFoul() {
            NumFouls++;
        }


        //a characteristic specific to basketball
        public string[] Positions = { "Center", "Power Forward", "Small Forward", "Point Guard", "Shooting Guard" };

        //the generic data fields are written to in the constructor
        public Basketball() {
            SportName = "Basketball";
            TeamName = "Chicago Bulls";
            CoachName = "Billy Donovan";
            Players = new string[] { "Coby White", "Lonzo Ball", "Andre Drummond", "Derrick Jones Jr.", "Alex Caruso", "Zach LaVine",
                    "Nikola Vucevic", "DeMar DeRozan", "Ayo Dosunmu", "Marko Simonovic", "Patrick Beverley", "Carlik Jones",
                    "Javonte Green", "Dalen Terry", "Terry Taylor", "Justin Lewis", "Patrick Williams"};
            NumPlayers = Players.Length;
        }

        //print the roster and positions as seen in basketball teams
        public override void PlayerList() {
            Console.WriteLine("There are {0} players on the basketball team.", NumPlayers);
            Console.WriteLine("Chicago Bulls Roster:");
            foreach (string player in Players)
                Console.WriteLine(player);
            Console.WriteLine();
            Console.WriteLine("Possible positions:");
            foreach (string position in Positions)
                Console.WriteLine(position);

            Console.WriteLine();

        }

        //ToString that will run in a Team object initialized as a Basketball()
        public override string ToString() {
            return base.ToString() + "Number of Positions: " + Positions.Length + "\n";
        }

    }
}
