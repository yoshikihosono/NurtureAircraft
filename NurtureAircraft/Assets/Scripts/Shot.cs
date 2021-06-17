﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject bullet;
    private float count;
    public float cooltime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (count > cooltime)
        {
            Instantiate(bullet, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), Quaternion.identity);
            count = 0;
        }
        count += Time.deltaTime;
    }
}
