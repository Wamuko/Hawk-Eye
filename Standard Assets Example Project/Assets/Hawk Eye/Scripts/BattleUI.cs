using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleUI : MonoBehaviour {
    [SerializeField] private Text m_speedTxt;
    [SerializeField] private Text m_heightTxt;
    [SerializeField] private Text m_scoreTxt;
    [SerializeField] private Text m_limitTimeTxt;
    [SerializeField] private HawkEye hawk;
    
	// Use this for initialization
	void Start () {
        hawk = GameObject.FindGameObjectWithTag("Player").GetComponent<HawkEye>();
        //m_speedTxt = GameObject.Find("Speed").GetComponent<Text>();
        //m_heightTxt = GameObject.Find("Height").GetComponent<Text>();
        //m_scoreTxt = GameObject.Find("Score").GetComponent<Text>();
        //m_limitTimeTxt = GameObject.Find("Time").GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        m_speedTxt.text = hawk.Speed.ToString("N0");
        m_heightTxt.text = hawk.Height.ToString("N0");
        m_scoreTxt.text = GameManager.Score.ToString();
        m_limitTimeTxt.text = GameManager.TimeLimit.ToString("N2");
        if (GameManager.GameFinished)
        {
            m_limitTimeTxt.text = "Time UP !!";
        }
    }

}
