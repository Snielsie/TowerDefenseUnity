using UnityEngine;
using System.Collections;

public class Lives : MonoBehaviour {
	public int LifeCounter = 1;	
	
	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "Ennemy"){
			Debug.Log ("Loselife");
			LifeCounter -=1;
			if(LifeCounter <=1){
				GameOver();
			}
		}		
	}
	void GameOver(){
		Time.timeScale =0;
	}
}
