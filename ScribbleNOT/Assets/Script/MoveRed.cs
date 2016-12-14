using UnityEngine;
using System.Collections;

public class MoveRed : MonoBehaviour {
    int speed = 2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey("right"))
        {
            transform.Translate(speed * Vector3.right * Time.deltaTime);
        }
        if (Input.GetKey("left"))
        {
            transform.Translate(speed * -Vector3.right * Time.deltaTime);
        }
        if (Input.GetKey("up"))
        {
            transform.Translate(speed * Vector3.up * Time.deltaTime);
        }
        if (Input.GetKey("down"))
        {
            transform.Translate(speed * -Vector3.up * Time.deltaTime);
        }
        if (Input.GetKeyDown("space"))
        {
            speed = 2;
        }
        if (Input.GetKeyUp("space"))
        {
            speed = 3;
        }
    }
}
