using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    private int score = 0;
    private float time = 0f;

    void Start()
    {
        InvokeRepeating("IncreaseScore", 1.0f, 1.0f);
    }

    void Update()
    {
        Debug.Log("Score: " + score + " | Time: " + time);
    }

    void IncreaseScore()
    {
        score++;
        time++;
    }
}
