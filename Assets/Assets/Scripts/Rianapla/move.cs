using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	//リアナプラの動き方
	public float speed = 0.1f;
	int time = 0;
	Vector2 moving;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//移動はランダムで　ゆっくり目な感じで？;
		if(time >= 1){
			--time;
		}
		else{
			Vector2 reset = new Vector2(0,0);
			GetComponent<Rigidbody2D>().velocity = reset;
			time = Random.Range(1,10);
			moving.x = Random.Range(-5,6);
			moving.y = Random.Range(-7,8);
			GetComponent<Rigidbody2D>().velocity = moving * speed;
		}
		Debug.Log (GetComponent<Rigidbody2D>());
	}
}
