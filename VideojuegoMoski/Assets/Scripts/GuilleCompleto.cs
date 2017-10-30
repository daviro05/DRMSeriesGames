using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuilleCompleto : MonoBehaviour {

	// Use this for initialization
	private int contador;
	private Animator anim;
	private AudioSource audio;
	private bool sonando;

	public GameObject pared;

	void Start () {
		audio = GetComponent<AudioSource> ();
		contador = 0;
		anim = GetComponent<Animator> ();
		sonando = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){
			contador++;
			if (contador == 3) {
				anim.SetBool ("moverse", true);
				Destroy (pared);
			}

		if (!sonando) {
			audio.Play ();
			sonando = true;
		}
	}
}
