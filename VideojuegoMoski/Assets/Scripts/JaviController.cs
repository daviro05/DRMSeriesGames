using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JaviController : MonoBehaviour {

	public float speed = 3f;
	public float jumpPower = 7f;
	public bool tocando;
	public float mov;


	private float escala = 0.48f;
	private bool jump;
	private Rigidbody2D rb2d;
	private Animator anim;

	public enum GameState{Idle,Playing,Ended};
	public GameObject enemyGenerator;
	public GameState gameState = GameState.Idle;

	// Use this for initialization
	void Start () {
		
		rb2d = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
		NotificationCenter.DefaultCenter ().AddObserver (this, "hacersePeq");
		NotificationCenter.DefaultCenter ().AddObserver (this, "hacerseGrande");
	}
	
	// Update is called once per frame
	void Update () {


		if ((gameState == GameState.Idle) && (Input.GetKeyDown ("up") || Input.GetMouseButtonDown (0))) 
		{
			gameState = GameState.Playing;
			//enemyGenerator.SendMessage ("StartGenerator");
		}

		movimientoJugador ();

		if ((Input.GetKeyDown (KeyCode.UpArrow)) && tocando) {
			jump = true;
		}

		anim.SetBool ("Suelo", tocando);

				
	}

	public void movimientoJugador(){

		//anim.SetFloat ("speed",Mathf.Abs(rb2d.velocity.x));
		anim.SetFloat ("speed",Mathf.Abs(mov));
	}

	public void hacersePeq(){
		escala = 0.28f;
		transform.localScale = new Vector3(escala, escala, 0.9f);
	}

	public void hacerseGrande(){
		escala = 0.48f;
		transform.localScale = new Vector3(escala, escala, 0.9f);
	}

	void FixedUpdate () {

		if (Input.GetAxis ("Horizontal") > 0) {
			//rb2d.velocity = new Vector2 (speed, rb2d.velocity.y);
			this.transform.Translate(0.1f,0,0);
			transform.localScale = new Vector3 (escala, escala, 0.9f);
			mov = 2;
		}
		else if (Input.GetAxis ("Horizontal") < 0) {
			//rb2d.velocity = new Vector2 (-speed, rb2d.velocity.y);
			this.transform.Translate(-0.1f,0,0);
			transform.localScale = new Vector3 (-escala, escala, 0.9f);
			mov = 2;
		}
		else
			mov = 0;
		
		if (jump) {
			rb2d.AddForce (Vector2.up * jumpPower, ForceMode2D.Impulse);
			jump = false;
		}
	}
}
