using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackGround : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    private void FixedUpdate()
    {
        transform.position -= new Vector3(0, 0.1f, 0);

        if (GetComponent<RectTransform>().anchoredPosition.y < -1920)
        {
            GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 3839.9f);
        }
    }
}
