using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class count : MonoBehaviour {

    private int counterChara = 0;
    private int counterScore = 0;
    private int rianapla = 0;
    public static int score = 0;
    private bool onHat = false;
    public GameObject output;
    public Text number;
    Vector3 position;

    //mainシーンから増やした数を取得して表示させる
    // Use this for initialization
    void Start () {
        rianapla = MainLoop.getnumber();
        score = rianapla * 1;
        position = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        number.text = "× " + counterChara.ToString() + "匹 ＝ " + counterScore.ToString();
        if (counterChara < rianapla) {
            ++counterChara;
        }
        if(counterScore < score)
        {
            ++counterScore;
        }
        else if(onHat == false)
        {
            Instantiate(output, position, Quaternion.identity);
            onHat = true;
        }
    }

    public static int getScore()
    {
        return score;
    }
}
