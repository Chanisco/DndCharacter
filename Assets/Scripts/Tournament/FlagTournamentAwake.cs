using UnityEngine;
using System.Collections;

public class FlagTournamentAwake : MonoBehaviour {

	private int allplayers = TournamentPeople.Deelnemers.Count;
	public GameObject flag;
	private GameObject flagPiece;
	private GameObject flagPieceOne;
	private GameObject flagPieceTwo;
	private int i = 0;
	private Vector3 flagPos;
	private bool Complete = true;
	private bool newComplete = true;
	private float line = -3f;
	private int FreeSpace = 0;
	public static bool Gameset = false;
	
	void Update(){
		//Versus();
		if(Complete){
			if(i < allplayers){
				flagPiece = Instantiate(flag,new Vector3(line,-allplayers,0),Quaternion.identity) as GameObject;
				flagPiece.name = /*"Flag" +*/ i.ToString();
				TextMesh flagText = flagPiece.GetComponentInChildren<TextMesh>();
				flagText.fontSize = 25;
				flagText.text = TournamentPeople.Deelnemers[i].naam;
				
				Complete = false;
				
			}else if(i == allplayers){
				Destroy(gameObject,0);
			}
			if(i == 10){
				line = 0;
				FreeSpace = 10;
			}
			if(i == 20){
				line = 3;
				FreeSpace = 20;
			}

		}else if(!Complete){
			GotoAndSet(flagPiece,i - FreeSpace, line);
		}
		
		if(Input.GetKey(KeyCode.S)){
			Gameset = true;
		}
		if(Input.GetKey(KeyCode.V)){
			newComplete = false;
		}

		if(!newComplete){
			Debug.Log("Thought This");
			int Round1 = TournamentPeople.PositionsOne.Count;
			Versus(TournamentPeople.PositionsOne[Random.Range(0 , Round1)],TournamentPeople.PositionsOne[Random.Range(0 , Round1)]);

		}else{
			GotoAndSet(flagPieceOne,  	1, 	-3f);
			GotoAndSet(flagPieceTwo, 	1 , 3f);
		}
		
	}

	public void GotoAndSet(GameObject flag,int Position, float row){
		flagPos = new Vector3(row,5 - Position,11 + Position);
		float yPos = flag.transform.position.y;
		float zPos = flagPos.z;
		if(yPos < flagPos.y){
			yPos += 1.000001f;
		}else {
			i++;
			Complete = true;
			newComplete = true;
			
		}
		flag.transform.position = new Vector3(row,yPos,zPos);
		
	}

	public void Versus(int i, int j){
		if(!newComplete){
			flagPieceOne = Instantiate(flag,new Vector3(line,-allplayers,0),Quaternion.identity) as GameObject;
			flagPieceOne.name = i.ToString();
			TextMesh flagTextOne = flagPieceOne.GetComponentInChildren<TextMesh>();
			flagTextOne.fontSize = 25;
			flagTextOne.text = TournamentPeople.Deelnemers[i].naam;
			flagPieceTwo = Instantiate(flag,new Vector3(line,-allplayers,0),Quaternion.identity) as GameObject;
			flagPieceTwo.name = j.ToString();
			TextMesh flagTextTwo = flagPieceTwo.GetComponentInChildren<TextMesh>();
			flagTextTwo.fontSize = 25;
			flagTextTwo.text = TournamentPeople.Deelnemers[j].naam;
			newComplete = false;
		}




	}


}
