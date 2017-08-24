using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class DisplayInfo : MonoBehaviour {
	public TextMesh mainText;
	public TextMesh additionalText;
	private bool textShowing;

	// Use this for initialization
	void Start () {
		// GetComponent<Renderer>().enabled = false;
		hideAllText ();
	}
	
	public void showMainText() {
		mainText.GetComponent<Renderer>().enabled = true;
	}

	public void hideMainText() {
		if (textShowing == false)
			mainText.GetComponent<Renderer>().enabled = false;
	}

	public void showAllText() {
		mainText.GetComponent<Renderer>().enabled = true;
		mainText.GetComponent<Collider>().enabled = true;
		additionalText.GetComponent<Renderer>().enabled = true;
		additionalText.GetComponent<Collider>().enabled = true;
		textShowing = true;
	}
		
	public void hideAllText() {
		mainText.GetComponent<Renderer>().enabled = false;
		mainText.GetComponent<Collider>().enabled = false;
		additionalText.GetComponent<Renderer>().enabled = false;
		additionalText.GetComponent<Collider>().enabled = false;
		textShowing = false;
	}

	public void toggleTextDisplay() {
		if (textShowing == false)
			showAllText ();
		else
			hideAllText ();
	}
		
	public void testDebugPrint() {
		Debug.Log ("Test");
	}
}