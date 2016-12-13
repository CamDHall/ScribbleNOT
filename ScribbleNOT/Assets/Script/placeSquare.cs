using UnityEngine;
using System.Collections;

public class placeSquare : MonoBehaviour {
    float xPlace = -9f;
    float yPlace = 0f;
    public GameObject square;
    int count = 0;
    int count2 = 0;
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
            }
            placement = placement + new Vector3(-18, -.1f, 0);
        }
    }
	
	void Update ()
    { 

    }
}
