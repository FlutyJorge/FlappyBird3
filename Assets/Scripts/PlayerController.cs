//using～と頭についている部分は、Unityが事前に準備してくれた道具。
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//classとは、設計図のこと。この設計図をゲームオブジェクトに結びつけることで機能を有効化する。
public class PlayerController : MonoBehaviour
{
    //自前で用意する道具。パラメーターや他のclassを用いたいのであれば、ここで用意する。
    [SerializeField] GManager gManager;
    private Rigidbody2D rb;
    [SerializeField] float jumpPower;

    //Start関数は、ゲーム開始直後の1フレームだけ呼ばれる関数(命令パッケージ)。
    void Start()
    {
        //rb(用意した空箱)に物理法則機能の実態を代入。
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    //1フレーム毎に1回呼ばれる関数
    void Update()
    {
        //もし、マウスの左がクリックされたら
        if (Input.GetMouseButtonDown(0))
        {
            //プレイヤーの速度を0にする。
            rb.velocity = Vector3.zero;
            //上方向に一瞬だけ力(jumpPowerで調節可能)を加える
            rb.AddForce(Vector3.up * jumpPower, ForceMode2D.Impulse);
        }
    }

    //ゲームオーバー判定に使う関数
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //もし、衝突したゲームオブジェクトがWall属性だったら
        if (collision.gameObject.tag == "Wall")
        {
            Debug.Log("GameOver");
        }
    }

    //ポイント加算に使う関数
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //もし、接触したゲームオブジェクトがCheckPoint属性だったら
        if (collision.gameObject.tag == "CheckPoint")
        {
            //gManagerのスコアを＋1する。
            ++gManager.score;
            //UIのスコア表示を更新する。
            gManager.ChangeScore();
            Debug.Log(gManager.score);
        }
    }
}
