using UnityEngine;
using System.Collections;

public class Over : MonoBehaviour {
    //リザルト画面
    //１Time Overと出す
    //２ノーマルのカウント
    //３帽子のカウント

    public GameObject nextCount;

    // Use this for initialization
    void Start () {
        StartCoroutine(wait());
	}

    //１秒待ってノーマルのカウント
    IEnumerator wait()
    {
        Vector3 position = transform.position;
        yield return new WaitForSeconds(1);
        Instantiate(nextCount, position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
