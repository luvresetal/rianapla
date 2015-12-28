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
	public int increment = 1;

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
			GetComponent<Rigidbody2D>().velocity = reset;
			time = Random.Range(1,10);
			moving.x = Random.Range(-5,6);
			moving.y = Random.Range(-7,8);
			GetComponent<Rigidbody2D>().velocity = moving * speed;
		}

		//分裂
		if (Input.GetMouseButtonDown(0)) {

		}
	}

	void OnMouseDown(){
		Vector2    aTapPoint   = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Collider2D aCollider2d = Physics2D.OverlapPoint(aTapPoint);
		
		if (aCollider2d) {
			GameObject obj = aCollider2d.transform.gameObject;
			Vector3 position = obj.transform.position;
			Destroy(obj);
			//	SoundManager.soundFlag = true;
			for(int i = 0;i < increment; ++i){
				Instantiate(sibuki, position, Quaternion.identity);
			}
			--MainLoop.number;
		}
	}
}
