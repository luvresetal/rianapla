using UnityEngine;
using System.Collections;

public class CountNumber : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.guiText.text = MainLoop.number.ToString() + "匹";
	}
}
