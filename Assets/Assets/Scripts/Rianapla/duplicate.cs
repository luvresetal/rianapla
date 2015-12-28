using UnityEngine;
using System.Collections;

public class duplicate : MonoBehaviour {

	public GameObject sibuki;
	public int increment = 3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			Debug.Log("tap!");
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
}
