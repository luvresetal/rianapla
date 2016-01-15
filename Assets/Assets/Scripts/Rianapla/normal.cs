using UnityEngine;
using System.Collections;

public class normal : MonoBehaviour {
    //ふつうプラ独自の動作
    //というかつぶされたときの悲鳴だけ
    //ゲーム的にもキャラの個性付けのためにもそれぞれ違う音声をつけるかも
    //現状はぼうしプラとでかプラにも同じ音声をかける
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void onDestroy()
    {
        Debug.Log("ssss");
        
    }
}
