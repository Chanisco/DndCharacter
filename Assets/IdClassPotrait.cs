using UnityEngine;
using System.Collections;

public class IdClassPotrait : MonoBehaviour {
	public Sprite Barbarian,Bard,Cleric,Druid,Fighter,Mage,Monk,Paladin,Ranger,Rogue;
	
	public void Update(){
		Profile(Temporare.classes);
	}
	public void Profile(Classes classes){
		SpriteRenderer profilePotrait = GetComponent<SpriteRenderer>();
		if(classes == Classes.Barbarian){
			profilePotrait.sprite = Barbarian;
		}
		if(classes == Classes.Bard){
			profilePotrait.sprite = Bard;
		}
		
		if(classes == Classes.Cleric){
			profilePotrait.sprite = Cleric;
		}
		
		if(classes == Classes.Druid){
			profilePotrait.sprite = Druid;
		}
		
		if(classes == Classes.Fighter){
			profilePotrait.sprite = Fighter;
		}
		
		if(classes == Classes.Mage){
			profilePotrait.sprite = Mage;
		}
		
		if(classes == Classes.Monk){
			profilePotrait.sprite = Monk;
		}
		
		if(classes == Classes.Ranger){
			profilePotrait.sprite = Ranger;
		}
		
		if(classes == Classes.Rogue){
			profilePotrait.sprite = Rogue;
		}
		if(classes == Classes.Paladin){
			profilePotrait.sprite = Paladin;
		}
	}
}
