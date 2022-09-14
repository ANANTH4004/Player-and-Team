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
            Player p2 = new Player(2,"Hirthikk",22);
            Player p3 = new Player(3,"Veeman",22);
            Player p4 = new Player(4,"Keerthi",30);
            Player p5 = new Player(5,"Thanga",30);
            Player p6 = new Player(6,"Mukil",30);
            Player p7 = new Player(7,"Ragul",30);
            Player p11 = new Player(8,"Saran",30);
            Player p8 = new Player(9,"Sivaram",30);
            Player p9 = new Player(10,"Saravanan",30);
            Player p10 = new Player(11,"Balaji",30);
            Player p12 = new Player(12,"Adityen",30);
            Team Team1 = new Team();
            Team1.AddPlayer(p1);
            Team1.AddPlayer(p2);
            Team1.AddPlayer(p3);
            Team1.AddPlayer(p4);
            Team1.AddPlayer(p5);
            Team1.AddPlayer(p6);
            Team1.AddPlayer(p7);
            Team1.AddPlayer(p8);
            Team1.AddPlayer(p9);
            Team1.AddPlayer(p10);
            Team1.AddPlayer(p11);
            Team1.AddPlayer(p12);
           //Team1.AddPlayer();
            Team1.GetPlayer(3);
            Team1.RemovePlayer(2);
            Team1.GetPlayer(2);
            Team1.GetPlayer("Anand");
            Team1.GetPlayer("Nithya");
            //Team1.AddPlayer();
           // Team1.Print();

        }
    }
}
