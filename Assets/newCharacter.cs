using UnityEngine;
using System.Collections;

public class newCharacter : MonoBehaviour {

	public GameObject AddCharacter,Graveyard,Tamagochi;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		PressCheck(AddCharacter);
		PressCheck(Graveyard);
		PressCheck(Tamagochi);
	}

	void PressCheck(GameObject target){
		if(Input.touchCount == 1 || Input.GetMouseButton(0)){
			Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			float dist = Mathf.Pow(MousePos.x - target.transform.position.x,2) + Mathf.Pow(MousePos.y - target.transform.position.y,2);
			dist = Mathf.Sqrt(dist);
			float radius = target.transform.localScale.x;
			
			if(dist < radius){
				if(target.name == "CharacterCreation"){
					Temporare.page1 = false;
					Temporare.page2 = false;
					Temporare.page3 = false;
					Temporare.page4 = false;
					NewScreen.sceneEnd = true;
					NewScreen.purpose = "CharacterCreation";
				}else if (target.name == "Graveyard"){
					Temporare.page1 = false;
					Temporare.page2 = false;
					Temporare.page3 = false;
					Temporare.page4 = false;
					//Application.LoadLevel("DndField");
				}
			}
		}
	}
}
