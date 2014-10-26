using UnityEngine;
using System.Collections;
public enum Races
{
	Dwarf,
	Elve,
	Gnome,
	HalfElve,
	HalfOrc,
	Human,
	Orc,
	Tiefling
}

public class SetRace : MonoBehaviour {

	public GameObject Dwarf,Elve,Gnome,HalfElve,HalfOrc,Human,Orc,Tiefling;
	public Races races;
	public bool priority;
	
	void Update () {
		PressCheck(Dwarf);
		PressCheck(Elve);
		PressCheck(Gnome);
		PressCheck(HalfElve);
		PressCheck(HalfOrc);
		PressCheck(Human);
		PressCheck(Orc);
		PressCheck(Tiefling);
		if(priority && SetClass.priority){
			Temporare.page3 = true;
		}
	}

	void PressCheck(GameObject target){
		if(Input.touchCount == 1 || Input.GetMouseButton(0)){
			Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			float dist = Mathf.Pow(MousePos.x - target.transform.position.x,2) + Mathf.Pow(MousePos.y - target.transform.position.y,2);
			dist = Mathf.Sqrt(dist);
			float radius = target.transform.localScale.x;
			
			if(dist < radius){
				if(target.name == "Dwarf"){
					races = Races.Dwarf;
					Temporare.race = races;
					priority = true;
				}else if(target.name == "Elve"){
					races = Races.Elve;
					Temporare.race = races;
					priority = true;
				}else if(target.name == "Gnome"){
					races = Races.Gnome;
					Temporare.race = races;
					priority = true;
				}else if(target.name == "HalfElve"){
					races = Races.HalfElve;
					Temporare.race = races;
					priority = true;
				}else if(target.name == "HalfOrc"){
					races = Races.HalfOrc;
					Temporare.race = races;
					priority = true;
				}else if(target.name == "Human"){
					races = Races.Human;
					Temporare.race = races;
					priority = true;
				}else if(target.name == "Orc"){
					races = Races.Orc;
					Temporare.race = races;
					priority = true;
				}else if(target.name == "Tiefling"){
					races = Races.Tiefling;
					Temporare.race = races;
					priority = true;
				}
			}
		}
	}

}
