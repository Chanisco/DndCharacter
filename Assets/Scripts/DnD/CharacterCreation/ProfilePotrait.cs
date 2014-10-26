using UnityEngine;
using System.Collections;

public class ProfilePotrait : MonoBehaviour {
	//public Sprite potrait;

	public void Profile(Sprite potrait){
		if(potrait != null){
			SpriteRenderer profilePotrait = GetComponent<SpriteRenderer>();
			profilePotrait.sprite = potrait;
		}
	}

}
