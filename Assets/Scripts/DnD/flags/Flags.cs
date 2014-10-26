using UnityEngine;
using System.Collections;

public class Flags : MonoBehaviour {
	public int FlagNumber;
	public Transform Name;
	public Sprite Sweet;
	private ProfilePotrait potraitScript;

	void Start(){
		if(CharacterList.Characters.Count > 0){
			if(gameObject.name == "MainFlag"){
				potraitScript = GetComponentInChildren<ProfilePotrait>();
				TextMesh CharName = GetComponentInChildren<TextMesh>();
				CharName.text = CharacterList.Characters[0].naam;
				if(CharacterList.Characters[0].iconRace != null){
					potraitScript.Profile(CharacterList.Characters[0].iconRace);
				}
			}
		}

	}
	


}
