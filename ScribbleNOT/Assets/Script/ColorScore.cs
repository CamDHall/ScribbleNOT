using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ColorScore : MonoBehaviour {

    public Color blue = new Color(0, 0, 1, 1);
    public Color red = new Color(1, 0, 0, 1);

    public GameObject redPen;
    public GameObject bluePen;

    public string Winner;
    public Text Win;

	void Start () {

	}
	
	void Update () {
        Win.text = Winner;

        if (TotalScore.scoreBlue > TotalScore.scoreRed)
        {
            var blueScale = bluePen.GetComponent<SpriteRenderer>().transform.localScale;
            Winner = "Blue";
            bluePen.GetComponent<SpriteRenderer>().transform.localScale = new Vector3(blueScale.x * 2, blueScale.y, blueScale.z);
        }

        else if (TotalScore.scoreRed > TotalScore.scoreBlue)
        {
            var redScale = redPen.GetComponent<SpriteRenderer>().transform.localScale;
            Winner = "Red";
            redPen.GetComponent<SpriteRenderer>().transform.localScale = new Vector3(redScale.x * 2, redScale.y, redScale.z);
        }

        else
        {
            Winner = "TIE";
        }
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
