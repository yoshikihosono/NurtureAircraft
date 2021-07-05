using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class StatusManager : MonoBehaviour
{
    //ステータス
    public GameObject attackStatus; //テキストを入れる変数
    private Text attackText;        //ステータスのテキストボックス用変数
    private int attack = 0;         //ステータス表示用変数

    public GameObject defenseStatus;
    private Text defenseText;
    private int defense = 0;

    public GameObject speedStatus;
    private Text speedText;
    private int speed = 0;

    //スクリプトがアタッチされているオブジェクトを受け取る変数
    public GameObject Buttons;

    //スクリプトを受け取る変数
    ButtonManager buttonScript;

    // Start is called before the first frame update
    void Start()
    {
        //テキストボックスのコンポーネントを取得
        attackText = attackStatus.GetComponent<Text>();
        defenseText = defenseStatus.GetComponent<Text>();
        speedText = speedStatus.GetComponent<Text>();

        //スクリプトを取得
        buttonScript = Buttons.GetComponent<ButtonManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //ステータスを表示用変数に代入
        attack = buttonScript.attackStatus;
        attackText.text ="攻撃:"+ attack.ToString();

        defense = buttonScript.defenseStatus;
        defenseText.text = "防御:" + defense.ToString();

        speed = buttonScript.speedStatus;
        speedText.text = "速さ:" + speed.ToString();
    }
}
