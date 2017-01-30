using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItem : MonoBehaviour {

	protected int id;
	protected int inventoryId;
	protected Sprite copiedTexture;
	protected bool selected;
	protected bool hovering;


	// Use this for initialization
	/*void Start () {
		
	}*/

	public InventoryItem(int id, int invId,Sprite copy){
		this.id = id;
		this.inventoryId = invId;
		this.copiedTexture = copy;
	}
	
	// Update is called once per frame
	/*void Update () {
		
	}*/

	public void hoverOn(){
		hovering = true;
	}

	public void hoverOff(){
		hovering = false;
	}

	public void selcting(){
		selected = true;
	}

	public void deSelecting(){
		selected = false;
	}
}
