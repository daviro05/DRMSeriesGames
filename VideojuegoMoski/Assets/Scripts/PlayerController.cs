using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Animator animator;

	public GameObject game;
	public GameObject enemyGenerator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
		bool gamePlaying = (game.GetComponent<GameController> ().gameState == GameState.Playing);
		if (gamePlaying && (Input.GetKeyDown ("up") || Input.GetMouseButtonDown (0))) {
			UpdateState ("PlayerJump");
		}
	}

	public void UpdateState(string state = null){

	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Enemy") {
			//Debug.Log ("Me muero");
			UpdateState ("PlayerDied");
			game.GetComponent<GameController> ().gameState = GameState.Ended;
			enemyGenerator.SendMessage ("CancelGenerator",true);
		}
			
	}
}
