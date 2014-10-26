using UnityEngine;
using System.Collections;

public class OnClick : MonoBehaviour {

	private float radius;
	void Start(){
		radius = transform.localScale.x;
	}

	void Update(){
		PressCheck();
	}

	void PressCheck(){
		if(Input.GetMouseButton(0)){
			Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			float dist = Mathf.Pow(MousePos.x - transform.position.x,2) + Mathf.Pow(MousePos.y - transform.position.y,2);
			dist = Mathf.Sqrt(dist);
			
			
			if(dist < radius){
				if(!FlagTournamentAwake.Gameset){
					Destroy(gameObject);
					TournamentPeople.PositionsOne.Add(int.Parse(gameObject.name));
//					Debug.Log(TournamentPeople.PositionsOne[0]);
				}
			}
		}
	}
}
