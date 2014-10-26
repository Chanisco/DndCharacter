using UnityEngine;
using System.Collections;

public class Wayne : MonoBehaviour {

	//Comment
	/*
	 * 1.Beweging
	 * 2.Honger/slaap en andere benodigdheden
	 * 3. hij moet vies kunnen worden
	 * 4. Spullen oppakken en gebruiken
	 * 5. Ziek kunnen worden
		
	 */
	// Use this for initialization

	float speed = 1.5f;
	public bool links;
	public bool rechts;
	float eigenKeuze;
	float pauze = 2f;
	public bool Afgeleid;


	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Afgeleid == false){
			pauze += 1 * Time.deltaTime;

			if(pauze > 3){
				eigenKeuze = Random.Range(0,10);
				Debug.Log(eigenKeuze);
				pauze = 0;
			}

			if(eigenKeuze < 5){
				links 	= true;
				rechts 	= false;
			}else{
				links 	= false;
				rechts 	= true;

			}

			//Als links aanstaat ga dan naar links
			if(links == true){
				speed = -1.5f;
			}
			//Als rechts aanstaat ga dan naar rechts
			if(rechts == true){
				speed = 1.5f;
			}
			if(links == true && rechts == true){
				speed = 0f;
			}
			transform.Translate(speed * Time.deltaTime,0,0);
		}
	}
}
