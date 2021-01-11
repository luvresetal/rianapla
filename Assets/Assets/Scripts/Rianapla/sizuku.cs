using UnityEngine;
using System.Collections;

public class sizuku : MonoBehaviour {
	public GameObject sibuki;
	public GameObject normal;
	public GameObject eat;
	public GameObject hat;
	public GameObject weak;
	public GameObject big;
	public GameObject bomb;
	public int count = 0;
	int speed = 5;
	// Use this for initialization
	void Start () {
		//飛び散る方向はランダムで
		float angle_x = 0.0f;
		float angle_y = 0.0f;
		angle_x = Random.Range(-1.0f,1.0f);
		angle_y = Random.Range(-1.0f,1.0f);
		Vector2 angle = new Vector2(angle_x,angle_y).normalized;
		sibuki.transform.eulerAngles = angle;
		GetComponent<Rigidbody2D>().velocity = speed * angle;
	}

	// Update is called once per frame
	void Update () {
		if(count >= 0){
			--count;
		}
		//ランダムでいろいろなリアナプラを生成
        //確率はかなり適当
        //もぐもぐとばくはつは後回しにするので、ふつうを出す
		else{
			Vector3 position = this.transform.position;
			Destroy(sibuki);
			int ram = Random.Range(1,100);
            if (ram >= 1 && ram <= 60)
            {
                Instantiate(normal, position, Quaternion.identity);
            }
            else if (ram >= 61 && ram <= 70)
            {
                Instantiate(weak, position, Quaternion.identity);
            }
            else if (ram >= 71 && ram <= 78)
            {
                Instantiate(normal, position, Quaternion.identity);
                //Instantiate(eat, position, Quaternion.identity);
            }
            else if (ram >= 79 && ram <= 89)
            {
                Instantiate(big, position, Quaternion.identity);
            }
            else if (ram >= 90 && ram <= 94){
                Instantiate(normal, position, Quaternion.identity);
                //Instantiate(bomb, position, Quaternion.identity);
            }
            else
            {
                Instantiate(hat, position, Quaternion.identity);
            }

		}
	}
}
