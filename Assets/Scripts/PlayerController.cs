//using�`�Ɠ��ɂ��Ă��镔���́AUnity�����O�ɏ������Ă��ꂽ����B
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

    //�|�C���g���Z�Ɏg���֐�
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //�����A�ڐG�����Q�[���I�u�W�F�N�g��CheckPoint������������
        if (collision.gameObject.tag == "CheckPoint")
        {
            //UI�̃X�R�A�\�����X�V����B
            gManager.ChangeScore();
            Debug.Log(gManager.score);
        }
    }
}
