using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pocionPeqMax : MonoBehaviour {

	private bool haColisionado = false;
	public GameObject personaje;

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
			NotificationCenter.DefaultCenter ().PostNotification (this, "hacersePeq");
			Destroy (gameObject);
			//Destruimos al personaje que le daba la pista
			Destroy (personaje);
		}

	}
}
