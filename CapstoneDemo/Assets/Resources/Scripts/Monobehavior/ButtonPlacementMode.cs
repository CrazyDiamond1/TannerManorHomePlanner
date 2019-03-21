using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPlacementMode : MonoBehaviour {

    public Text ModeButton;

    public void WhenClicked()
    {
        if (ObjectPlacer.PlaceAnywhereMode)
        {
            ObjectPlacer.PlaceAnywhereMode = false;
            ModeButton.text = "Place";
        }
        else
        {
            ObjectPlacer.PlaceAnywhereMode = true;
            ModeButton.text = "Select";
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
