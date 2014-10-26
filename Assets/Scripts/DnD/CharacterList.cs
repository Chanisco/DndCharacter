using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharacterList : MonoBehaviour {
	public Sprite Dwarf,Elve,Gnome,HalfElve,HalfOrc,Human,Orc,Tiefling;
	public Sprite Barbarian,Bard,Cleric,Druid,Fighter,Mage,Monk,Paladin,Ranger,Rogue,Sorcerer,Wizard;
	public static Sprite profilePic;
	private int i = 0;
	void Awake(){
		if(i < Characters.Count){
			if(Characters[i].races == Races.Dwarf){
				Characters[i].iconRace = Dwarf;
			}
			
			if(Characters[i].races == Races.Elve){
				Characters[i].iconRace = Elve;
			}
			
			if(Characters[i].races == Races.Gnome){
				Characters[i].iconRace = Gnome;
			}
			
			if(Characters[i].races == Races.HalfElve){
				Characters[i].iconRace = HalfElve;
			}
			
			if(Characters[i].races == Races.HalfOrc){
				Characters[i].iconRace = HalfOrc;
			}
			
			if(Characters[i].races == Races.Human){
				Characters[i].iconRace = Human;
			}
			
			if(Characters[i].races == Races.Orc){
				Characters[i].iconRace = Orc;
			}
			
			if(Characters[i].races == Races.Tiefling){
				Characters[i].iconRace = Tiefling;
			}
			
			if(Characters[i].classes == Classes.Barbarian){
				Characters[i].iconClass = Barbarian;
			}
			
			if(Characters[i].classes == Classes.Bard){
				Characters[i].iconClass = Bard;
			}
			
			if(Characters[i].classes == Classes.Cleric){
				Characters[i].iconClass = Cleric;
			}
			
			if(Characters[i].classes == Classes.Druid){
				Characters[i].iconClass = Druid;
			}
			
			if(Characters[i].classes == Classes.Fighter){
				Characters[i].iconClass = Fighter;
			}
			
			if(Characters[i].classes == Classes.Mage){
				Characters[i].iconClass = Mage;
			}
			
			if(Characters[i].classes == Classes.Monk){
				Characters[i].iconClass = Monk;
			}
			
			if(Characters[i].classes == Classes.Paladin){
				Characters[i].iconClass = Paladin;
			}
			
			if(Characters[i].classes == Classes.Ranger){
				Characters[i].iconClass = Ranger;
			}
			
			if(Characters[i].classes == Classes.Rogue){
				Characters[i].iconClass = Rogue;
			}
			if(Characters[i].classes == Classes.Sorcerer){
				Characters[i].iconClass = Sorcerer;
			}
			if(Characters[i].classes == Classes.Wizard){
				Characters[i].iconClass = Wizard;
			}

			i++;
		}
	}
	
	public static List<Character> Characters = new List<Character>{
		new Character(0,"DEATHGUY",			profilePic,profilePic,Gender.Female,Alligment.NeutralNormal,Races.Gnome,Classes.Fighter),
	};

	public static List<Character> Graveyard = new List<Character>{
		new Character(0,"DEATHGUY",			profilePic,profilePic,Gender.Female,Alligment.NeutralNormal,Races.Gnome,Classes.Fighter),
	};
	
	public class Character
	{
		public int 			id;
		public string 		naam;
		public Sprite 		iconRace;
		public Sprite 		iconClass;
		public Gender 		gender;
		public Alligment	alligment;
		public Races		races;
		public Classes		classes;

		private Character CharacterComponent;
		public Character(int Id,string Name,Sprite IcoClass,Sprite IcoRace,Gender _gender,Alligment _alligment,Races _races, Classes _classes)
		{
			
			id = Id;
			naam = Name;
			iconRace = IcoRace;
			iconClass = IcoClass;
			gender = _gender;
			alligment = _alligment;
			races = _races;
			classes = _classes;
		}
	}
}
