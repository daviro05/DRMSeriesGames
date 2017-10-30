using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comprobarSuelo : MonoBehaviour {

	private JaviController player;

	// Use this for initialization
	void Start () {
		player = GetComponentInParent<JaviController>();
	}

	void OnCollisionStay2D(Collision2D col){
		if(col.gameObject.tag == "Suelo")
			player.tocando = true;
	}

	void OnCollisionExit2D(Collision2D col){
		if(col.gameObject.tag == "Suelo")
			player.tocando = false;
	}
}
