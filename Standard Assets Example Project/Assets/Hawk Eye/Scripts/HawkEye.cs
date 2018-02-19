using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// HawkEye のゲームに必要な要素を備えるスクリプト
/// rigidbodyが必須
/// </summary>
[RequireComponent(typeof(Rigidbody))]
public class HawkEye : MonoBehaviour {
    public bool GameStarted { get; private set; }  //ゲームが始まっているかどうか
    public bool StillAlive { get; private set; }         //この機体がまだ生きてるか
    public bool HeroOrNot { get; private set; }     //この機体がプレイヤーが操作する機体かどうか
    public float Speed { get; private set; }            //この機体のスピード
    public float Height { get; private set; }           //この機体の高度
    public float Durability { get; private set; }      //この機体の耐久値
    public int Score { get; set;  }                         // この機体が所持しているスコア
    public Time TimeLimit { get; private set; }     //活動可能時間

    private Rigidbody _rigitbody;
    private bool _rigitbodyExist;

    void Start () {
        _rigitbody = GetComponent<Rigidbody>();
        if (_rigitbody != null)
        {
            _rigitbodyExist = true;
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (!_rigitbodyExist) return;
        Height = (_rigitbody.transform.position.y * 10);
        Speed = (_rigitbody.velocity.magnitude * 10);
	}
}
