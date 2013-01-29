using UnityEngine;
using System.Collections;

public class AnimationSpeedClass : MonoBehaviour {
	
	public AtaulfoClass Ataulfo;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		foreach(AnimationState state in animation){
			state.speed = Ataulfo.Speed / OptionsClass.PedalSpeedFactor;
		}
	}
}
