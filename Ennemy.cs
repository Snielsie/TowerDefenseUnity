using UnityEngine;
using System.Collections;

public class Ennemy : MonoBehaviour {
	public float Speed;
	public int myHp;
	public int lives = 3;
	public float myX;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update (){
		myX = this.transform.position.x;
		transform.Translate(Vector3.left*Time.deltaTime*Speed);		
		if(myHp <=0){
			Main.Cash +=10;
			Destroy (this.gameObject);
			Main.Score +=50;
		}
	}
	void OnTriggerEnter(Collider other){
		Debug.Log ("hit");
		if(other.gameObject.tag == "Projectile"){
			Destroy(other.gameObject);
			Hit();	
		}
		if(other.gameObject.tag == "Tower1"){
			Destroy(other.gameObject);
			Hit();
		}
	}
	void Hit(){
		myHp -=1;
	}	
}