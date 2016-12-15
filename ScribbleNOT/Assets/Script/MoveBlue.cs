using UnityEngine;
using System.Collections;

public class MoveBlue : MonoBehaviour {

    float speed = 3.5f;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey("d"))
        {
            transform.Translate(speed*Vector3.right * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(speed*-Vector3.right * Time.deltaTime);
        }
        if (Input.GetKey("w"))
        {
            transform.Translate(speed*Vector3.up * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(speed*-Vector3.up * Time.deltaTime);
        }
        if (Input.GetKeyDown("left shift"))
        {
            speed = 2.5f;
        }
        if (Input.GetKeyUp("left shift"))
        {
            speed = 3.5f;
        }
    }
}
