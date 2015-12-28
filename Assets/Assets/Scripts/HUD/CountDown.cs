using UnityEngine;
using System.Collections;

public class CountDown : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.GetComponent<GUIText>().text = "残り" + MainLoop.gameTime.ToString("N0") + "秒";
	}
}
