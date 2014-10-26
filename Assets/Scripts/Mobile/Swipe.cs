using UnityEngine;
using System.Collections;

public class Swipe : MonoBehaviour {
	private float minDistantY = 1;
	private Vector3 startPos;
	private int playerNumbers = CharacterList.Characters.Count;


	void Update(){
		if(Global.MenuOn == false){
			if(CharacterList.Characters.Count > 5){
				Swiping();
			}
		}

	}

	 void Swiping(){
		CharacterList.Characters[0].naam = playerNumbers.ToString();
		if(Input.touchCount > 0){
			Touch touch = Input.touches[0];
			
			switch(touch.phase){
			case TouchPhase.Began:
				startPos = touch.position;
				break;
				
			case TouchPhase.Ended:
				Vector3 resultVector = (new Vector3(0, touch.position.y,0) - new Vector3(0,startPos.y,0));
				float SwipeDistanceY = resultVector.magnitude;
				
				if(SwipeDistanceY > minDistantY){
					float swipeValue = Mathf.Sign(touch.position.y - startPos.y);
					if(swipeValue > 0){
						CameraMove(true);
					}else if(swipeValue < 0){
						CameraMove(false);
					}
				}
				break;
				
			}
		}
	}

	void CameraMove(bool DirectionY){
		if(DirectionY ){
			CharacterList.Characters[0].naam = "UP";
			if(transform.position.y < 1){
				transform.Translate(new Vector3(0,1,0));
			}
		
		}
		if(!DirectionY){
			CharacterList.Characters[0].naam = "Down";
			if(transform.position.y < playerNumbers - 7){
				transform.Translate(new Vector3(0,-1,0));


			}
		}

	}
}
