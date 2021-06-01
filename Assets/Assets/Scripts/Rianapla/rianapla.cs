using UnityEngine;
using System.Collections;

public class rianapla : MonoBehaviour {
	//リアナプラの動きと分裂

	//リアナプラの動き方
	public float speed = 0.1f;
	int time = 0;
	Vector2 moving;

	//分裂
	public GameObject sibuki;
	public int increment = 3;

	bool isTap;

	void Start () {
		++MainLoop.number;

		isTap = false;
	}
	
	// Update is called once per frame
	void Update () {
		// 移動はランダムで　ゆっくり目な感じで
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
	}

	// 負荷を軽くするため、画面外に出たら消す(カウントは減らさない)
	void OnTriggerExit2D(Collider2D other)
	{
		if (!isTap)
		{
			Debug.Log("out");
			Destroy(this.gameObject);
		}
	}

	// タップして増殖
	public void OnTap()
	{
		Debug.Log("tap");
		SoundManager.normalSound = true;
		for (int i = 0; i < increment; ++i)
		{
			Instantiate(sibuki, this.gameObject.transform.position, Quaternion.identity);
		}
		--MainLoop.number;
		isTap = true;
		Destroy(this.gameObject);
		
	}
}
