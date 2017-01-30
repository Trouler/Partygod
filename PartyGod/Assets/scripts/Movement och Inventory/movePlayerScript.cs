using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayerScript : MonoBehaviour
{

    public float speed;
    private Rigidbody2D rb2d;
    private BoxCollider2D boxcoll2d;
    private GameManager gameScript;
	private GameObject nearItem;
    public string NSEW;

    // Use this for initialization
    void Start()
    {
        NSEW = "N";
        gameScript = GameObject.Find("Gamemanager").GetComponent<GameManager>();
        rb2d = GetComponent<Rigidbody2D>();
        boxcoll2d = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //vilken riktning tittar Spelaren
        wichDirection();

        //Spelar förflyttning
        rb2d.velocity = (new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"))) * speed;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {

    }
    public void wichDirection()
    {
        // kollar vilken rikning spelaren är
        if (Input.GetKeyDown(KeyCode.W))
        {
            NSEW = "N";
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            NSEW = "S";
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            NSEW = "W";
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            NSEW = "E";
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Door")
        {
			
        }
    }

	void OnTriggerStay2D(Collider2D other){
		if (other.tag == "Pickup") {
			if (Input.GetKeyDown(KeyCode.Space)) {
				gameScript.addInventoryItem (other.gameObject);
			}
		}
	}
}
