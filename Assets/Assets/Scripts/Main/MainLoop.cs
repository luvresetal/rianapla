using UnityEngine;
using System.Collections;
using System.Globalization;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainLoop : MonoBehaviour {
	//ゲームの制御
	public static int number = 0;
    public static int hatNumber = 0;
	public static float gameTime;
	public GameObject first;
	public GameObject Loop;
	public GameObject GuiOver;

	GameObject NumberUI;
	GameObject TimeUI;
	Text NumberText;

	// Use this for initialization
	void Start () {
		gameTime = 60.0f;
		number = 0;
		Instantiate(first);

		NumberUI = GameObject.Find("Number");
		NumberText = NumberUI.GetComponent<Text>();
		Debug.Log(NumberText);
	}
	
	// Update is called once per frame
	void Update () {
        //時間が0になったらゲーム終了
		if(gameTime >= 0){
			gameTime -= Time.deltaTime;
		}
        else
        {
			//  Application.LoadLevel("result");
			SceneManager.LoadScene("result");

		}

		NumberText.text = number.ToString() + "匹";
	}

    public static int getnumber()
    {
        return number;
    }
}
