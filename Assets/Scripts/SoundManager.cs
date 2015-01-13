using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

	public AudioSource voice1;
	public AudioSource voice2;
	public AudioSource voice3;
	public AudioSource voice4;
	public AudioSource voice5;
	public AudioSource voice6;

	public static bool soundFlag;

	// Use this for initialization
	void Start () {
		soundFlag = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(soundFlag == true){
			int randamVoice;
			randamVoice = Random.Range(1,6);
			Debug.Log(randamVoice);
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
			soundFlag = false;
		}
	}
}
