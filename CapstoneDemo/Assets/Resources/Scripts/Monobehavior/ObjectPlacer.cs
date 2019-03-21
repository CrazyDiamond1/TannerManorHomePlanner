using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectPlacer : MonoBehaviour
{
    private Grid grid;
    private List<GameObject> gameObjects; 
    public static bool PlaceAnywhereMode { get; set; }
    public static string ObjectTypeToPlace { get; set; }
    public static string ObjectTypeToString { get; set; }
    public static string ObjectTagToPlace { get; set; }
    public static int fingerID = -1;
    public static GameObject selected { get; set; }

    public bool hideRoof;
    public bool hideFloor;
    public bool hideWall;

    public void Start()
    {
        hideRoof = false;
        hideFloor = false;
        hideWall = false;
        gameObjects = new List<GameObject>();
        PlaceAnywhereMode = false;
    }

    private void Awake()
    {
        grid = FindObjectOfType<Grid>();
#if !UNITY_EDITOR
        fingerID = 0;
#endif
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && EventSystem.current.IsPointerOverGameObject() == false )
        {
            
            RaycastHit hitInfo;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (PlaceAnywhereMode)
            {
                if (Physics.Raycast(ray, out hitInfo))
                {
                    PlaceObject(hitInfo.point);
                    selected = null;
                }
            }
            else
            {
                if (Physics.Raycast(ray, out hitInfo) && !hitInfo.collider.gameObject.tag.Contains("obj"))
                {
                    PlaceObject(hitInfo.point);
                    selected = null;
                }
                else if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.tag.Contains("obj"))
                {
                    selected = hitInfo.transform.gameObject;
                }
            }
        }
        else if (Input.GetMouseButtonDown(1) && EventSystem.current.IsPointerOverGameObject() == false)
        {
            RaycastHit hitInfo;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.tag.Contains("obj"))
            {
                RemoveObject(hitInfo);
                selected = null;
            }
        }
    }

    public void HideRoofButtonClick()
    {
        if (hideRoof)
        {
            HideObjects("objRoof");
            hideRoof = false;
        }
        else
        {
            UnhideObjects("objRoof");
            hideRoof = true;
        }
    }

    public void HideFloorButtonClick()
    {
        if (hideFloor)
        {
            HideObjects("objFloor");
            hideFloor = false;
        }
        else
        {
            UnhideObjects("objFloor");
            hideFloor = true;
        }
    }
    public void HideWallButtonClick()
    {
        if (hideWall)
        {
            HideObjects("objWall");
            hideWall = false;
        }
        else
        {
            UnhideObjects("objWall");
            hideWall = true;
        }
    }

    public void HideObjects(string tag)
    {
        foreach (var item in gameObjects)
        {
            if (item.tag == tag)
            {
                item.SetActive(false);
            }
        }
    }

    public void UnhideObjects(string tag)
    {
        foreach (var item in gameObjects)
        {
            if (item.tag == tag)
            {
                item.SetActive(true);
            }
        }
    }

    private void RemoveObject(RaycastHit rHit)
    {
        gameObjects.Remove(rHit.transform.gameObject);
        Destroy(rHit.transform.gameObject);
        //Debug.Log(gameObjects.Count);

    }

    private void PlaceObject(Vector3 clickPoint)
    {
        if (ObjectTypeToPlace == null)
        {
            ObjectTypeToPlace = "Wall_1";
            ObjectTypeToString = "Wall 1";
        }
        var finalPosition = grid.GetNearestPointOnGrid(clickPoint);
        GameObject go;
        go = (GameObject)Instantiate(Resources.Load("Prefabs/" + ObjectTypeToPlace));
        go.tag = "obj"+ObjectTagToPlace;
        if (go.tag.Contains("Wall"))
        {
            go.transform.position = finalPosition + new Vector3(0, 1f, 0);
        }
        else if (go.tag.Contains("Roof"))
        {
            go.transform.position = finalPosition + new Vector3(0, 2.4f, 0);
        }
        else
        {
            go.transform.position = finalPosition + new Vector3(0, 0, 0);
        }

        gameObjects.Add(go);
        //Debug.Log(gameObjects.Count);
        //GameObject.CreatePrimitive(PrimitiveType.Sphere).transform.position = nearPoint;
        //Debug.Log(ObjectTypeToPlace);
    }
}
