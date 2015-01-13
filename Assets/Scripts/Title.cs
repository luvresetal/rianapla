using UnityEngine;
using System.Collections;

public class Title : MonoBehaviour {
	//タイトル制御
	public GameObject Logo;
	public GameObject Loop;
	// Use this for initialization
	void Start () {
		//タイトル画面を出す
	
	}
	
	// Update is called once per frame
	void Update () {
		//画面タップでゲーム開始
		for (int i = 0; i < Input.touchCount; i++) {
			
			// タッチ情報を取得する
			Touch touch = Input.GetTouch (i);
			
			// ゲーム中ではなく、タッチ直後であればtrueを返す。
			if (touch.phase == TouchPhase.Began) {
				//GameStart ();
				Debug.Log("tap");
				Destroy(Logo);
				Instantiate(Loop);
			}
		}
		
		// ゲーム中ではなく、マウスクリックされたらtrueを返す。
		if (Input.GetMouseButtonDown (0)) {
			Destroy(Logo);
			Instantiate(Loop);
		}
		//ゲームのカウントダウンまでやる？
	
	}
}
