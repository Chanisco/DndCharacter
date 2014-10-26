using UnityEngine;
using System.Collections;

public class NextPage : MonoBehaviour {
	private float minDistantX = 1;
	private Vector3 startPos;
	public float radius;
	public int page;
	private Transform cam;

	private Vector3 pagePos;
	// Use this for initialization
	void Start () {
		cam = transform.parent;
		page = 0;
		radius = transform.localScale.x;
	}
	
	// Update is called once per frame
	void Update () {
		PressCheck();
		PageField(page);
		Swiping();
	}

	void PressCheck(){
		if(Input.touchCount == 1 || Input.GetMouseButton(0)){
			Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			float dist = Mathf.Pow(MousePos.x - transform.position.x,2) + Mathf.Pow(MousePos.y - transform.position.y,2);
			dist = Mathf.Sqrt(dist);
			
			
			if(dist < radius && Temporare.KeyboardOpen == false){
				TurnPage(true);
			}
		}
	}

	void TurnPage(bool front){
		if(front == true){
			if(Temporare.page1 && page == 0){
				page += 1;
			}else if(Temporare.page2 && page == 1){
				page += 1;
			}else if(Temporare.page3 && page == 2){
				page += 1;
			}
		}else if (front == false){
			if(page != 0){
				page -= 1;
			}
		}
	}
	void PageField(int PageNumber){
		pagePos = new Vector3(page * 10,0,0);

		if(cam.position.x < pagePos.x){
			cam.Translate(1f,0,0);
		}
		if(cam.position.x > pagePos.x){
			cam.Translate(-1f,0,0);
		}

	}

	void Swiping(){
		if(Input.touchCount > 0){
			Touch touch = Input.touches[0];
			
			switch(touch.phase){
			case TouchPhase.Began:
				startPos = touch.position;
				break;
				
			case TouchPhase.Ended:
				Vector3 resultVector = (new Vector3(0, touch.position.x,0) - new Vector3(0,startPos.x,0));
				float SwipeDistanceX = resultVector.magnitude;
				
				if(SwipeDistanceX > minDistantX){
					float swipeValue = Mathf.Sign(touch.position.x - startPos.x);
					if(swipeValue > 0){
						TurnPage(false);
					}else if(swipeValue < 0){
						TurnPage(true);
					}
				}
				break;
				
			}
		}
	}
}
