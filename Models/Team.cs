using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstMVCAppSCAGT.Models
{
    public class Team
    {
        public string teamName;
        public int noOfPlayers;

        public Team() { }

        public Team(string _teamname, int _noofplayers)
        {
            teamName = _teamname;
            noOfPlayers = _noofplayers;
        }

        public void AddPlayer(int count)
        {
            noOfPlayers = noOfPlayers + count;
        }
        public bool RemovePlayer(int count)
        {
            noOfPlayers = noOfPlayers - count;
            if (noOfPlayers < 0)
            {
                return false;
            }

            return true;
        }
    }

    public class Subteam : Team
    {
        public Subteam(string team_Name, int no_OfPlayers) : base(team_Name, no_OfPlayers)
        {
            

            //teamName = team_Name;
            //noOfPlayers = no_OfPlayers;
        }
        public void ChangeTeamName(string name)
        {
            teamName = name;
        }
    }
}