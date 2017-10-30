using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum GameState{Idle,Playing,Ended};

public class GameController : MonoBehaviour {


	public GameState gameState = GameState.Idle;
	public GameObject enemyGenerator;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//Empieza el juego
		//Comprobamos el estado del juego y si es parado y apretamos una tecla o raton, cambia el estado a jugando.

		if ((gameState == GameState.Idle) && (Input.GetKeyDown ("up") || Input.GetMouseButtonDown (0))) 
		{
			gameState = GameState.Playing;
			//player.SendMessage ("UpdateState", "PlayerRun");
			enemyGenerator.SendMessage ("StartGenerator");
		} 
	}
}
