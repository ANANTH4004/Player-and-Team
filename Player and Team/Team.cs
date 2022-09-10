using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_and_Team
{
    public class Team
    {
        public static int PlayerCount = 0;
        List<Player> list = new List<Player>();
        
        public void AddPlayer()
        {
            if (PlayerCount < 11)
            {
                Player p = new Player();
                Console.WriteLine("Enter Player id");
                p.PlayerID = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter Player Name :");
                p.PlayerName = Console.ReadLine();
                Console.WriteLine("Enter Player Age ");
                int age = Convert.ToInt32(Console.ReadLine());
                p.Age = age;
                this.list.Add(p);
                PlayerCount++;
            }
            else
            {
                Console.WriteLine("Team is Full...");
            }
        }
        public void AddPlayer(Player p)
        {
            if (PlayerCount < 11)
            {
                list.Add(p);
                PlayerCount++;
            }
            else
            {
                Console.WriteLine("Team is full...");
            }
        }
        public void Print()
        {
            foreach (var item in this.list)
            {
                Console.WriteLine($"Player ID : {item.PlayerID} Player Name: {item.PlayerName}");
            }
            Console.WriteLine("============================");
        }

        public void RemovePlayer(int id)
        {
            var found = this.list.Single(r => r.PlayerID == id);
            if(found != null)
            {
                this.list.Remove(found);
                PlayerCount--;
                Console.WriteLine("Player Removed Successfully....");
            }
            else
            {
                Console.WriteLine("Player Not Found");
            }
           // this.list.RemoveAll( rem => rem.PlayerID == id);
        }
        public void GetPlayer(int id)
        {
            var found = this.list.FindAll(fo => fo.PlayerID == id);
            if (found != null)
            {
                Console.WriteLine("Player Found");
                foreach (var item in found)
                {
                    Console.WriteLine($"Player Id : {item.PlayerID} Player Name : {item.PlayerName} Age : {item.Age}");
                }
            }
            else
            {
                Console.WriteLine("Player Not Found!!");
            }
        }
        public void GetPlayer(string name)
        {
            var found = this.list.FindAll(fo => fo.PlayerName == name);
            if (found != null)
            {
                Console.WriteLine("Player Found");
                foreach (var item in found)
                {
                   
                    Console.WriteLine($"Player Id : {item.PlayerID} Player Name : {item.PlayerName} Age : {item.Age}");
                }
            }
            else
            {
                Console.WriteLine("Player Not Found!!");
            }
        }
    }
}
