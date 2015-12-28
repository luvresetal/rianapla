using UnityEngine;
using System.Collections;

public class MainLoop : MonoBehaviour {
	//ゲームの制御
	public static int number = 0;
    public static int hatNumber = 0;
	public static float gameTime;
	public GameObject first;
	public GameObject Loop;
	public GameObject GuiOver;
	// Use this for initialization
	void Start () {
		gameTime = 60.0f;
		number = 0;
		Instantiate(first);
	
	}
	
	// Update is called once per frame
	void Update () {
		if(gameTime >= 0){
			gameTime -= Time.deltaTime;
		}
        else
        {
            Application.LoadLevel("result");
        }

	}

    public static int getnumber()
    {
        return number;
    }
}
