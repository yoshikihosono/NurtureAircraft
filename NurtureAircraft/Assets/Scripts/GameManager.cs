using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int clearTime;
    int Time;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Time += 1;

        if(Time >= clearTime)
        {
            SceneManager.LoadScene("ClearScene");
        }

        if(player.GetComponent<Player>().HP <= 0)
        {
            SceneManager.LoadScene("OverScene");
        }
    }
}
