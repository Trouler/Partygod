using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDetection : MonoBehaviour
{
    private bool isHighLighted = false;
   private Color previousColor;
   public GameObject LightUpPrefab;
   private GameObject clone1;
   private RaycastHit2D foundHit;
    GameObject previousObject;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        RayCastForPickups();



        //if (foundHit.collider != null && !isHighLighted)
        //{
        //    isHighLighted = true;
        //    LightUpObject();
        //}
  

    }

    //void LightUpObject()
    //{

       
    //    StartCoroutine(Highligting());
        
        
        
    //}

    //IEnumerator Highligting()
    //{
    //    previousColor = foundHit.collider.GetComponent<SpriteRenderer>().color;
    //    foundHit.collider.GetComponent<SpriteRenderer>().color = Color.yellow;
    //    previousObject = foundHit.collider.gameObject;
    //    Debug.Log(previousColor);
    //    yield return new WaitForSeconds(2);
    //    previousObject.GetComponent<SpriteRenderer>().color = previousColor;
    //    isHighLighted = false;
    //}

   private void RayCastForPickups()
    {
        //Raycastar i en riktning och debuggar en grön stråle
        if (gameObject.GetComponent<movePlayerScript>().NSEW == "N")
        {
            foundHit = Physics2D.Raycast(new Vector2(gameObject.transform.position.x, gameObject.transform.position.y - 2), Vector2.up, 2);
            Debug.DrawRay(transform.position, Vector2.up, Color.green);

        }
        else if (gameObject.GetComponent<movePlayerScript>().NSEW == "S")
        {
            foundHit = Physics2D.Raycast(new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + 2), Vector2.down, 2);
            Debug.DrawRay(transform.position, Vector2.down, Color.green);

        }
        else if (gameObject.GetComponent<movePlayerScript>().NSEW == "E")
        {
            foundHit = Physics2D.Raycast(new Vector2(gameObject.transform.position.x + 2, gameObject.transform.position.y), Vector2.right, 2);
            Debug.DrawRay(transform.position, Vector2.right, Color.green);

        }
        else if (gameObject.GetComponent<movePlayerScript>().NSEW == "W")
        {
            foundHit = Physics2D.Raycast(new Vector2(gameObject.transform.position.x - 2, gameObject.transform.position.y), Vector2.left,2);
            Debug.DrawRay(transform.position, Vector2.left, Color.green);

        }
        Debug.Log(foundHit.collider.tag);
        
    }

}
