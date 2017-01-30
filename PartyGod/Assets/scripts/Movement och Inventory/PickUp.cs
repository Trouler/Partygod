using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {

	protected BoxCollider2D boxcoll2d;
	public int id;


	// Use this for initialization
	void Start () {
		boxcoll2d = GetComponent<BoxCollider2D> ();
	}

	void Update () {
		
	}
}
