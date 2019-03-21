using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SelectedObjectNameScript : MonoBehaviour {
    
    public Text t;
	void Start () {
        t.text = ObjectPlacer.ObjectTypeToPlace;
	}
	
	// Update is called once per frame
	void Update () {
        //t.text = EventSystem.current.IsPointerOverGameObject().ToString();
        t.text = ObjectPlacer.ObjectTypeToString;
    }
}
