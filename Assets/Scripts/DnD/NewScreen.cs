using UnityEngine;
using System.Collections;

public class NewScreen : MonoBehaviour {
	public float fadeSpeed = 0.1f;
	public static bool sceneStart = true;
	public static  bool sceneEnd = false;

	public static string purpose;

	void Awake () {
		guiTexture.pixelInset = new Rect(0,0,Screen.width,Screen.height);
	}

	void Update(){
		if(sceneEnd){

			EndScene();
		}
		if(sceneStart && !sceneEnd){
			StartScene();
		}
	}

	void StartScene ()
	{
		FadeToClear();
		if(guiTexture.color.a <= 0.05f)
		{
			guiTexture.color = Color.clear;
			guiTexture.enabled = false;
			
			sceneStart = false;
		}
	}

	public void EndScene(){
		guiTexture.enabled = true;
		FadeToBlack();
		if(guiTexture.color.a > 0.80f){
			Debug.Log("Ik kom hierdoor");
			Application.LoadLevel(purpose);
			sceneEnd = false;
			sceneStart = true;
		}
		
	}

	void FadeToBlack(){
		guiTexture.color = Color.Lerp(guiTexture.color, Color.gray, fadeSpeed * Time.deltaTime);
		
	}
	
	void FadeToClear(){
		guiTexture.color = Color.Lerp(guiTexture.color, Color.clear, fadeSpeed * Time.deltaTime);
		
	}
}
