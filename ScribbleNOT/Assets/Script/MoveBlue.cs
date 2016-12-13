using UnityEngine;
using System.Collections;

public class MoveBlue : MonoBehaviour {


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey("d"))
        {
            transform.Translate(2*Vector3.right * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(2*-Vector3.right * Time.deltaTime);
        }
        if (Input.GetKey("w"))
        {
            transform.Translate(2*Vector3.up * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(2*-Vector3.up * Time.deltaTime);
        }

    }
}
