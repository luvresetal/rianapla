using UnityEngine;
using System.Collections;

public class hat : MonoBehaviour {

    //ぼうしブラ
    //ゲーム終了時にいた分だけボーナスがつく
    //ここではぼうしプラのカウント増減のみ
    //あとはリザルトで。

	// Use this for initialization
	void Start () {
        ++MainLoop.hatNumber;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void onDestroy ()
    {
        --MainLoop.hatNumber;
        Debug.Log(MainLoop.hatNumber);
    }
}
