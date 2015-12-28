using UnityEngine;
using System.Collections;

public class goTitle : MonoBehaviour {
    //結果発表し終わったのでタップでタイトルへ
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Application.LoadLevel("title");
        }
    }
}
