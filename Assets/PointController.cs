using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointController : MonoBehaviour
{
    public Text scoreText;
    private int score;  //スコア計算用変数

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        SetScore();   //初期スコアを代入して表示
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        string yourTag = collision.gameObject.tag;

        if (yourTag == "SmallCloudTag")
        {
            score += 50;
        }
        else if (yourTag == "SmallStarTag")
        {
            score += 100;
        }
        else if (yourTag == "LargeCloudTag")
        {
            score += 150;
        }
        else if (yourTag == "LargeStarTag")
        {
            score += 200;
        }
        SetScore();
    }
    void SetScore()
    {
        scoreText.text = string.Format("Score:{0}", score);
    }
}
