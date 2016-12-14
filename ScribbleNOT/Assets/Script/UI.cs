using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI : MonoBehaviour {

    public GameObject redPen;
    public GameObject bluePen;

    public string Winner;
    public Text Win, redScore, blueScore;

    Vector3 blueScale;
    Vector3 redScale;

    float scaleX, scaleY;
    void Start()
    {
        blueScale = bluePen.GetComponent<SpriteRenderer>().transform.localScale;
        redScale = redPen.GetComponent<SpriteRenderer>().transform.localScale;

        scaleX += .25f;
        scaleY += .25f;
    }

    void Update()
    {
        Win.text = Winner;
        redScore.text = TotalScore.scoreRed.ToString();
        blueScore.text = TotalScore.scoreBlue.ToString();


        if (TotalScore.scoreBlue > TotalScore.scoreRed)
        {
            Winner = "Blue";
            bluePen.GetComponent<SpriteRenderer>().transform.localScale = new Vector3(scaleX, scaleY, blueScale.z);
        }

        else if (TotalScore.scoreRed > TotalScore.scoreBlue)
        {
            Winner = "Red";
            redPen.GetComponent<SpriteRenderer>().transform.localScale = new Vector3(scaleX, scaleY * 1.1f, redScale.z);
        }

        else
        {
            Winner = "TIE";
        }
    }
}
