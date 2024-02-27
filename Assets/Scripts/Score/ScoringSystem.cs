using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public static ScoringSystem instance;

    public Text scoreText;
    int score = 0;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        scoreText.text = score.ToString() + " Points";
    }

    public void AddPoint()
    {
        score += 50;
        scoreText.text = score.ToString() + " Points";
    }

}
