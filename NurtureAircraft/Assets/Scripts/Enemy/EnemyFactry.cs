using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactry : MonoBehaviour
{
    public GameObject Enemy1;
    public GameObject Enemy2;
    int coolTime = 0;
    public int customCoolTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        int enemyType;
        enemyType = Random.Range(0, 10000);
        float createY = this.gameObject.transform.position.y;
        Vector3 createPosition = new Vector3(Random.Range(-2.4f, 2.5f), createY, 0);
        coolTime--;

        if (coolTime < 0)
        {
            if (enemyType % 2 == 0)
            {
                Instantiate(Enemy1, createPosition, Quaternion.identity);
                coolTime = customCoolTime;
            }
            else
            {
                Instantiate(Enemy2, createPosition, Quaternion.identity);
                coolTime = customCoolTime;
            }
        }
    }
}
