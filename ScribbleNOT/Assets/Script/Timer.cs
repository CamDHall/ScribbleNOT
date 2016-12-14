using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
    float timer = 0;
	// Use this for initialization
	void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {
        timer = Time.time;
        if (timer >= 60)
        {
            SceneManager.LoadScene("ScoreScreen");
        }
	}
}
