using UnityEngine;
using System.Collections;


public class camScript : MonoBehaviour {
	
	private Transform target;
	public GameObject tower;
	
    void Update () {
		
		if(Input.GetMouseButtonDown(0))
		{
	        Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
	        RaycastHit hit;
	        if(Physics.Raycast(ray, out hit)){
				if(Main.Cash>10){
	            if(hit.transform.tag == "Cube")
				{
	            	Debug.Log(hit.collider.gameObject.name);
					target = hit.transform;
					Debug.Log(target.position);
					Instantiate(tower, target.position, target.rotation);
					Main.Cash -=20;
					}
				}
	
	        }
		}
    }

    

}