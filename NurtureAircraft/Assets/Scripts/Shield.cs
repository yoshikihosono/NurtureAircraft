using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    [SerializeField]
    private float HP;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(HP < 0)
        {
            Destroy(this.gameObject);
        }
    }

    public void AddDamage(int damage)
    {
        HP -= damage;
        Debug.Log("Shiled Hit");
    }
}
