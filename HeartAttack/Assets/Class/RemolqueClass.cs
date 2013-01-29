using UnityEngine;
using System.Collections;

public class RemolqueClass : MonoBehaviour {
	
	public AtaulfoClass Ataulfo;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var dist =Ataulfo.transform.localPosition.x-this.transform.localPosition.x;
	//this.transform.rotation=Ataulfo.transform.rotation;	
		if (this.transform.position.x<1.8f && this.transform.position.x>-1.8)
			transform.RotateAround (new Vector3(0,-2.1f,0), Vector3.forward, 20*dist * Time.deltaTime);
		
	//this.transform.position.y=Ataulfo.transform.position.y;
	//this.transform.localRotation=Ataulfo.transform.localRotation;
	}
}
