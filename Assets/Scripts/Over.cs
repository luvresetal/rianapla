using UnityEngine;
using System.Collections;

public class Over : MonoBehaviour {
	public GameObject Gui;
	public GameObject Title;
	
	// Use this for initialization
	void Start () {
		MoveRianapla.playing = false;
	}
	
	// Update is called once per frame
	void Update () {
		//ランキング実装は難しいので今回はなし
		//タップしたらタイトルへ
		// タッチ情報を取得する
		for (int i = 0; i < Input.touchCount; i++) {
			Touch touch = Input.GetTouch (i);
		
			// ゲーム中ではなく、タッチ直後であればtrueを返す。
			if (touch.phase == TouchPhase.Began) {
				Debug.Log("tap");
				Destroy(Gui);
				Instantiate(Title);
				MoveRianapla.clear = true;
			}
		}
		// ゲーム中ではなく、マウスクリックされたらtrueを返す。
		if(Input.GetMouseButtonDown (0)) {
			Destroy(Gui);
			Instantiate(Title);
			MoveRianapla.clear = true;
		}
	}
}
