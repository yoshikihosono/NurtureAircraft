using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHomingBullet : MonoBehaviour
{
    public GameObject player;
    public float moveSpeed;
    public float limitSpeed;
    private Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vector3 = player.gameObject.transform.position - this.gameObject.transform.position;
        rb.AddForce(vector3.normalized * moveSpeed);

       float speedXTemp = Mathf.Clamp(rb.velocity.x, -limitSpeed, limitSpeed);
       float speedYTemp = Mathf.Clamp(rb.velocity.y, -limitSpeed, limitSpeed);
       rb.velocity = new Vector3(speedXTemp, speedYTemp);
    }
}
