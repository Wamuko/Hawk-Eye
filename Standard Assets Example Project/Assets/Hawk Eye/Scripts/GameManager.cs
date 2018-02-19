using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    private static int score = 100;
    private static float timeLimit = 60f;
    private static bool gameFinished;

    public static int Score
    {
        get
        {
            return score;
        }

        set
        {
            score = value;
        }
    }

    public static float TimeLimit
    {
        get
        {
            return timeLimit;
        }

        set
        {
            timeLimit = Mathf.Clamp(value, 0, 1000f);
        }
    }

    public static bool GameFinished
    {
        get
        {
            return gameFinished;
        }

        set
        {
            gameFinished = value;
        }
    }

    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update () {
        TimeLimit -= Time.deltaTime;
        if (TimeLimit == 0) GameFinished = true;
	}
    
}
