using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabScript : MonoBehaviour {

    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;
    public Button button9;
    public Button button10;

    public void Start()
    {
        ObjectPlacer.ObjectTagToPlace = "Wall";
        UpdateTrayWalls();
    }

    public void UpdateTrayWalls()
    {
        button3.gameObject.SetActive(true);
        button4.gameObject.SetActive(false);
        button5.gameObject.SetActive(false);
        button6.gameObject.SetActive(false);
        button7.gameObject.SetActive(false);
        button8.gameObject.SetActive(false);
        button9.gameObject.SetActive(false);
        button10.gameObject.SetActive(false);
        //change button image, click function, and name
        button1.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>("Sprites/Inventory/Wall_1");
        //button1.GetComponentInChildren<Text>().text = "Wall 1";
        button1.onClick.AddListener(OnClickSetWall1);
        button2.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>("Sprites/Inventory/Wall_1 Alt");
        //button2.GetComponentInChildren<Text>().text = "Wall 2";
        button2.onClick.AddListener(OnClickSetWall2);
        button3.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>("Sprites/Inventory/Wall_2");
        //button3.GetComponentInChildren<Text>().text = "Wall 3";
        button3.onClick.AddListener(OnClickSetWall3);
    }

    public void OnClickSetWall1()
    {
        ObjectPlacer.ObjectTagToPlace = "Wall";
        ObjectPlacer.ObjectTypeToPlace = "Wall_1";
        ObjectPlacer.ObjectTypeToString = "Wall 1";
    }
    public void OnClickSetWall2()
    {
        ObjectPlacer.ObjectTagToPlace = "Wall";
        ObjectPlacer.ObjectTypeToPlace = "Wall_1 Alt";
        ObjectPlacer.ObjectTypeToString = "Wall 2";
    }
    public void OnClickSetWall3()
    {
        ObjectPlacer.ObjectTagToPlace = "Wall";
        ObjectPlacer.ObjectTypeToPlace = "Wall_2";
        ObjectPlacer.ObjectTypeToString = "Wall 3";
    }

    public void UpdateTrayFloors()
    {
        button3.gameObject.SetActive(false);
        button4.gameObject.SetActive(false);
        button5.gameObject.SetActive(false);
        button6.gameObject.SetActive(false);
        button7.gameObject.SetActive(false);
        button8.gameObject.SetActive(false);
        button9.gameObject.SetActive(false);
        button10.gameObject.SetActive(false);
        button1.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>("Sprites/Inventory/Wall_Floor");
        //button1.GetComponentInChildren<Text>().text = "Floor 1";
        button1.onClick.AddListener(OnClickSetFloor1);
        button2.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>("Sprites/Inventory/Wall_Floor Alt");
        //button2.GetComponentInChildren<Text>().text = "Floor 2";
        button2.onClick.AddListener(OnClickSetFloor2);
    }
    
    public void OnClickSetFloor1()
    {
        ObjectPlacer.ObjectTagToPlace = "Floor";
        ObjectPlacer.ObjectTypeToPlace = "Wall_Floor";
        ObjectPlacer.ObjectTypeToString = "Floor 1";
    }
    public void OnClickSetFloor2()
    {
        ObjectPlacer.ObjectTagToPlace = "Floor";
        ObjectPlacer.ObjectTypeToPlace = "Wall_Floor Alt";
        ObjectPlacer.ObjectTypeToString = "Floor 2";
    }
    public void UpdateTrayDoors()
    {
        button3.gameObject.SetActive(false);
        button4.gameObject.SetActive(false);
        button5.gameObject.SetActive(false);
        button6.gameObject.SetActive(false);
        button7.gameObject.SetActive(false);
        button8.gameObject.SetActive(false);
        button9.gameObject.SetActive(false);
        button10.gameObject.SetActive(false);
        button1.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>("Sprites/Inventory/Wall_Doorway");
        //button1.GetComponentInChildren<Text>().text = "Door 1";
        button1.onClick.AddListener(OnClickSetDoor1);
        button2.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>("Sprites/Inventory/Wall_Doorway Alt");
        //button2.GetComponentInChildren<Text>().text = "Door 2";
        button2.onClick.AddListener(OnClickSetDoor2);
    }

    public void OnClickSetDoor1()
    {
        ObjectPlacer.ObjectTagToPlace = "Wall";
        ObjectPlacer.ObjectTypeToPlace = "Wall_Doorway";
        ObjectPlacer.ObjectTypeToString = "Doorway 1";
    }
    public void OnClickSetDoor2()
    {
        ObjectPlacer.ObjectTagToPlace = "Wall";
        ObjectPlacer.ObjectTypeToPlace = "Wall_Doorway Alt";
        ObjectPlacer.ObjectTypeToString = "Doorway 2";
    }

    public void UpdateTrayWindows()
    {
        button3.gameObject.SetActive(false);
        button4.gameObject.SetActive(false);
        button5.gameObject.SetActive(false);
        button6.gameObject.SetActive(false);
        button7.gameObject.SetActive(false);
        button8.gameObject.SetActive(false);
        button9.gameObject.SetActive(false);
        button10.gameObject.SetActive(false);
        button1.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>("Sprites/Inventory/Wall_Window");
        //button1.GetComponentInChildren<Text>().text = "Window 1";
        button1.onClick.AddListener(OnClickSetWindow1);
        button2.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>("Sprites/Inventory/Wall_Window Alt");
        //button2.GetComponentInChildren<Text>().text = "Window 2";
        button2.onClick.AddListener(OnClickSetWindow2);
    }

    public void OnClickSetWindow1()
    {
        ObjectPlacer.ObjectTagToPlace = "Wall";
        ObjectPlacer.ObjectTypeToPlace = "Wall_Window";
        ObjectPlacer.ObjectTypeToString = "Window 1";
    }
    public void OnClickSetWindow2()
    {
        ObjectPlacer.ObjectTagToPlace = "Wall";
        ObjectPlacer.ObjectTypeToPlace = "Wall_Window Alt";
        ObjectPlacer.ObjectTypeToString = "Window 2";
    }

    public void UpdateTrayRoof()
    {
        button3.gameObject.SetActive(true);
        button4.gameObject.SetActive(true);
        button5.gameObject.SetActive(false);
        button6.gameObject.SetActive(false);
        button7.gameObject.SetActive(false);
        button8.gameObject.SetActive(false);
        button9.gameObject.SetActive(false);
        button10.gameObject.SetActive(false);
        //change button image, click function, and name
        button1.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>("Sprites/Inventory/House_Roof_1A");
        //button1.GetComponentInChildren<Text>().text = "Roof 1";
        button1.onClick.AddListener(OnClickSetRoof1);
        button2.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>("Sprites/Inventory/House_Roof_1A2");
        //button2.GetComponentInChildren<Text>().text = "Roof 2";
        button2.onClick.AddListener(OnClickSetRoof2);
        button3.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>("Sprites/Inventory/House_Roof_1C");
        //button3.GetComponentInChildren<Text>().text = "Roof 3";
        button3.onClick.AddListener(OnClickSetRoof5);
        button4.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>("Sprites/Inventory/House_Roof_1C2");
        //button4.GetComponentInChildren<Text>().text = "Roof 4";
        button4.onClick.AddListener(OnClickSetRoof6);
        button5.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>("Sprites/Inventory/");
        //button5.GetComponentInChildren<Text>().text = "Roof 5";
        //button5.onClick.AddListener(OnClickSetRoof5);
        //button6.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>("Sprites/Inventory/");
        ////button6.GetComponentInChildren<Text>().text = "Roof 6";
        //button6.onClick.AddListener(OnClickSetRoof6);
        //button7.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>("Sprites/Inventory/House_Roof_1D");
        ////button7.GetComponentInChildren<Text>().text = "Roof 7";
        //button7.onClick.AddListener(OnClickSetRoof7);
        //button8.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>("Sprites/Inventory/House_Roof_1D2");
        ////button8.GetComponentInChildren<Text>().text = "Roof 8";
        //button8.onClick.AddListener(OnClickSetRoof8);
        //button9.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>("Sprites/Inventory/House_Roof_1E");
        ////button9.GetComponentInChildren<Text>().text = "Roof 9";
        //button9.onClick.AddListener(OnClickSetRoof9);
        //button10.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>("Sprites/Inventory/House_Roof_1E2");
        ////button10.GetComponentInChildren<Text>().text = "Roof 10";
        //button10.onClick.AddListener(OnClickSetRoof10);
    }

    public void OnClickSetRoof1()
    {
        ObjectPlacer.ObjectTagToPlace = "Roof";
        ObjectPlacer.ObjectTypeToPlace = "House_Roof_1A";
        ObjectPlacer.ObjectTypeToString = "Roof 1";

    }
    public void OnClickSetRoof2()
    {
        ObjectPlacer.ObjectTagToPlace = "Roof";
        ObjectPlacer.ObjectTypeToPlace = "House_Roof_1A2";
        ObjectPlacer.ObjectTypeToString = "Roof 2";
    }
    public void OnClickSetRoof3()
    {
        ObjectPlacer.ObjectTagToPlace = "Roof";
        ObjectPlacer.ObjectTypeToPlace = "House_Roof_1B";
        ObjectPlacer.ObjectTypeToString = "Roof 3";
    }
    public void OnClickSetRoof4()
    {
        ObjectPlacer.ObjectTagToPlace = "Roof";
        ObjectPlacer.ObjectTypeToPlace = "House_Roof_1B2";
        ObjectPlacer.ObjectTypeToString = "Roof 4";
    }
    public void OnClickSetRoof5()
    {
        ObjectPlacer.ObjectTagToPlace = "Roof";
        ObjectPlacer.ObjectTypeToPlace = "House_Roof_1C";
        ObjectPlacer.ObjectTypeToString = "Roof 3";
    }
    public void OnClickSetRoof6()
    {
        ObjectPlacer.ObjectTagToPlace = "Roof";
        ObjectPlacer.ObjectTypeToPlace = "House_Roof_1C2";
        ObjectPlacer.ObjectTypeToString = "Roof 4";
    }
    public void OnClickSetRoof7()
    {
        ObjectPlacer.ObjectTagToPlace = "Roof";
        ObjectPlacer.ObjectTypeToPlace = "House_Roof_1D";
        ObjectPlacer.ObjectTypeToString = "Roof 7";
    }
    public void OnClickSetRoof8()
    {
        ObjectPlacer.ObjectTagToPlace = "Roof";
        ObjectPlacer.ObjectTypeToPlace = "House_Roof_1D2";
        ObjectPlacer.ObjectTypeToString = "Roof 8";
    }
    public void OnClickSetRoof9()
    {
        ObjectPlacer.ObjectTagToPlace = "Roof";
        ObjectPlacer.ObjectTypeToPlace = "House_Roof_1E";
        ObjectPlacer.ObjectTypeToString = "Roof 9";

    }
    public void OnClickSetRoof10()
    {
        ObjectPlacer.ObjectTagToPlace = "Roof";
        ObjectPlacer.ObjectTypeToPlace = "House_Roof_1E2";
        ObjectPlacer.ObjectTypeToString = "Roof 10";
    }

    // Update is called once per frame
    void Update ()
    {
	}

    public void DestroyChildren()
    {
        foreach (Transform child in GameObject.Find("Tray").transform)
        {
            GameObject.Destroy(child.gameObject);
        }
    }

    public void ExitTheGame()
    {
        Application.Quit();
    }
}
