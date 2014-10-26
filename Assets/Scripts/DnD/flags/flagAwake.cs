using UnityEngine;
using System.Collections;

public class flagAwake : MonoBehaviour {

	private int allplayers = CharacterList.Characters.Count ;
	public GameObject flag;
	private GameObject flagPiece;
	private int i = 0;
	private Vector3 flagPos;
	private bool Complete = true;
	public float volumeSFX;
	public AudioClip effect;
	
	void Update(){
		if(Complete){
			if(i < allplayers){
				flagPiece = Instantiate(flag,new Vector3(0,-allplayers,0),Quaternion.identity) as GameObject;
				flagPiece.name = /*"Flag" +*/ i.ToString();
				TextMesh flagText = flagPiece.GetComponentInChildren<TextMesh>();
				flagText.fontSize = 25;
				flagText.text = CharacterList.Characters[i].naam;

				Complete = false;

			}else if(i == allplayers){
				//Destroy(gameObject,0);
			}
		}else if(!Complete){
			GotoAndSet(flagPiece,i);
		}



	}
	public void GotoAndSet(GameObject flag,int Position){
		flagPos = new Vector3(0,7 - Position,11 + Position);
		float yPos = flag.transform.position.y;
		float zPos = flagPos.z;
		if(yPos < flagPos.y){
			yPos += 0.5000001f;
		}else /*if (yPos > flagPos.y)*/{
			VlagCollide();
			i++;
			Complete = true;

		}
		flag.transform.position = new Vector3(0,yPos,zPos);

	}

	void VlagCollide(){
		AudioSource.PlayClipAtPoint(effect,new Vector3(0,0,0),volumeSFX);
		
	}
}

