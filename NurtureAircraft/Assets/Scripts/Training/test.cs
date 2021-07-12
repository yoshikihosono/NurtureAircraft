using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public int speed;
    public int attack;
    public int defence;

    // Start is called before the first frame update
    void Start()
    {
        speed       = PlayerPrefs.GetInt("SPEED",0);
        attack      = PlayerPrefs.GetInt("ATTACK",0);
        defence     = PlayerPrefs.GetInt("DEFENSE",0);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0, 0, speed);
        Debug.Log(speed);
        Debug.Log(attack);
        Debug.Log(defence);
    }
}
