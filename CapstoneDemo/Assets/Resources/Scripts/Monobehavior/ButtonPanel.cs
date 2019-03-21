using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPanel : MonoBehaviour {

    public Button CurrentButton;
    public GameObject Panel;
    bool IsDisplayed { get; set; }

	// Use this for initialization
	void Start () {
        IsDisplayed = true;
	}
	
	// Update is called once per frame
	void Update () {
        Panel.SetActive(IsDisplayed);

    }

    public void WhenClicked()
    {
        if (IsDisplayed)
        {
            IsDisplayed = false;
        }
        else
        {
            IsDisplayed = true;
        }

    }
    public void doExitGame()
    {
        Application.Quit();
    }

}
