using UnityEngine;
using System.Collections;

public class PenNoise2 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
        }
        if (Input.GetKeyUp("space"))
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Stop();
        }
    }
}

