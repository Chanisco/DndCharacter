using UnityEngine;
using System.Collections;

public class IdAlligment : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		TextMesh Explained = GetComponentInChildren<TextMesh>();
		Explained.text = "Summary";
		if(Temporare.page2 == true){
			if(Temporare.alligment == Alligment.ChaoticEvil){
				Explained.text = "All FOR EVIL!";
			}else if(Temporare.alligment == Alligment.ChaoticGood){
				Explained.text = "ALL FOR GOODNESS!";
			}else if(Temporare.alligment == Alligment.ChaoticNormal){
				Explained.text = "ALL FOR ME!";
			}else if(Temporare.alligment == Alligment.LawfullEvil){
				Explained.text = "Praise me minions!";
			}else if(Temporare.alligment == Alligment.LawfullGood){
				Explained.text = "a good alligment is all";
			}else if(Temporare.alligment == Alligment.LawfullNormal){
				Explained.text = "Accept me as your president!";
			}else if(Temporare.alligment == Alligment.NeutralEvil){
				Explained.text = "Just simply evil";
			}else if(Temporare.alligment == Alligment.NeutralGood){
				Explained.text = "Just simply Good";
			}else if(Temporare.alligment == Alligment.NeutralNormal){
				Explained.text = "...meh";
			}
		}
	}
}
