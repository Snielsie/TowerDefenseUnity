using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	public float Speed;

	// Use this for initialization
	void Start () {
			
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate(Vector3.right*Time.deltaTime*Speed);
	}
	
	void OnTriggerEnter (Collider hit){
		if(hit.gameObject.tag==("DeadZone")){
			Destroy (this.gameObject);
		}
	}
}

	
