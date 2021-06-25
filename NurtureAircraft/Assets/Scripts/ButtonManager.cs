using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public int attackStatus;
    public int defenseStatus;
    public int speedStatus;


    public GameObject turnText;     //ターン表示用テキストボックス

    Turn turnScript;                //ターン表示スクリプト用変数

    // Start is called before the first frame update
    void Start()
    {
        attackStatus    = 0;
        defenseStatus   = 0;
        speedStatus     = 0;

        //ターン表示スクリプトの取得
        turnScript = turnText.GetComponent<Turn>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AttackClick()
    {
        //ターンを減らす関数呼び出し
        turnScript.TurnCountDown();

        //ステータス値を増やす
        attackStatus += 10;
    }


    public void DefenseClick()
    {
        //ターンを減らす関数呼び出し
        turnScript.TurnCountDown();

        //ステータス値を増やす
        defenseStatus += 10;
    }


    public void SpeedClick()
    {
        //ターンを減らす関数呼び出し
        turnScript.TurnCountDown();

        //ステータス値を増やす
        speedStatus += 10;
    }
}
