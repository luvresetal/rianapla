using UnityEngine;
using System.Collections;

public class CountNumber : MonoBehaviour {
    //ゲーム中のリアナプラの数
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		this.GetComponent<GUIText>().text = MainLoop.number.ToString() + "匹";
	}
}
