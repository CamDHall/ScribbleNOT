using UnityEngine;
using System.Collections;

public class BluePen : MonoBehaviour {

	public Shader blueShader;

	private static Material blueMat;
	private GameObject bluePen;
	private float speed = 100.0f;
	private Vector3[] lp;
	private Vector3[] sp;
	private Vector3 s;
	
	void Start () {
		
		blueMat = new Material(blueShader);
		bluePen = new GameObject("blueLine");
		lp = new Vector3[0];
		sp = new Vector3[0];
	}
	
	void Update() {
		
		if(Input.GetMouseButton(0)) {
			
			Vector3 e = GetNewPoint();
			
			if(s != Vector3.zero) {
				for(int i = 0; i < lp.Length; i += 2) {
					float d = Vector3.Distance(lp[i], e);
					if(d < 1 && Random.value > 0.9f) sp = AddLine(sp, lp[i], e, false);
				}
				
				lp = AddLine(lp, s, e, false);
			}
			
			s = e;
		} else {
			s = Vector3.zero;
		}
	}
	
	/** Replace the Update function with this one for a click&drag drawing option */
	void Update1() {
		
		Vector3 e;
		
		if(Input.GetMouseButtonDown(0)) {
			s = GetNewPoint();
		}
		
		if(Input.GetMouseButton(0)) {
			e = GetNewPoint();
			lp = AddLine(lp, s, e, true);
		}

		if(Input.GetMouseButtonUp(0)) {
			e = GetNewPoint();
			lp = AddLine(lp, s, e, false);
		}
	}
	
	Vector3[] AddLine(Vector3[] l, Vector3 s, Vector3 e, bool tmp) {
		int vl = l.Length;
		if(!tmp || vl == 0) l = resizeVertices(l, 2);
		else vl -= 2;
			
		l[vl] = s;
		l[vl+1] = e;
		return l;
	}
	
	Vector3[] resizeVertices(Vector3[] ovs, int ns) {
		Vector3[] nvs = new Vector3[ovs.Length + ns];
		for(int i = 0; i < ovs.Length; i++) nvs[i] = ovs[i];
		return nvs;
	}
	
	Vector3 GetNewPoint() {
       return bluePen.transform.InverseTransformPoint(
			Camera.main.ScreenToWorldPoint(
                new Vector3(this.transform.position.x, this.transform.position.y, -1)
			)
		);

        // return new Vector3(bluePen.transform.position.x, transform.position.y, -1);
	}

	void OnRenderObject() {
		blueMat.SetPass(0);
		GL.PushMatrix();
		GL.MultMatrix(bluePen.transform.transform.localToWorldMatrix);
		GL.Begin( GL.LINES );
		GL.Color( new Color(0,0,0,0.4f) );
		
		for(int i = 0; i < lp.Length; i++) {
			GL.Vertex3(lp[i].x, lp[i].y, lp[i].z);
		}
		
		GL.Color( new Color(0,0,0,0.1f) );
		
		for(int i = 0; i < sp.Length; i++) {
			GL.Vertex3(sp[i].x, sp[i].y, sp[i].z);
		}
		
		GL.End();
		GL.PopMatrix();
	} 
}
