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

    void OnClick ()
    {
        Debug.Log(distance);
        //遷移先のページはswitch文で分岐
        switch (distance)
        {
            case 0 : Application.LoadLevel("tutorial"); Debug.Log(distance);  break;
            case 1 : Application.LoadLevel("chara1"); Debug.Log(distance);  break;
            case 2 : Application.LoadLevel("chara2"); Debug.Log(distance);  break;
            case 3 : Application.LoadLevel("chara3"); Debug.Log(distance);  break;
            default: break;
        }
       
    }
}
