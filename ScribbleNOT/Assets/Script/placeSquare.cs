using UnityEngine;
using System.Collections;

public class placeSquare : MonoBehaviour {
    public GameObject square;
    Vector3 placement = new Vector3 (-9, 6, 0);


    void Awake ()
    {
        for (int count2 = 0; count2 < 101; count2++)
        {
            for (int count = 0; count < 180; count++)
            {
                GameObject newSquare = Instantiate(square) as GameObject;
                placement = placement + new Vector3(.1f, 0, 0);
                newSquare.transform.position = placement;
                newSquare.transform.SetParent(this.transform);
            }
            placement = placement + new Vector3(-18, -.1f, 0);
        }
    }
	
	void Update ()
    { 

    }
}
