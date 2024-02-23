using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_13A_DLLs {

    //implemented by basketball class
    public interface ICap {
        float SalaryCap { get; set; }
        float TotalPayroll { get; set; }
        float RemainingCapSpace { get; set; }

        void IncreasePayroll(float payrollIncrease);
        void DecreasePayroll(float payrollDecrease);

    }

    public class Team {

        //team info is left empty if the base class is instantiated
        public string SportName = string.Empty;
        public string CoachName = string.Empty;
        public string TeamName = string.Empty;
        public string[] Players = null;
        public int NumPlayers = 0;

        //this is a standard ToString(), generic for any team. This is called from the overridden
        //ToString() methods in the subclasses, but then extra information is added by each subclass
        public override string ToString() {
            return "Sport Name: " + SportName + "\nTeam name: " + TeamName + "\nCoach Name: " + CoachName
                + "\nNumber of Players: " + NumPlayers + "\n";
        }

        //This is meant to be overridden, as calling this from the base class instantiation doesn't provide much information
        public virtual void PlayerList() {

            Console.WriteLine("There are no players on the team.\n");

        }

    }
}
