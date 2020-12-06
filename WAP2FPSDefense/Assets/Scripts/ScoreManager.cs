﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public int coin;

    public Text scoreText;
    public Text coinText;

    void Start()
    {
        score = 0;
        coin = 0;
    }

    void Update()
    {
        scoreText.text = "Score: " + score;
        coinText.text = "Coin: " + coin;

    }
}
