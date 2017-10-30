using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cerveza : MonoBehaviour {


	private bool haColisionado = false;
	public GameObject tinder;
	private Animator anim;

	// Use this for initialization
	void Start () {
		anim = tinder.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D collider){
		//Debug.Log (collider.gameObject.tag);
		if (!haColisionado && collider.gameObject.tag == "Player") {
			haColisionado = true;
			NotificationCenter.DefaultCenter ().PostNotification (this, "hacerseGrande");
			if (tinder)
				anim.SetBool ("movimiento", true);
			Destroy (gameObject);
		}

	}
}
