using UnityEngine;
using System.Collections;

public class CameraClass : MonoBehaviour {
	
	public AtaulfoClass Ataulfo;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 vPosAtaulfo = Ataulfo.transform.position;
		vPosAtaulfo.z += 6;
		transform.LookAt(vPosAtaulfo);
	}
}