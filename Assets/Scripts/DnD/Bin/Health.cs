using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	private Rect hpRect = new Rect(0,120,300,100);
	private Rect noteRect = new Rect(5,220,120,50);

	public GUIStyle healthStyle;
	private Color Test;

	private int maxHealth;
	private int healthPoints;

	private string hp;
	private string note;
	public Texture2D background;

	void Start(){
		maxHealth = CharacterPrefs.Health;
		healthPoints = CharacterPrefs.Health;
		Test = new Color(0,0,0);
		if(Screen.height == 1280){
			hpRect = new Rect(0,120,400,200);
			noteRect = new Rect(5,320,120,50);
			healthStyle.fontSize = 200;
		}


	}
	void OnGUI(){
	
		string hp = healthPoints.ToString() + "Hp";
		GUI.contentColor = Test;
		healthStyle.normal.textColor = Test;
		GUI.backgroundColor = new Color(0,0,10);
		if(GUI.Button(hpRect,hp,healthStyle)){
			healthPoints -= 1;
			ConditionCheck();
		}
		GUI.skin.label.fontSize = 20;
		GUI.Label(noteRect,note);
	}

	void ConditionCheck(){
		if(healthPoints < 0){
			Test = new Color(10,0,0);
		}
		if(maxHealth / 2 == healthPoints){
			//note = Screen.height.ToString() +"   " +  Screen.width.ToString();
		
			Debug.Log (GUI.skin.button.border);
			note = "Bloodied!";
		}
	}

	void Update(){
		if(Input.GetKey(KeyCode.Escape)){
			Application.Quit();
		}
	}
}
