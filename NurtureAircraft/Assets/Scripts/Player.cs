using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [System.Serializable]
    public class Bounds
    {
        public float xMin, xMax, yMin, yMax;
    }
    [SerializeField] Bounds bounds;
    //public float xMin, xMax, yMin, yMax;

    [SerializeField, Range(0f, 1f)]
    private float followStrength;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 touchScreenPosition = Input.mousePosition;
        //var targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //targetPos.x = Mathf.Clamp(targetPos.x, bounds.xMin, bounds.xMax);
        //touchScreenPosition.x = Mathf.Clamp(touchScreenPosition.x, bounds.xMin, bounds.xMax);
        //targetPos.y = Mathf.Clamp(targetPos.y, bounds.yMin, bounds.yMax);
        //touchScreenPosition.y = Mathf.Clamp(touchScreenPosition.y, bounds.yMin, bounds.yMax);


        touchScreenPosition.z = 10f;
        Camera gameCamera = Camera.main;
        Vector3 touchWorldPos = gameCamera.ScreenToWorldPoint(touchScreenPosition);

        //targetPos.z = 0f;

        if (Input.GetMouseButton(0))
        transform.position = Vector3.Lerp(transform.position, touchWorldPos, followStrength);
    }
}
