using UnityEngine;
using System.Collections;

public class Cells : MonoBehaviour {

    public GameObject whiteCell;
    private Vector3 cellPos;
    private float cellPosY = 5.73f;
    private float cellPosX = -8.7f;

    void Awake()
    {

        for (int i = 0; i < 80; i++)
        {
            if ((i+1) % 37 == 0)
            {
                cellPosY = 5.73f - (i+1 - 36) * .5f;
            }

            if (i >= 37 && i < 73)
            {
                cellPosX = (-8.7f + (i -(i-36) * .5f));
            }

            else
            {
                cellPosX = (-8.7f + (i * .5f));
            }

            cellPos = new Vector3(cellPosX, cellPosY, 0);
            Instantiate(whiteCell, cellPos, Quaternion.identity);
        }
        /* for (int i = 0; i < 333; i++)
        {
            if (i <= 36)
            cellPos = new Vector3((-8.7f + (i * .5f)), 5.73f, 0);
            Instantiate(whiteCell, cellPos, Quaternion.identity);
            if(i >= 37)
            {
                cellPos = new Vector3(-8.7f + ((i - 37) * .5f), 5.23f,0);
            }

            if (i >= 74)
            {
                cellPos = new Vector3(-8.7f + ((i - 74) * .5f), 4.73f, 0);
            }

            if (i >= 111)
            {
                cellPos = new Vector3(-8.7f + ((i - 111) * .5f), 4.23f, 0);
            }

            if (i >= 148)
            {
                cellPos = new Vector3(-8.7f + ((i - 148) * .5f), 3.73f, 0);
            }

            if (i >= 185)
            {
                cellPos = new Vector3(-8.7f + ((i - 185) * .5f), 2.73f, 0);
            }

            if (i >= 222)
            {
                cellPos = new Vector3(-8.7f + ((i - 222) * .5f), 2.23f, 0);
            }

            if (i >= 259)
            {
                cellPos = new Vector3(-8.7f + ((i - 259) * .5f), 1.73f, 0);
            }

            if (i >= 295)
            {
                cellPos = new Vector3(-8.7f + ((i - 295) * .5f), 1.23f, 0);
            }

            if (i >= 332)
            {
                cellPos = new Vector3(-8.7f + ((i - 332) * .5f), .73f, 0);
            }
        } */
    }

	void Start () {
	
	}
	
	void Update () {
	
	}
}
