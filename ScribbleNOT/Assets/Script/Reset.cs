﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (Input.GetKeyDown("9"))
        {
            SceneManager.LoadScene("canvas");
        }
	}
}
