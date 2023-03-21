using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    private int score = 0;
    private float time = 0f;
    [SerializeField]
    private TextMeshProUGUI textScore;


    void Start()
    {
        InvokeRepeating("IncreaseScore", 1.0f, 1.0f);
    }

    void Update()
    {
        textScore.text = "Score: " + score;
        Debug.Log("Score: " + score + " | Time: " + time);
    }

    void IncreaseScore()
    {
        score++;
        time++;
    }
}
