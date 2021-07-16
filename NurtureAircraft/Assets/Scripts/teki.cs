using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class teki : MonoBehaviour
{
    int HP = 70;
    int Damage;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Damage = PlayerPrefs.GetInt("ATTACK", 10);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, -moveSpeed, 0f);

        if (HP < 0)
            Destroy(gameObject);

        if(this.gameObject.transform.position.y < -5)
        {
            Destroy(this.gameObject);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            HP -= Damage;
        }

        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Player>().AddDamage(10);
            Debug.Log("Hit");
            Destroy(this.gameObject);
        }

    }
}
