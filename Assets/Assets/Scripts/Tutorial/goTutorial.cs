using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

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
		SceneManager.LoadScene("tutorial");
	}
}
