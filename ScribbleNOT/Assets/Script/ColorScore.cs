using UnityEngine;
using System.Collections;

public class ColorScore : MonoBehaviour {

    public Color blue = new Color(0, 0, 1, 1);
    public Color red = new Color(1, 0, 0, 1);

	void Start () {

	}
	
	void Update () {
	
	}

    void OnTriggerEnter2D (Collider2D coll)
    {
            if (coll.gameObject.tag == "RedPen" && this.gameObject.GetComponent<SpriteRenderer>().color != Color.red)
            {
                 if (Input.GetKey("space"))
                {
                    if (this.gameObject.GetComponent<SpriteRenderer>().color == Color.blue)
                    {
                        TotalScore.scoreBlue--;
                    }
                this.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
                TotalScore.scoreRed++;
                }
            }
            if (coll.gameObject.tag == "BluePen" && this.gameObject.GetComponent<SpriteRenderer>().color != Color.blue)
            {
                if (Input.GetKey("left shift"))
                    {

                        if (this.gameObject.GetComponent<SpriteRenderer>().color == Color.red)
                            {
                            TotalScore.scoreRed--;
                            }
                        this.gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
                        TotalScore.scoreBlue++;
                     }
            }
    }
}
