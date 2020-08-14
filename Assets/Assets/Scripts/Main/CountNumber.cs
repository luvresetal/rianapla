using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CountNumber : MonoBehaviour {
    //ゲーム中のリアナプラの数
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		this.GetComponent<Text>().text = MainLoop.number.ToString() + "匹";
	}
}