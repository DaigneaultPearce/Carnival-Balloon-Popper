using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour {

	public GameObject particle;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Pop() {
		Instantiate (particle, transform.position, transform.rotation, gameObject.transform.parent);
		Destroy (gameObject);
	}
}
