using UnityEngine;
using System.Collections;


public class Main : MonoBehaviour {
	public GUIText Coin, score;
	public static int Cash;
	public float Playtime;
	public GameObject Tower;
	public GameObject Ennemy;
	public Vector3 TowerSpawn;
	public static int Score;
	public Transform Tile;
	public Vector3 Size;
	public GameObject Dijk;
	public Vector3[] spawnPoints;
	
	private float spawnSpeed = 5f;
	
	
	void DecreaseSpawnTime()
	{
		if(spawnSpeed> 0.6f)		
			spawnSpeed *=0.97f;
	}
	
	void Start () {
		CreateGrid();
		PlaceSpawn();
		Cash = 50;
		
		
	}
	
	void Update (){
		score.text = ("Score: "+ Score);
		Coin.text = ("Coin: "+Cash);
		Playtime += Time.deltaTime; 
		int test = (int)Mathf.Round(Playtime);
	}

	
	void CreateGrid(){
		for(int x = 0; x< Size.x; x++){
			for(int y = 0; y< Size.y; y++){
			Instantiate(Tile, new Vector3(x, y, -1), Quaternion.identity);
			}
		}
	}

	void PlaceSpawn(){
		int spawnPointNumber = Random.Range(0, spawnPoints.Length);
		
		GameObject go = Instantiate(Ennemy, spawnPoints[spawnPointNumber], Quaternion.identity) as GameObject;
		//Instantiate(Ennemy, point1, Quaternion.identity);
		DecreaseSpawnTime();
		Invoke("PlaceSpawn", spawnSpeed);
		
	}
}