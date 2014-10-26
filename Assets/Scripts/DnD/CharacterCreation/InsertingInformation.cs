using UnityEngine;
using System.Collections;

public class InsertingInformation : MonoBehaviour {
	private float radius;

	public string purpose;
	public TouchScreenKeyboard keyboard;
	private bool Open;
	private string InputKeyboard = "";
	private TextMesh MeshText;
	public static bool important = false;

	private int State;
	
	void Start(){
		WhatBox();
		radius = transform.localScale.x;
	}

	void Update () {
		PressCheck();
		Temporare.KeyboardOpen = Open;
		if(keyboard != null){
			if(keyboard.done && Open){
				TextMesh MeshText= GetComponentInChildren<TextMesh>();
				MeshText.text = keyboard.text;
				SwitchStatement(State);
				Open = false;

			}
		}
	}

	void OnGUI(){
		if(purpose == "Name"){
			if(Open){
				keyboard = TouchScreenKeyboard.Open(InputKeyboard,TouchScreenKeyboardType.NamePhonePad,false,false,false,false);
			}
		}
		if(purpose == "Number"){
			if(Open){
				keyboard = TouchScreenKeyboard.Open(InputKeyboard,TouchScreenKeyboardType.NumberPad,false,false,false,false);
			}
		}

	}

	void PressCheck(){
		if(Input.touchCount == 1 || Input.GetMouseButton(0)){
			Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			float dist = Mathf.Pow(MousePos.x - transform.position.x,2) + Mathf.Pow(MousePos.y - transform.position.y,2);
			dist = Mathf.Sqrt(dist);
			
			
			if(dist < radius && !Open){
				Open = true;
				Temporare.KeyboardOpen = true;
			}
		}
	}

	void SwitchStatement(int SwitchState){
		switch(SwitchState){
		case 0:
			Temporare.name = keyboard.text;
			important = true;
			break;
		case 1:
			Temporare.age =  keyboard.text;
			break;
		case 2:
			Temporare.height = keyboard.text;
			break;
		case 3:
			Temporare.weight = keyboard.text;
			break;
		}

	}

	void WhatBox(){
		if(gameObject.name == "InsertNameBox"){
			State = 0;
		}else if(gameObject.name == "InsertAgeBox"){
			State = 1;
		}else if(gameObject.name == "InsertHeightBox"){
			State = 2;
		}else if(gameObject.name == "InsertWeightBox"){
			State = 3;
		}
	}
}
