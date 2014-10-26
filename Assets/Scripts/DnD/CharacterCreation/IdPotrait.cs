using UnityEngine;
using System.Collections;

public class IdPotrait : MonoBehaviour {
	public Sprite Dwarf,Elve,Gnome,HalfElve,HalfOrc,Human,Orc,Tiefling;
	public void Update(){
		Profile(Temporare.race);
	}
	public void Profile(Races races){
		SpriteRenderer profilePotrait = GetComponent<SpriteRenderer>();
		if(races == Races.Dwarf){
			profilePotrait.sprite = Dwarf;
		}
		if(races == Races.Elve){
			profilePotrait.sprite = Elve;
		}
		
		if(races == Races.Gnome){
			profilePotrait.sprite = Gnome;
		}
		
		if(races == Races.HalfElve){
			profilePotrait.sprite = HalfElve;
		}
		
		if(races == Races.HalfOrc){
			profilePotrait.sprite = HalfOrc;
		}
		
		if(races == Races.Human){
			profilePotrait.sprite = Human;
		}
		
		if(races == Races.Orc){
			profilePotrait.sprite = Orc;
		}
		
		if(races == Races.Tiefling){
			profilePotrait.sprite = Tiefling;
		}

	}
}
