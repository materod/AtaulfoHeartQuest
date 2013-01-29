using UnityEngine;
using System.Collections;

public class ParticleDestroyClass : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!this.gameObject.particleSystem.IsAlive())
        	Destroy(this.gameObject);
	}
}
