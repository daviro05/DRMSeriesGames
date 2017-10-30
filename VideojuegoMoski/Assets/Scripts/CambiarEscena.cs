using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CambiarEscena : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collider){
		//Debug.Log (collider.gameObject.tag);
		if (collider.gameObject.tag == "Nivel") {
			SceneManager.LoadScene ("Nivel1");
		}

	}
}
