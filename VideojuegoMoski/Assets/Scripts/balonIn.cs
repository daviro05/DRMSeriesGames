using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balonIn : MonoBehaviour {

	public float velocidad = 5f;
	public AudioSource fuente;
	public AudioClip sonido;
	public GameObject palos;
	public GameObject balonCharly;
	public GameObject Werty;
	public GameObject WertyCompleto;
	public GameObject Charly;
	public GameObject CharlyCompleto;

	private Rigidbody2D rb2d;
	private Animator anim;

	// Use this for initialization
	void Start () {
		anim = balonCharly.GetComponent<Animator> ();
		fuente = gameObject.AddComponent<AudioSource> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D collider){
		//Debug.Log (collider.gameObject.tag);
		if (collider.gameObject.tag == "Palos") {
			fuente.clip = sonido;
			fuente.Play();
			//Destruccion del balon y de los palos de rugby
			Destroy (gameObject);
			Destroy (palos);
			Destroy (Werty);
			Destroy (Charly);
			CharlyCompleto.SetActive (true);
			WertyCompleto.SetActive (true);
			anim.SetBool ("parado", true);
			anim.enabled = false;
		}

	}

	void OnMouseDown(){
		rb2d = GetComponent<Rigidbody2D> ();
		rb2d.velocity = new Vector2 (velocidad, 12f);
	}


}
