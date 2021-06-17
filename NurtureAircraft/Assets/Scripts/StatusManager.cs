using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class StatusManager : MonoBehaviour
{
    //ステータス
    public GameObject attackStatus; //テキストを入れる変数
    private Text attackText;        //ステータス表示用変数
    private int attack = 0;         //攻撃力ステータス

    public GameObject defenseStatus;
    private Text defenseText;
    private int defense = 0;

    public GameObject speedStatus;
    private Text speedText;
    private int speed = 0;

    //スクリプトがアタッチされているオブジェクトを受け取る変数
    public GameObject attackButton;
    public GameObject defenseButton;
    public GameObject speedButton;

    //スクリプトを受け取る変数
    ButtonManager attackButtonScript;
    ButtonManager defenseButtonScript;
    ButtonManager speedButtonScript;

    // Start is called before the first frame update
    void Start()
    {
        attackText = attackStatus.GetComponent<Text>();
        defenseText = defenseStatus.GetComponent<Text>();
        speedText = speedStatus.GetComponent<Text>();

        attackButtonScript = attackButton.GetComponent<ButtonManager>();
        defenseButtonScript = defenseButton.GetComponent<ButtonManager>();
        speedButtonScript = speedButton.GetComponent<ButtonManager>();
    }

    // Update is called once per frame
    void Update()
    {
        attack = attackButtonScript.attackStatus;
        attackText.text ="攻撃:"+ attack.ToString();

        defense = defenseButtonScript.defenseStatus;
        defenseText.text = "防御:" + defense.ToString();

        speed = speedButtonScript.speedStatus;
        speedText.text = "速さ:" + speed.ToString();
    }
}
