using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;
using UnityEngine.SceneManagement;

public class GManager : MonoBehaviour
{
    [HideInInspector] public int score = 0;
    [SerializeField] TextMeshProUGUI scoreTx;
    [SerializeField] TextMeshProUGUI finalTx;
    [SerializeField] GameObject resultPannel;
    [HideInInspector] public bool isEnd = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScore()
    {
        ++score;
        scoreTx.SetText("Score:" + score.ToString());

        if (score == 10)
        {
            SetResult();
            isEnd = true;
        }
    }

    public void SetResult()
    {
        resultPannel.SetActive(true);
        finalTx.SetText("FinalScore" + score.ToString());
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
