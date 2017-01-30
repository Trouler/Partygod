using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour {

	private List<GameObject> inventorylist = new List<GameObject> ();
	private List<GameObject> items = new List<GameObject> ();
	public GameObject player;
	public GameObject pickUpItem;
	public GameObject Inventory;
	public GameObject ItemInventory;
	public Canvas canvas;
	private GameObject backGroundInventory;
	private GameObject itemInventory;
	private Inventory backGroundInventoryScript;
	private Inventory itemInventoryScript;
	private int inventoryMax;


	// Use this for initialization
	void Start () {
		//initierar backgrunds inventoryt
		backGroundInventory = instantiateInventory (backGroundInventory, Inventory);
		//initierar scriptet för backgrunds inventoryt
		backGroundInventoryScript = instantiateInventoryScript (backGroundInventory, backGroundInventoryScript);
		//initierar item inventoryt
		itemInventory = instantiateInventory (itemInventory, ItemInventory);
		//initierar scriptet för item inventoryt
		itemInventoryScript = instantiateInventoryScript (itemInventory, itemInventoryScript);
		inventoryMax = itemInventoryScript.getMax ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Alpha1))
			backGroundInventoryScript.moveIndexLeft();
		if (Input.GetKeyDown (KeyCode.Alpha2))
			backGroundInventoryScript.moveIndexRight();
		if (Input.GetKeyDown (KeyCode.P))
			backGroundInventoryScript.selectIndex ();
		if (Input.GetKeyDown (KeyCode.R))
			removeFromInventory ();
	}

	public void addInventoryItem(GameObject item){
		if (inventoryMax > itemInventoryScript.getListCount ()) {
			GameObject instance = Instantiate (item);
			itemInventoryScript.addItem (instance);
			instance.SetActive (false);
			Destroy (item);
		}
	}

	public void removeFromInventory(){
		GameObject instance = itemInventoryScript.removeItem (backGroundInventoryScript.index);
		if (instance != null) {
			if (!instance.activeSelf)
				instance.SetActive (true);
			instance.transform.position = player.transform.position;
			items.Add (instance);
		}
	}

	private GameObject instantiateInventory(GameObject inventory,GameObject original){
		GameObject toInstantiate = original;
		inventory = Instantiate (toInstantiate,canvas.transform) as GameObject;
		inventory.transform.localPosition = new Vector3(0,0,10);
		return inventory;
	}

	private Inventory instantiateInventoryScript(GameObject inventory, Inventory inventoryscript){
		inventoryscript = inventory.GetComponent<Inventory> ();
		return inventoryscript;
	}
}
