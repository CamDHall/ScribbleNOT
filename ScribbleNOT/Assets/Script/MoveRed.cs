using UnityEngine;
using System.Collections;

public class MoveRed : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey("right"))
        {
            transform.Translate(2 * Vector3.right * Time.deltaTime);
        }
        if (Input.GetKey("left"))
        {
            transform.Translate(2 * -Vector3.right * Time.deltaTime);
        }
        if (Input.GetKey("up"))
        {
            transform.Translate(2 * Vector3.up * Time.deltaTime);
        }
        if (Input.GetKey("down"))
        {
            transform.Translate(2 * -Vector3.up * Time.deltaTime);
        }
    }
}
