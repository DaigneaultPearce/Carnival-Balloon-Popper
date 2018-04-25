using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public int balloonCount;
	public GameObject balloon;
	public Vector3 spawnValues;
	public Material[] randomMaterials;
	// Use this for initialization
	void Start () {
		SpawnBalloons ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SpawnBalloons(){
		for (int i = 0; i < balloonCount; i++) {
			Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, Random.Range (-spawnValues.z, spawnValues.z));
			Quaternion spawnRotation = Quaternion.identity;

			GameObject temp = Instantiate (balloon, spawnPosition, spawnRotation);
			Renderer obj_renderer = temp.GetComponent<Renderer> ();
			obj_renderer.material = randomMaterials [i % randomMaterials.Length];
		}
	}
}
