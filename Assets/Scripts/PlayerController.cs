//using�`�Ɠ��ɂ��Ă��镔���́AUnity�����O�ɏ������Ă��ꂽ����B
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//class�Ƃ́A�݌v�}�̂��ƁB���̐݌v�}���Q�[���I�u�W�F�N�g�Ɍ��т��邱�Ƃŋ@�\��L��������B
public class PlayerController : MonoBehaviour
{
    //���O�ŗp�ӂ��铹��B�p�����[�^�[�⑼��class��p�������̂ł���΁A�����ŗp�ӂ���B
    [SerializeField] GManager gManager;
    private Rigidbody2D rb;
    [SerializeField] float jumpPower;

    //Start�֐��́A�Q�[���J�n�����1�t���[�������Ă΂��֐�(���߃p�b�P�[�W)�B
    void Start()
    {
        //rb(�p�ӂ�����)�ɕ����@���@�\�̎��Ԃ����B
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    //1�t���[������1��Ă΂��֐�
    void Update()
    {
        //�����A�}�E�X�̍����N���b�N���ꂽ��
        if (Input.GetMouseButtonDown(0))
        {
            //�v���C���[�̑��x��0�ɂ���B
            rb.velocity = Vector3.zero;
            //������Ɉ�u������(jumpPower�Œ��߉\)��������
            rb.AddForce(Vector3.up * jumpPower, ForceMode2D.Impulse);
        }
    }

    //�Q�[���I�[�o�[����Ɏg���֐�
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //�����A�Փ˂����Q�[���I�u�W�F�N�g��Wall������������
        if (collision.gameObject.tag == "Wall")
        {
            Debug.Log("GameOver");
        }
    }

    //�|�C���g���Z�Ɏg���֐�
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //�����A�ڐG�����Q�[���I�u�W�F�N�g��CheckPoint������������
        if (collision.gameObject.tag == "CheckPoint")
        {
            //gManager�̃X�R�A���{1����B
            ++gManager.score;
            //UI�̃X�R�A�\�����X�V����B
            gManager.ChangeScore();
            Debug.Log(gManager.score);
        }
    }
}
