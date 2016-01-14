using UnityEngine;
using System.Collections;

public class goTutorial : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void OnClick()
    {
        // タップしたら、シーンを移動する
        Application.LoadLevel("tutorial");
    }
}
