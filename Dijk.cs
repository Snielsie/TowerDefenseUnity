using UnityEngine;
using System.Collections;

public class Dijk : MonoBehaviour {
	public int Lives = 3;	
	public Transform Tile;
	public Vector3 Size;
	public GUIText Lvn;
	
	void Update(){
		Lvn.text = ("Lives  " +   Lives);
	}
	
	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "Ennemy"){
			Debug.Log ("Loselife");
			Destroy (other.gameObject);
			Lives -=1;
			if(Lives <1){
				GameOver();
			}
		}		
	}
	void GameOver(){
		Time.timeScale =0;
	}
}
