using UnityEngine;
using System.Collections;

public class hat : rianapla {

    //ぼうしブラ
    //ゲーム終了時にいた分だけボーナスがつく
    //ここではぼうしプラのカウント増減のみ
    //あとはリザルトで。

    // Use this for initialization
    void Start () {
        ++MainLoop.hatNumber;
    }

    void Update()
    {
     
    }
}
