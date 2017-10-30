﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Controlador : MonoBehaviour {

	public void CambiarEscena(string nombre){
		print ("Cambiando a la escena " + nombre);
		SceneManager.LoadScene (nombre);
	}

	public void Salir(){
		print ("Saliendo del juego");
		Application.Quit ();
	}
}
