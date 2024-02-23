using Assignment_13A_DLLs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_13A_DLLs {

    //implemented by Baseball class. Baseball class must include the team's current score,
    //the current inning of the game they're playing, and functions to increment both of
    //those properties
    public interface IBaseball {
        int Score { get; set; }
        int CurrentInning { get; set; }

        void NextInning();
        void HomeRun();
    }

    //extends Team, implements IBaseball class
    public class Baseball : Team, IBaseball {

        public int Score { get; set; }
        public int CurrentInning { get; set; }

        public void NextInning() {
            if(CurrentInning < 9)
                CurrentInning++;
            else
                Console.WriteLine("Only 9 innings per game!");
        }

        public void HomeRun() {
            Score++;
        }

        //a characteristic specific to baseball
        public string[] Catchers = { "Kyle Higashioka", "Jose Trevino" };

        //the generic data fields are written to in the constructor
        public Baseball() {
            SportName = "Baseball";
            TeamName = "New York Yankees";
            CoachName = "Matt Blake";
            Players = new string[] { "Albert Abreu", "Jhony Brito", "Gerrit Cole", "Jimmy Cordero", "Nestor Cortes",
                                    "Domingo German", "Ian Hamilton", "Clay Holmes", "Michael King", "Ron Marinaccio",
                                    "Wandy Peralta", "Clarke Schmidt", "Gred Weissert"};
            NumPlayers = Players.Length;
        }

        //print the roster and catchers as seen in baseball teams
        public override void PlayerList() {
            Console.WriteLine("There are {0} players on the baseball team.", NumPlayers);
            Console.WriteLine("Yankees roster:");
            foreach (string player in Players)
                Console.WriteLine(player);
            Console.WriteLine();
            Console.WriteLine("Catchers:");
            foreach (string catcher in Catchers)
                Console.WriteLine(catcher);

            Console.WriteLine();

        }

        //ToString that will run in a Team object initialized as a Baseball()
        public override string ToString() {
            return base.ToString() + "Number of Catchers: " + Catchers.Length + "\n";
        }

    }
}
