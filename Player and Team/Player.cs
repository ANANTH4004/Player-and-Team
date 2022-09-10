using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_and_Team
{
    public class Player
    {
		List<Player> Team = new List<Player>();
		private int _PlayerID;

		public int PlayerID
		{
			get { return _PlayerID; }
			set { _PlayerID = value; }
		}

		private string _name;

		public string PlayerName
		{
			get { return _name; }
			set { _name = value; }
		}
		private int _Age;

		public int Age
		{
			get { return _Age; }
			set { _Age = value; }
		}
		public Player()
		{
			Console.WriteLine("Default Constructor");
		}
		public  Player(int id , string name , int age)
		{
			this.PlayerID = id;
			this.PlayerName = name;
			this.Age = age;
		}
       
		


    }
}
