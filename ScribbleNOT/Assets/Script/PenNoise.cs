using UnityEngine;
using System.Collections;

public class PenNoise : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown("left shift"))
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
        }
        if (Input.GetKeyUp("left shift"))
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Stop();
        }
    }
}
