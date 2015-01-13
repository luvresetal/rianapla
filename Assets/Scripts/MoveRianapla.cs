using UnityEngine;
using System.Collections;

public class MoveRianapla : MonoBehaviour {
	//リアナプラの移動と分裂
	Vector2 move;
	int duplicate = 3;
	int time = 0;
	
	public static bool clear;
	public static bool playing;

	public GameObject me;
	public GameObject sibuki;
	
	// Use this for initialization
	void Start () {
		++MainLoop.number;
	}
	
	// Update is called once per frame
	void Update () {
		//移動はランダムで　ゆっくり目な感じで？;
		if(time >= 1){
			--time;
		}
		else{
			Vector2 reset = new Vector2(0,0);
			rigidbody2D.velocity = reset;
			time = Random.Range(1,10);
			move.x = Random.Range(-5,6);
			move.y = Random.Range(-7,8);
			rigidbody2D.velocity = move * 0.1f;
		}

		//タッチ(クリック)で分裂する
		//Debug.Log(Input.touchCount);
		if (Input.GetMouseButtonDown(0) && playing == true) {
			
			Vector2    aTapPoint   = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Collider2D aCollider2d = Physics2D.OverlapPoint(aTapPoint);
			
			if (aCollider2d) {
				GameObject obj = aCollider2d.transform.gameObject;
				Vector3 position = obj.transform.position;
				Destroy(obj);
				SoundManager.soundFlag = true;
				for(int i = 0;i < duplicate; ++i){
					Instantiate(sibuki, position, Quaternion.identity);
				}
				--MainLoop.number;
			}
		}
		if(clear == true){
			Destroy(me);
		}
	}
}