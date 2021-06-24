using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Turn : MonoBehaviour
{
    public GameObject turn; //ターンのテキストボックス用変数
    private Text turnText;  //ターン表示用変数

    private int i;
    // Start is called before the first frame update
    void Start()
    {
        turnText = turn.GetComponent<Text>();
        i = 4;
    }

    // Update is called once per frame
    void Update()
    {
        //ターン表示
        turnText.text = "あと"+i.ToString()+"ターン";
    }
}
