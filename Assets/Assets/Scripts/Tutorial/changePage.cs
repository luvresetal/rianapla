using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class changePage : MonoBehaviour {
    //チュートリアルでのページ切り替え
    public int distance;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void OnClick ()
    {
        //遷移先のページはswitch文で分岐
        switch (distance)
        {
            case 0 : SceneManager.LoadScene("tutorial"); break;
            case 1 : SceneManager.LoadScene("chara1"); break;
            case 2 : SceneManager.LoadScene("chara2"); break;
            case 3 : SceneManager.LoadScene("chara3"); break;
            default: break;
        }
       
    }
}
