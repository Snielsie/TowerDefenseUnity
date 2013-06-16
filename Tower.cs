using UnityEngine;
using System.Collections;

public class Tower : MonoBehaviour {
	public Transform Spawn;
	public GameObject Projectile;
	public double Reloadtime = 1;
	private double Currenttime = 0;
	
	// Use this for initialization
	void Start () {
		
		Shoot ();
		
	}
	
	// Update is called once per frame
	void Update () { 
		Currenttime += Time.deltaTime;
    	if(Currenttime >= Reloadtime)
    	{
			Shoot ();
			Currenttime = 0.0f;
		}	
	}
	
	void Shoot(){
	Instantiate(Projectile, Spawn.position, transform.rotation);
	}

void OntriggerEnter(Collider other){
	if(other.gameObject.tag ==("Ennemy")){
			Debug.Log("Tower hit");
			Destroy (this.gameObject);
			
		}
	}
}