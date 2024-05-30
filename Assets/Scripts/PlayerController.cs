//using～と頭についている部分は、Unityが事前に準備してくれた道具。
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GManager gManager;
    private Rigidbody2D rb;
    [SerializeField] float jumpPower;

    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (this.gameObject.transform.position.y < -10)
        {
            Debug.Log("GameOver");
            gManager.SetResult();
            gManager.isEnd = true;
        }

        if (Input.GetMouseButtonDown(0) && !gManager.isEnd)
        {
            rb.velocity = Vector3.zero;
            rb.AddForce(Vector3.up * jumpPower, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Debug.Log("GameOver");
            gManager.SetResult();
            gManager.isEnd = true;
        }
    }

    //ポイント加算に使う関数
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //もし、接触したゲームオブジェクトがCheckPoint属性だったら
        if (collision.gameObject.tag == "CheckPoint")
        {
            //UIのスコア表示を更新する。
            gManager.ChangeScore();
            Debug.Log(gManager.score);
        }
    }
}
