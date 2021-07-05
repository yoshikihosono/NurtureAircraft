using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class punicon : MonoBehaviour
{
    public GameObject InputSphere;
    public GameObject mouseSphere;
    private Vector3 inputMousePosition;
    private Vector3 mousePosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inputMousePosition.z = 1;
        InputSphere.transform.position = inputMousePosition;
        mousePosition.z = 1;
        mouseSphere.transform.position = mousePosition;

        if(Input.GetMouseButtonDown(0))
        {
            InputSphere.SetActive(true);
            mouseSphere.SetActive(true);
            //inputMousePosition = Input.mousePosition;
            inputMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        if(Input.GetMouseButton(0))
        {
            //mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        if (Input.GetMouseButtonUp(0))
        {
            InputSphere.SetActive(false);
            mouseSphere.SetActive(false);
        }
    }
}
