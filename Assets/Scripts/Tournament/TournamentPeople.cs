using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public  class TournamentPeople : MonoBehaviour{
	public Sprite Test;
	public static Sprite profilePic;
	
	void Awake(){
		profilePic = Test;
		Deelnemers[0].icon = profilePic;
	}
	public static List<Persoon> Deelnemers = new List<Persoon>{
		new Persoon(0,"Persoon 1",profilePic,"ITS ON"),
		new Persoon(0,"Persoon 2",profilePic,"ITS ON"),
		new Persoon(0,"Persoon 3",profilePic,"ITS ON"),
		new Persoon(0,"Persoon 4",profilePic,"ITS ON"),
		new Persoon(0,"Persoon 5",profilePic,"ITS ON"),
		new Persoon(0,"Persoon 6",profilePic,"ITS ON"),
		new Persoon(0,"Persoon 7",profilePic,"ITS ON"),
		new Persoon(0,"Persoon 8",profilePic,"ITS ON"),
		new Persoon(0,"Persoon 9",profilePic,"ITS ON"),
		new Persoon(0,"Persoon 10",profilePic,"ITS ON"),
		new Persoon(0,"Persoon 11",profilePic,"ITS ON"),
		new Persoon(0,"Persoon 12",profilePic,"ITS ON"),
		new Persoon(0,"Persoon 13",profilePic,"ITS ON"),
		new Persoon(0,"Persoon 14",profilePic,"ITS ON"),
		new Persoon(0,"Persoon 15",profilePic,"ITS ON"),
		new Persoon(0,"Persoon 16",profilePic,"ITS ON"),
		new Persoon(0,"Persoon 17",profilePic,"ITS ON"),
		new Persoon(0,"Persoon 18",profilePic,"ITS ON"),
		new Persoon(0,"Persoon 19",profilePic,"ITS ON"),
		new Persoon(0,"Persoon 20",profilePic,"ITS ON"),
		new Persoon(0,"Persoon 21",profilePic,"ITS ON"),
		new Persoon(0,"Persoon 22",profilePic,"ITS ON"),
		new Persoon(0,"Persoon 23",profilePic,"ITS ON"),
		new Persoon(0,"Persoon 24",profilePic,"ITS ON"),
		new Persoon(0,"Persoon 25",profilePic,"ITS ON"),
		new Persoon(0,"Persoon 26",profilePic,"ITS ON"),
		new Persoon(0,"Persoon 27",profilePic,"ITS ON"),
		new Persoon(0,"Persoon 28",profilePic,"ITS ON"),
		new Persoon(0,"Persoon 29",profilePic,"ITS ON"),
		new Persoon(0,"Persoon 30",profilePic,"ITS ON"),

	};

	public static List<int> PositionsOne = new List<int>{

	};
	public static List<int> PositionsTwo = new List<int>{
		
	};
	public static List<int> PositionsThree = new List<int>{
		
	};
	public static List<int> PositionsFour = new List<int>{
		
	};
	public static List<int> PositionsFive = new List<int>{
		
	};
	public static List<Game> Games = new List<Game>{
		new Game(0,"RussianRoulette"),
	};

	public class Persoon
	{
		public int 			id;
		public string 		naam;
		public Sprite 		icon;
		public string 		comment;
		private Persoon PersoonComponent;
		public Persoon(int Id,string Name,Sprite Ico,string Comment)
		{
			
			id = Id;
			naam = Name;
			icon = Ico;
			comment = Comment;
		}
	}

	public class Game
	{
		public int 	id;
		public string naam;

		public Game(int Id,string Name){
			id = Id;
			naam = Name;
		}

	}
}
