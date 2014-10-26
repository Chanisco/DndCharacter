using UnityEngine;
using System.Collections;

public class PersonalInfo : MonoBehaviour {
	private Rect nameRect = new Rect(0,10,Screen.height - 20,30);
	private Rect classRect = new Rect(0,40,Screen.height - 20,30);
	private Color textColor = new Color(0,0,0);
	void OnGUI(){
		GUI.contentColor = textColor;
		if(Screen.height == 1280){
			nameRect = new Rect(0,10,Screen.height - 20,50);
			classRect = new Rect(0,70,Screen.height - 20,50);
			GUI.skin.label.fontSize = 40;
		}else{
			GUI.skin.label.fontSize = 20;
		}
		GUI.Label(nameRect,"Name = " + CharacterPrefs.Name + "  Race = " + CharacterPrefs.Race);
		GUI.Label(classRect,"Class = " + CharacterPrefs.Class + " Age = " + CharacterPrefs.Age);
	}

}
