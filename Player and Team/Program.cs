using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_and_Team
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player(1,"Anand",21);
            Player p2 = new Player(2,"Varun",22);
            Player p3 = new Player(3,"Nithya",22);
            Player p4 = new Player(4,"Kathija",30);
            Team Team1 = new Team();
            Team1.AddPlayer(p1);
            Team1.AddPlayer(p2);
            Team1.AddPlayer(p3);
            Team1.AddPlayer(p4);
            Team1.AddPlayer();
            Team1.GetPlayer(3);
            Team1.RemovePlayer(2);
            Team1.Print();

        }
    }
}
