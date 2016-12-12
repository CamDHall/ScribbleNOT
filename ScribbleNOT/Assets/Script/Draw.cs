using UnityEngine;
using System.Collections;

public class Draw : MonoBehaviour {

    public Mesh redMesh;
    public Mesh blueMesh;

    public Material redMat;
    public Material blueMat;

    void Start () {
        RedDraw();
	}
	
	void Update () {
        Graphics.DrawMesh(redMesh, Vector3.zero, Quaternion.identity, redMat, 0);
    }

    void RedDraw()
    {
        Graphics.DrawMesh(redMesh, Vector3.zero, Quaternion.identity, redMat, 0);
    }

    void BlueDraw()
    {

    }


}
