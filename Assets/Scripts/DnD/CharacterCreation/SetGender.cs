using UnityEngine;
using System.Collections;

public enum Gender
{
	Male,
	Female
}

public class SetGender : MonoBehaviour {

	public GameObject Male;
	public GameObject Female;

	public bool man;
	public bool woman;
	
	public Gender gender;

	void Update () {
		PressCheck(Male);
		PressCheck(Female);
	}

	void PressCheck(GameObject target){
		if(Input.touchCount == 1 || Input.GetMouseButton(0)){
			Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			float dist = Mathf.Pow(MousePos.x - target.transform.position.x,2) + Mathf.Pow(MousePos.y - target.transform.position.y,2);
			dist = Mathf.Sqrt(dist);
			float radius = target.transform.localScale.x;
			
			if(dist < radius){
				if(target.name == "Male"){
					man 	= true;
					woman 	= false;
					gender = Gender.Male;
					if(InsertingInformation.important){
						Temporare.page1 = true;
					}
				}else{
					woman 	= true;
					man  	= false;
					gender = Gender.Female;
					if(InsertingInformation.important){
						Temporare.page1 = true;
					}
				}
			}
		}
	}

	void SendingToTemporare(){
		Temporare.gender = gender;
	}
}
