using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class total : MonoBehaviour {
    //合計スコア
    private int totalScore = 0;
    private int totalCounter = 0;
    public Text totalText;
    private bool goTitle = false;
    public GameObject tapTitle;
    private Vector3 position;

    // Use this for initialization
    void Start () {
        totalScore = count.getScore() + countHat.getBonus();
	}
	
	// Update is called once per frame
	void Update () {
        totalText.text = totalCounter.ToString();

        countUp();
        countUp();
        countUp();

        if (totalCounter == totalScore && goTitle == false)
        {
            Instantiate(tapTitle, position, Quaternion.identity);
            goTitle = true;
        }
    }
    void countUp()
    {
        if (totalCounter < totalScore)
        {
            ++totalCounter;
        }
    }
}
