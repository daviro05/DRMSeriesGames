using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balonController : MonoBehaviour {


	private bool haColisionado = false;
	private Animator anim;
	public GameObject cerveza;
	public GameObject muro;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D collider){
		//Debug.Log (collider.gameObject.tag);
		if (!haColisionado && collider.gameObject.tag == "Colision") {
			haColisionado = true;
			anim.SetBool ("disparo", true);
			anim.enabled = true;
			cerveza.SetActive (true);
			Destroy (muro);
		}
	}
}
