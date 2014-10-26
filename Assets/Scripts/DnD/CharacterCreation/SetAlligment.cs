using UnityEngine;
using System.Collections;

public enum Alligment{
	ChaoticEvil,
	NeutralEvil,
	LawfullEvil,
	ChaoticNormal,
	NeutralNormal,
	LawfullNormal,
	ChaoticGood,
	NeutralGood,
	LawfullGood


}
public class SetAlligment : MonoBehaviour {
	public GameObject Chaotic,Neutral,Lawfull,Evil,Normal,Good;

	public Alligment alligment;
	public bool _chaotic,_neutral,_lawfull,_evil,_normal,_good;

	void Update(){
		PressCheck(Chaotic);
		PressCheck(Neutral);
		PressCheck(Lawfull);
		PressCheck(Evil);
		PressCheck(Normal);
		PressCheck(Good);
	}
	void PressCheck(GameObject target){
		if(Input.touchCount == 1 || Input.GetMouseButton(0)){
			Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			float dist = Mathf.Pow(MousePos.x - target.transform.position.x,2) + Mathf.Pow(MousePos.y - target.transform.position.y,2);
			dist = Mathf.Sqrt(dist);
			float radius = target.transform.localScale.x;
			
			if(dist < radius){
				if(target.name == "Chaotic"){
					_chaotic = true;
					_neutral = false;
					_lawfull = false;
				}else if(target.name == "Neutral"){
					_chaotic = false;
					_neutral = true;
					_lawfull = false;
				}else if(target.name == "Lawfull"){
					_chaotic = false;
					_neutral = false;
					_lawfull = true;
				}
				if(target.name == "Evil"){
					_evil 	= true;
					_normal = false;
					_good 	= false;
				}
				if(target.name == "Normal"){
					_evil 	= false;
					_normal = true;
					_good 	= false;
				}
				if(target.name == "Good"){
					_evil 	= false;
					_normal = false;
					_good 	= true;
				}
				ShowFate();
			}
		}
	}

	void ShowFate(){
		if(_chaotic && _evil){
			alligment = Alligment.ChaoticEvil;
		}
		if(_chaotic && _normal){
			alligment = Alligment.ChaoticNormal;
		}
		if(_chaotic && _good){
			alligment = Alligment.ChaoticGood;
		}
		if(_neutral && _evil){
			alligment = Alligment.NeutralEvil;
		}
		if(_neutral && _normal){
			alligment = Alligment.NeutralNormal;
		}
		if(_neutral && _good){
			alligment = Alligment.NeutralGood;
		}
		if(_lawfull && _evil){
			alligment = Alligment.LawfullEvil;
		}
		if(_lawfull && _normal){
			alligment = Alligment.LawfullNormal;
		}
		if(_lawfull && _good){
			alligment = Alligment.LawfullGood;
		}
		Temporare.alligment = alligment;
		Temporare.page2 = true;
	}
}
