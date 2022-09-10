using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_and_Team
{
    public static class ExtensionMethod
    {
        public static void AddPlayer(this Player p)
        {
            Console.WriteLine("Enter Player id");
            p.PlayerID = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Player Name :");
            p.PlayerName = Console.ReadLine();
            Console.WriteLine("Enter Player Age ");
            int age = Convert.ToInt32(Console.ReadLine());
            p.Age = age;
        }

    }
}
