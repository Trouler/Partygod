using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public abstract class Inventory : MonoBehaviour {


	public List<Image> images = new List<Image> ();
	public int index = 0;
	//är minus ett, annars börjar den på 0 och selectar den först rutan
	protected int selectedid = -1;
	public Image baseimg;
	[SerializeField]private int inventorySize;
	public int inventoryMargin = 1;
	public int inventoryHeight;


	// Use this for initialization
	protected virtual void Start () {
		//tar bort område på vänsterkanten
		int sideMargin = Screen.width / (inventoryMargin * 2);
		//tar bort lika stor del på högra sidan
		int goodwidth = Screen.width - sideMargin*2;
		//hittar halva skärmens storlek för att canvas har noll i mitten
		int half = Screen.width / 2;
		//delar up positioner på en linje som gör att inventoryt hamnar symetriskt i mitten
		int margin = goodwidth / (inventorySize +1);
		//sätter ut alla bilder för inventoryt
		for (int i = 0; i < inventorySize; i++) {
			Image toInstantiate = baseimg;
			Image instance = Instantiate (toInstantiate,gameObject.transform) as Image;
			//positionen på varje bild sätts ut: genom att först ta bort halva längden på skärmen så att man börjar på vänsetsidan
			//sedan lägger man till sidomarginalen så att den första bilden inte ligger emot vänstersidan på skärmen
			//sedan lägger man till marginalen emellan objekten gånger iterationen av for loopen
			instance.transform.localPosition = new Vector3 (-half + sideMargin + (margin * (i+1)), inventoryHeight, 0);
			images.Add (instance);
		}
	}


	public virtual void moveIndexLeft(){
		index--;
		if (index < 0)
			index = images.Count - 1;
	}

	public virtual void moveIndexRight(){
		index++;
		if (index > images.Count -1)
			index = 0;
	}

	public virtual void selectIndex(){
		selectedid = index;
	}

	public virtual void addItem(GameObject item){

	}

	public virtual GameObject removeItem(int selectoid){
		return null;
	}

	public int getMax(){
		return inventorySize;
	}

	public virtual int getListCount(){
		return 0;
	}
}
