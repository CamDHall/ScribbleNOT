using UnityEngine;
using System.Collections;

public class ColorScore : MonoBehaviour {

    public Color blue = new Color(0, 0, 255, 255);
    public Color red = new Color(255, 0, 0, 255);

	void Start () {

	}
	
	void Update () {
	
	}

    void OnTriggerEnter2D (Collider2D coll)
    {
        if (coll.gameObject.tag == "RedPen")
        {
            this.gameObject.GetComponent<SpriteRenderer>().material.color = red; 
        }

        if (coll.gameObject.tag == "BluePen")
        {
            this.gameObject.GetComponent<SpriteRenderer>().material.color = blue;
        }
    }
}
