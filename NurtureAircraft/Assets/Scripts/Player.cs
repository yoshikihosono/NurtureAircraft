using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [System.Serializable]
    public class Bounds
    {
        public float xMin, xMax, yMin, yMax;
    }
    [SerializeField] Bounds bounds;

    public int moveSpeed;

    [SerializeField]
    private float movementX, movementY;
    Vector3 touchScreenPosition;
    Vector3 inputMousePosition;

    Vector3 targetPos;

    public float HP;

    // Start is called before the first frame update
    void Start()
    {
        HP = PlayerPrefs.GetInt("DEFENSE", 1);
        moveSpeed = PlayerPrefs.GetInt("SPEED", 0);
    }

    // Update is called once per frame
    void Update()
    {
        /*移動制限*/
        targetPos = transform.position;
        targetPos.x = Mathf.Clamp(transform.position.x, bounds.xMin, bounds.xMax);
        targetPos.y = Mathf.Clamp(transform.position.y, bounds.yMin, bounds.yMax);
        transform.position = targetPos;
        /*移動制限*/

        //マウス座標の取得
        touchScreenPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //Z値は常に10に
        touchScreenPosition.z = 10f;

        //マウスが押された瞬間のマウスの座標を取得
        if (Input.GetMouseButtonDown(0))
        {
            inputMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        //押された瞬間の座標と現在のマウスの座標を比較してどっち方向にいどうするかを求める
        movementX = touchScreenPosition.x - inputMousePosition.x;
        movementY = touchScreenPosition.y - inputMousePosition.y;

        //移動量は1以上にならないように
        movementX = Mathf.Clamp(movementX, -1, 1);
        movementY = Mathf.Clamp(movementY, -1, 1);

        //押されている間は移動します
        if (Input.GetMouseButton(0))
        {
            transform.position += new Vector3(moveSpeed * movementX * 0.001f, moveSpeed * movementY * 0.001f, 0);
        }

        //HPが０になったら
        if(HP <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    //ダメージ処理
    public void AddDamage(int damage)
    {
        HP -= damage;
    }
}
