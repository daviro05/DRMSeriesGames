using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuilleController : MonoBehaviour {

	private AudioSource audio;
	private bool sonando;

	public GameObject guilleCompleto;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();
		sonando = false;
		NotificationCenter.DefaultCenter ().AddObserver (this, "Completo");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Completo(Notification notification){
		Destroy (gameObject);
		guilleCompleto.SetActive (true);
	}

	void OnMouseDown()
	{
		if (!sonando) {
			audio.Play ();
			sonando = true;
		}
			
	}

}
