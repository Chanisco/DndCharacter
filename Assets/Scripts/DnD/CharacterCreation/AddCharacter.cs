using UnityEngine;
using System.Collections;

public class AddCharacter : MonoBehaviour {
	private float radius;
	public string purposeJob;
	public Sprite Empty;
	private bool Saved = true;
	// Update is called once per frame
	void Update () {
		if(Temporare.SaveCharacter && Saved){
			Adding();
			Saved = false;
		}
	}

	void Adding(){
		CharacterList.Characters.Add(new CharacterList.Character(CharacterList.Characters.Count,Temporare.name,Empty,Empty,Temporare.gender,Temporare.alligment,Temporare.race,Temporare.classes));
	}
}
