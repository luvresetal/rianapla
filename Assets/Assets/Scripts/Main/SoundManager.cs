using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {
    //ふつうプラ用
	public AudioSource voice1;
	public AudioSource voice2;
	public AudioSource voice3;
	public AudioSource voice4;
	public AudioSource voice5;
	public AudioSource voice6;

    public static bool normalSound;

    //よわよわプラ用
    public AudioSource weak;

    public static bool weakSound;

	// Use this for initialization
	void Start () {
		normalSound = false;
        weakSound = false;
	}
	
	// Update is called once per frame
	void Update () {
        //ふつうプラ用
        if (normalSound == true){
			int randamVoice;
			randamVoice = Random.Range(1,6);
			switch(randamVoice){
			case 1 : voice1.Play();
				break;
			case 2 : voice2.Play();
				break;
			case 3 : voice3.Play();
				break;
			case 4 : voice4.Play();
				break;
			case 5 : voice5.Play();
				break;
			case 6 : voice6.Play();
				break;
			default : voice1.Play();
				break;
			}
			normalSound = false;
		}

        //よわよわプラ用
        if(weakSound == true) {
            weak.Play();
            weakSound = false;
        }
    }
}
