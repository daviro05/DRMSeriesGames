using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntos : MonoBehaviour {

	private int puntuacion = 0;
	public TextMesh texto;
	private bool movil;

	// Use this for initialization
	void Start () {
		movil = false;
		actualizarMarcador ();
		NotificationCenter.DefaultCenter ().AddObserver (this, "IncrementarPiezas");
		NotificationCenter.DefaultCenter ().AddObserver (this, "MovilEncontrado");
	}

	void IncrementarPiezas(Notification notificacion){
		int puntosIncrementar = (int)notificacion.data;
		puntuacion += puntosIncrementar;
		actualizarMarcador ();
		Completado ();
	}

	void actualizarMarcador(){
		texto.text = puntuacion.ToString ();
	}

	void MovilEncontrado(Notification notificacion){
		movil = true;
		Completado ();
	}

	void Completado(){
		if (puntuacion == 3 && movil) {
			NotificationCenter.DefaultCenter ().PostNotification (this,"Completo");
		}
	}

	// Update is called once per frame
	void Update () {
		
		
	}
}
