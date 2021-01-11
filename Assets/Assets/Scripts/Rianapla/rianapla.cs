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

	void Start () {
		++MainLoop.number;
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

		if(!(this.GetComponent<Renderer>().isVisible))
		{
			
			//Destroy(this.gameObject);
		}
	}

	// 負荷を軽くするため、画面外に出たら消す(カウントは減らさない)
	void OnBecameInvisible()
	{

	}
	// タップして増殖
	public void OnTap()
	{
		SoundManager.normalSound = true;
		for (int i = 0; i < increment; ++i)
		{
			Instantiate(sibuki, this.gameObject.transform.position, Quaternion.identity);
		}
		--MainLoop.number;
		Destroy(this.gameObject);
	}
}
