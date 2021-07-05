using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove1 : MonoBehaviour
{
    public int cnt = 0;
    public int waitTime;
    public float moveSpeed;
    Vector2 velocity;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (cnt == waitTime)
        {
            velocity.y = -1;
        }

        if (cnt == waitTime + 10)
        {
            velocity.y = 0;
        }


        gameObject.transform.position += new Vector3(velocity.x * moveSpeed * Time.deltaTime, velocity.y * moveSpeed * Time.deltaTime, 0);
        cnt += 1;
    }
}
