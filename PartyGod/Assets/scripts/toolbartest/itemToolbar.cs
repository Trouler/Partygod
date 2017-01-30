using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemToolbar : Inventory {

	public List<GameObject> items = new List<GameObject> ();

	// Use this for initialization
	protected override void Start () {
		base.Start();
	}

	
	// Update is called once per frame
	void Update () {
		
	}

	public override void addItem(GameObject item){
		items.Add (item);
		uppdatePositions ();
	}

	public override GameObject removeItem (int selectoid){
		if (selectoid < items.Count) {
			GameObject thisOne = items [selectoid];
			GameObject instance = Instantiate (items [selectoid]);
			Destroy (thisOne);
			items.RemoveAt (selectoid);
			uppdatePositions ();
			return instance;
		} else
			return null;
	}

	private void uppdatePositions(){
		for (int i = 0; i < images.Count; i++) {
			images [i].sprite = baseimg.sprite;
		}
		for (int i = 0; i < items.Count; i++) {
			images[i].sprite = items [i].GetComponent<SpriteRenderer> ().sprite;
		}
	}

	public override int getListCount ()
	{
		return items.Count;
	}
}
