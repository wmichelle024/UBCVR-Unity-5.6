using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class DisplayInfo : MonoBehaviour {
	public TextMesh mainText;
	public GameObject popup;
	private bool infoShowing;

	// Use this for initialization
	void Start () {
		// GetComponent<Renderer>().enabled = false;
		hideAllInfo ();
	}
	
	public void showMainText() {
		mainText.GetComponent<Renderer>().enabled = true;
	}

	public void hideMainText() {
		if (infoShowing == false)
			mainText.GetComponent<Renderer>().enabled = false;
	}

	public void showAllInfo() {
		mainText.GetComponent<Renderer>().enabled = true;
		mainText.GetComponent<Collider>().enabled = true;
		popup.GetComponent<Renderer>().enabled = true;
		popup.GetComponent<Collider>().enabled = true;
		infoShowing = true;
	}
		
	public void hideAllInfo() {
		mainText.GetComponent<Renderer>().enabled = false;
		mainText.GetComponent<Collider>().enabled = false;
		popup.GetComponent<Renderer>().enabled = false;
		popup.GetComponent<Collider>().enabled = false;
		infoShowing = false;
	}

	public void toggleTextDisplay() {
		if (infoShowing == false)
			showAllInfo ();
		else
			hideAllInfo ();
	}
		
	public void testDebugPrint() {
		Debug.Log ("Test");
	}
}