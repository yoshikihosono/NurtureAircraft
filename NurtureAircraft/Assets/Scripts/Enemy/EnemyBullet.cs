using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position -= new Vector3(0, 0.005f, 0);
        Destroy(this.gameObject, 5);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Player>().AddDamage(10);
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "Shield")
        {
            collision.gameObject.GetComponent<Shield>().AddDamage(10);
            Destroy(this.gameObject);
        }
    }
}
