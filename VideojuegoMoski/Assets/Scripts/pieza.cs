using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pieza : MonoBehaviour {

	private bool haColisionado = false;
	private int valorPiezas = 1;

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
			NotificationCenter.DefaultCenter ().PostNotification (this, "IncrementarPiezas",valorPiezas);
			Destroy (gameObject);
		}

	}
}
