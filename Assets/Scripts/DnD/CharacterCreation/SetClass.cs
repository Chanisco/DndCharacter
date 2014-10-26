using UnityEngine;
using System.Collections;

public enum Classes
{
	Barbarian,
	Bard,
	Cleric,
	Druid,
	Fighter,
	Mage,
	Monk,
	Paladin,
	Ranger,
	Rogue,
	Sorcerer,
	Wizard
}
public class SetClass : MonoBehaviour {
	private float minDistantX = 1;
	private Vector3 startPos;

	public GameObject Barbarian,Bard,Cleric,Druid,Fighter,Mage,Monk,Paladin,Ranger,Rogue,Sorcerer,Wizard;
	public Classes classes;

	public static bool priority;
	
	// Update is called once per frame
	void Update () {
		PressCheck(Barbarian);
		PressCheck(Bard);
		PressCheck(Cleric);
		PressCheck(Druid);
		PressCheck(Fighter);
		PressCheck(Mage);
		PressCheck(Monk);
		PressCheck(Paladin);
		PressCheck(Ranger);
		PressCheck(Rogue);
		PressCheck(Sorcerer);
		PressCheck(Wizard);
	}

	void Swipe(bool SwipeOrClick){
		if(Input.touchCount > 0){
			Touch touch = Input.touches[0];
			
			switch(touch.phase){
			case TouchPhase.Began:
				startPos = touch.position;
				break;

			case TouchPhase.Ended:
				Vector3 resultVector = (new Vector3(0, touch.position.x,0) - new Vector3(0,startPos.x,0));
				float SwipeDistanceX = resultVector.magnitude;
				
				if(SwipeDistanceX > minDistantX){
					float swipeValue = Mathf.Sign(touch.position.x - startPos.x);
					if(swipeValue > 0){

					}else if(swipeValue < 0){

					}
				}
				break;
				
			}
		}
	}
	void PressCheck(GameObject target){
		if(Input.touchCount == 1 || Input.GetMouseButton(0)){
			Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			float dist = Mathf.Pow(MousePos.x - target.transform.position.x,2) + Mathf.Pow(MousePos.y - target.transform.position.y,2);
			dist = Mathf.Sqrt(dist);
			float radius = target.transform.localScale.x;
			
			if(dist < radius){
				if(target.name == "Barbarian"){
					classes = Classes.Barbarian;
					Temporare.classes = classes;
					priority = true;
				}
				if(target.name == "Bard"){
					classes = Classes.Bard;
					Temporare.classes = classes;
					priority = true;
				}
				if(target.name == "Cleric"){
					classes = Classes.Cleric;
					Temporare.classes = classes;
					priority = true;
				}
				if(target.name == "Druid"){
					classes = Classes.Druid;
					Temporare.classes = classes;
					priority = true;
				}
				if(target.name == "Paladin"){
					classes = Classes.Paladin;
					Temporare.classes = classes;
					priority = true;
				}
				if(target.name == "Fighter"){
					classes = Classes.Fighter;
					Temporare.classes = classes;
					priority = true;
				}
				if(target.name == "Mage"){
					classes = Classes.Mage;
					Temporare.classes = classes;
					priority = true;
				}
				if(target.name == "Monk"){
					classes = Classes.Monk;
					Temporare.classes = classes;
					priority = true;
				}
				if(target.name == "Rogue"){
					classes = Classes.Rogue;
					Temporare.classes = classes;
					priority = true;
				}
				if(target.name == "Sorcerer"){
					classes = Classes.Sorcerer;
					Temporare.classes = classes;
					priority = true;
				}
				if(target.name == "Wizard"){
					classes = Classes.Wizard;
					Temporare.classes = classes;
					priority = true;
				}
			}
		}
	}
}
