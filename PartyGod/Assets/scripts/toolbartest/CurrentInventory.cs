using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CurrentInventory : Inventory {

	public Sprite selector;
	public Sprite selected;
	public Sprite unselected;

	protected override void Start () {
		base.Start();
		UpdateUnSelected ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	public override void moveIndexLeft(){
		base.moveIndexLeft ();
		UpdateUnSelected ();
	}

	public override void moveIndexRight ()
	{
		base.moveIndexRight ();
		UpdateUnSelected ();
	}

	public override void selectIndex ()
	{
		base.selectIndex ();
		UpdateUnSelected ();
	}

	private void UpdateUnSelected ()
	{
		for (int i = 0; i < images.Count; i++) {
			if (i != index && i != selectedid) {
				images [i].sprite = unselected;
			}
			if (i == index)
				images [i].sprite = selector;
			if (i == selectedid)
				images [i].sprite = selected;
		}
	}
}
