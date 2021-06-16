using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class PointManager : MonoBehaviour
{
    public GameObject attackPoint;
    private Text attackText;
    private int attack = 0;
    // Start is called before the first frame update
    void Start()
    {
        attackText = attackPoint.GetComponent<Text>();
        attack += 10;
    }

    // Update is called once per frame
    void Update()
    {
        attackText.text ="攻撃:"+ attack.ToString();
    }
}
