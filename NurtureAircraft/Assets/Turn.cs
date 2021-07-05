using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Turn : MonoBehaviour
{
    public GameObject turn; //ターンのテキストボックス用変数
    private Text turnText;  //ターン表示テキスト用変数

    private int turnCount;  //実際のターン数用変数
    // Start is called before the first frame update
    void Start()
    {
        turnText = turn.GetComponent<Text>();
        turnCount = 4;
    }

    // Update is called once per frame
    void Update()
    {
        //ターン表示
        turnText.text = turnCount.ToString();
    }

    //ターンを減らす関数
    public void TurnCountDown()
    {
        turnCount -= 1;

        if (turnCount < 0) turnCount = 0;
    }
}
