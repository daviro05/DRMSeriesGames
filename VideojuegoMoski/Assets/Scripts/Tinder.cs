using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tinder : MonoBehaviour {

	private bool haColisionado = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D collider){
		//Debug.Log (collider.gameObject.tag);
		if (!haColisionado && collider.gameObject.tag == "Player") {
			haColisionado = true;
			NotificationCenter.DefaultCenter ().PostNotification (this, "MovilEncontrado");
			Destroy (gameObject);
		}
}
}
