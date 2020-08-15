using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class goTitle : MonoBehaviour {
    //結果発表し終わったのでタップでタイトルへ
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
      
    }
    public void OnClick()
    {
        // タップしたら、シーンを移動する
        SceneManager.LoadScene("title");
    }
}
