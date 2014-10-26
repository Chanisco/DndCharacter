using UnityEngine;
using System.Collections;

public class SetAssist : MonoBehaviour {

	public GameObject Yes,No;
	
	// Update is called once per frame
	void Update () {
		PressCheck(Yes);
		PressCheck(No);
	}

	void PressCheck(GameObject target){
		if(Input.touchCount == 1 || Input.GetMouseButton(0)){
			Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			float dist = Mathf.Pow(MousePos.x - target.transform.position.x,2) + Mathf.Pow(MousePos.y - target.transform.position.y,2);
			dist = Mathf.Sqrt(dist);
			float radius = target.transform.localScale.x;
			
			if(dist < radius){
				if(target.name == "Yes"){
					Temporare.page1 = false;
					Temporare.page2 = false;
					Temporare.page3 = false;
					Temporare.page4 = false;
					Temporare.SaveCharacter = true;
					NewScreen.sceneEnd = true;
					NewScreen.purpose = "DndField";
				}
			}
		}
	}
}
