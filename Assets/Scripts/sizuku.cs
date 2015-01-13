using UnityEngine;
using System.Collections;

public class sizuku : MonoBehaviour {
	public GameObject sibuki;
	public GameObject rianapla;
	int count = 10;
	// Use this for initialization
	void Start () {
		//飛び散る方向はランダムで
		int speed = 5;
		float angle_x,angle_y;
		angle_x = Random.Range(-1.0f,1.0f);
		angle_y = Random.Range(-1.0f,1.0f);
		Vector2 angle = new Vector2(angle_x,angle_y).normalized;
		sibuki.transform.eulerAngles = angle;
		rigidbody2D.velocity = speed * angle;
	}
	
	// Update is called once per frame
	void Update () {
		if(count >= 0){
			--count;
		}
		else{
			Vector3 position = this.transform.position;
			Destroy(sibuki);
			Instantiate(rianapla, position, Quaternion.identity);
		}
	}
}
