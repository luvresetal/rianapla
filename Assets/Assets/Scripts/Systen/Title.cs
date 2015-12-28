using UnityEngine;
using System.Collections;

public class Title : MonoBehaviour {
	//タイトル制御
	// Use this for initialization
	void Start () {
		//タイトル画面を出す
	
	}
	
	// Update is called once per frame
	void Update () {
		//画面タップでゲーム開始	
		// タップしたら、シーンを移動する
		if (Input.GetMouseButtonDown (0)) {
            Application.LoadLevel("main");
        }
	}
}
