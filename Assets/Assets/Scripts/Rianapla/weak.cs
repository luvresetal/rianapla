using UnityEngine;
using System.Collections;

public class weak : MonoBehaviour {
    //よわよわプラ独自の動作
    //現状はつぶされたときの悲鳴音声だけ
    //分裂もしない

   
    public void OnTap()
    {
        Debug.Log("tap");
        SoundManager.weakSound = true;
        --MainLoop.number;
        Destroy(this.gameObject);
    }
}
