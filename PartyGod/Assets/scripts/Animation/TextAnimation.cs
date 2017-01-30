using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAnimation : MonoBehaviour {

    private string textToAnimate;
    private Text textOutput;

    public float letterSpeed;

	void Start () { 
        textOutput = GetComponent<Text>();
        textToAnimate = textOutput.text;
        textOutput.text = "";
        StartCoroutine(AnimateText());
	}
	
    IEnumerator AnimateText()
    {
        foreach (char letter in textToAnimate.ToCharArray())
        {
            textOutput.text += letter;
            yield return new WaitForSeconds(letterSpeed);
        }
    }



}
