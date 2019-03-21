using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectOrientation : MonoBehaviour {

    public GameObject selected;
    public float rotationSpeed = 100.0f;
    public float y = 0.0f;
    public float moveSpeed = 10.0f;

    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        selected = ObjectPlacer.selected;

        if (selected != null && selected.tag.Contains("Roof"))
        {
            //stretch x axis
            if (!Input.GetButtonUp("Horizontal") && Input.GetAxisRaw("Horizontal") > 0 && selected != null)
            {
                selected.transform.localScale += new Vector3(0.1f, 0, 0);
            }
            else if (!Input.GetButtonUp("Horizontal") && Input.GetAxisRaw("Horizontal") < 0 && selected != null)
            {
                selected.transform.localScale += new Vector3(-0.1f, 0, 0);
            }
            //stretch z axis
            if (!Input.GetButtonUp("Vertical") && Input.GetAxisRaw("Vertical") > 0 && selected != null)
            {
                selected.transform.localScale += new Vector3(0, 0, 0.1f);
            }
            else if (!Input.GetButtonUp("Vertical") && Input.GetAxisRaw("Vertical") < 0 && selected != null)
            {
                selected.transform.localScale += new Vector3(0, 0, -0.1f);
            }


            //Rotate y axis
            if (Input.GetButtonDown("Rotate") && Input.GetAxisRaw("Rotate") > 0 && selected != null)
            {
                //y += Time.deltaTime * rotationSpeed;
                y += 45;
                if (y > 360)
                {
                    y = 0;
                }
                if (selected != null)
                {

                    selected.transform.localRotation = Quaternion.Euler(0, y, 0);
                }
            }
            else if (Input.GetButtonDown("Rotate") && Input.GetAxisRaw("Rotate") < 0 && selected != null)
            {
                //y -= Time.deltaTime * rotationSpeed;
                y += -45;

                if (y < -360)
                {
                    y = 0;
                }
                if (selected != null)
                {

                    selected.transform.localRotation = Quaternion.Euler(0, y, 0);
                }
            }
            //if (selected != null)
            //{
            //    Debug.Log("right left");
            //    var move = new Vector3(Input.GetAxis("RightAndLeft"), Input.GetAxis("ForwardAndBack"), 0);
            //    //Debug.Log("Right and left = " + Input.GetAxis("RightAndLeft"));
            //    selected.transform.position += move * moveSpeed;
            //}
            if (Input.GetButtonDown("ForwardAndBack") && Input.GetAxisRaw("ForwardAndBack") > 0 && selected != null)
            {
                selected.transform.position += new Vector3(0, 0, 1f);
            }
            else if (Input.GetButtonDown("ForwardAndBack") && Input.GetAxisRaw("ForwardAndBack") < 0 && selected != null)
            {
                selected.transform.position += new Vector3(0, 0, -1f);
            }
            if (Input.GetButtonDown("RightAndLeft") && Input.GetAxisRaw("RightAndLeft") > 0 && selected != null)
            {
                selected.transform.position += new Vector3(1f, 0, 0);
            }
            else if (Input.GetButtonDown("RightAndLeft") && Input.GetAxisRaw("RightAndLeft") < 0 && selected != null)
            {
                selected.transform.position += new Vector3(-1f, 0, 0);
            }
        }
        else if (selected != null)
        {


            //stretch x axis
            if (!Input.GetButtonUp("Horizontal") && Input.GetAxisRaw("Horizontal") > 0 && selected != null)
            {
                selected.transform.localScale += new Vector3(0.1f, 0, 0);
            }
            else if (!Input.GetButtonUp("Horizontal") && Input.GetAxisRaw("Horizontal") < 0 && selected != null)
            {
                selected.transform.localScale += new Vector3(-0.1f, 0, 0);
            }
            //stretch y axis
            if (!Input.GetButtonUp("Vertical") && Input.GetAxisRaw("Vertical") > 0 && selected != null)
            {
                selected.transform.localScale += new Vector3(0, 0.1f, 0);
            }
            else if (!Input.GetButtonUp("Vertical") && Input.GetAxisRaw("Vertical") < 0 && selected != null)
            {
                selected.transform.localScale += new Vector3(0, -0.1f, 0);
            }


            //Rotate y axis
            if (Input.GetButtonDown("Rotate") && Input.GetAxisRaw("Rotate") > 0 && selected != null)
            {
                //y += Time.deltaTime * rotationSpeed;
                y += 45;
                if (y > 360)
                {
                    y = 0;
                }
                if (selected != null)
                {

                    selected.transform.localRotation = Quaternion.Euler(-90, y, 0);
                }
            }
            else if (Input.GetButtonDown("Rotate") && Input.GetAxisRaw("Rotate") < 0 && selected != null)
            {
                //y -= Time.deltaTime * rotationSpeed;
                y += -45;

                if (y < -360)
                {
                    y = 0;
                }
                if (selected != null)
                {

                    selected.transform.localRotation = Quaternion.Euler(-90, y, 0);
                }
            }
            //if (selected != null)
            //{
            //    Debug.Log("right left");
            //    var move = new Vector3(Input.GetAxis("RightAndLeft"), Input.GetAxis("ForwardAndBack"), 0);
            //    //Debug.Log("Right and left = " + Input.GetAxis("RightAndLeft"));
            //    selected.transform.position += move * moveSpeed;
            //}
            if (Input.GetButtonDown("ForwardAndBack") && Input.GetAxisRaw("ForwardAndBack") > 0 && selected != null)
            {
                selected.transform.position += new Vector3(0, 0, 1f);
            }
            else if (Input.GetButtonDown("ForwardAndBack") && Input.GetAxisRaw("ForwardAndBack") < 0 && selected != null)
            {
                selected.transform.position += new Vector3(0, 0, -1f);
            }
            if (Input.GetButtonDown("RightAndLeft") && Input.GetAxisRaw("RightAndLeft") > 0 && selected != null)
            {
                selected.transform.position += new Vector3(1f, 0, 0);
            }
            else if (Input.GetButtonDown("RightAndLeft") && Input.GetAxisRaw("RightAndLeft") < 0 && selected != null)
            {
                selected.transform.position += new Vector3(-1f, 0, 0);
            }
        }

    }
}
