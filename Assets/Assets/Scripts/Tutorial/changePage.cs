using UnityEngine;
using System.Collections;

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
        Debug.Log("aaaa");
        //遷移先のページはswitch文で分岐
        switch (distance)
        {
            case 0 : Application.LoadLevel("tutorial"); break;
            case 1 : Application.LoadLevel("chara1"); break;
            case 2 : Application.LoadLevel("chara2"); break;
            case 3 : Application.LoadLevel("chara3"); break;
            default: break;
        }
       
    }
}
