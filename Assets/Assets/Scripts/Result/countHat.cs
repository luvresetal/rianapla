using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class countHat : MonoBehaviour {
    //リザルト画面でのぼうしプラのカウント
    //ぼうしプラ１匹につき１０点のボーナス
    private int counter = 0;
    private int hat = 0;
    public static int bonus = 0;
    private int counterScore = 0;
    private bool onScore = false;
    public GameObject total;
    public Text number;
    private Vector3 position;

    // Use this for initialization
    void Start () {
        hat = MainLoop.hatNumber;
        bonus = hat * 10;
        position = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        number.text = "× " + counter.ToString() + "匹 ＝ " + counterScore.ToString();
        if (counter < hat)
        {
            ++counter;
        }
      
            countUp();
            countUp();
            countUp();

        if (counterScore == bonus && onScore == false)
        {
            Instantiate(total, position, Quaternion.identity);
            onScore = true;
        }
    }
    void countUp()
    {
        if (counterScore < bonus)
        {
            ++counterScore;
        }
    }
    public static int getBonus()
    {
        return bonus;
    }
}
