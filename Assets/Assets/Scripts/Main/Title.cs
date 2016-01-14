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

	}

    public void OnClick()
    {
            // タップしたら、シーンを移動する
            Application.LoadLevel("main");
    }
}
