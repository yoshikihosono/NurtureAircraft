using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public int attackStatus;
    public int defenseStatus;
    public int speedStatus;
    // Start is called before the first frame update
    void Start()
    {
        attackStatus = 0;
        defenseStatus = 0;
        speedStatus = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AttackClick()
    {
        attackStatus += 10;
    }
    public void DefenseClick()
    {
        defenseStatus += 10;
    }
    public void SpeedClick()
    {
        speedStatus += 10;
    }
}
