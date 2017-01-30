using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour {

	protected Rigidbody2D rb2d;
	protected BoxCollider2D boxcoll2d;
	protected int glad;
	protected float drag;
	protected float weight;


	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		boxcoll2d = GetComponent<BoxCollider2D> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D coll){
		
	}


}