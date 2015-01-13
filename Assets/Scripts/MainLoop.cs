using UnityEngine;
using System.Collections;

public class MainLoop : MonoBehaviour {
	//ゲームの制御
	public static int number = 0;
	public static float gameTime;
	public GameObject first;
	public GameObject Loop;
	public GameObject GuiOver;
	// Use this for initialization
	void Start () {
		gameTime = 60.0f;
		number = 0;
		Instantiate(first);
		MoveRianapla.playing = true;
		MoveRianapla.clear = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(gameTime >= 0){
			gameTime -= Time.deltaTime;
		}
		else if(MoveRianapla.playing == true){
			Instantiate(GuiOver);
		}
		if(MoveRianapla.clear == true){
			Destroy(Loop);
		}
	}
}
