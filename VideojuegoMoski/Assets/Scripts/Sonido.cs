using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonido : MonoBehaviour {

	public AudioClip[] lista;
	public AudioSource fuente;
	private int contador;
	public int contadorMax;

	// Use this for initialization
	void Start () {
		fuente = gameObject.AddComponent<AudioSource> ();
		contador = 0;
	}
	void OnMouseDown(){
		if (contador == contadorMax)
			contador = 0;
		fuente.clip = lista [contador];
		fuente.Play();
		contador++;
	}
	// Update is called once per frame
	void Update () {
	}
}
