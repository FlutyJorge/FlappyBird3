using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using TMPro; //UI���X�N���v�g�ő��삷�邽�߂ɕK�v�ȋ@�\

public class GManager : MonoBehaviour
{
    [HideInInspector] public int score = 0;
    [SerializeField] TextMeshProUGUI scoreTx;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //����class(PlayerController)�Ŏg�����߁Aprivate�ł͂Ȃ�public�ɂ��Ă���B
    public void ChangeScore()
    {
        //UI�ł���scoreText�̒l���ŐV�łɍX�V����B
        scoreTx.SetText("Score:" + score.ToString());
    }

}
