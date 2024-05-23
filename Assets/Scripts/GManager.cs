using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using TMPro; //UIをスクリプトで操作するために必要な機能

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

    //他のclass(PlayerController)で使うため、privateではなくpublicにしている。
    public void ChangeScore()
    {
        //UIであるscoreTextの値を最新版に更新する。
        scoreTx.SetText("Score:" + score.ToString());
    }

}
