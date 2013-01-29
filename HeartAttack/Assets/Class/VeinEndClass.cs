using UnityEngine;
using System.Collections;

public class VeinEndClass : MonoBehaviour {
	
	public AtaulfoClass Ataulfo;
	private float _timer=6;
	private float _timeto=0;
	private int _acction=2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float offset = Ataulfo.Speed * Time.time * 0.1f;
    	this.gameObject.renderer.material.SetTextureOffset ("_MainTex", new Vector2(0.0f, -offset));
		this.gameObject.renderer.material.SetTextureOffset ("_BumpMap", new Vector2(0.0f, -offset));


		_timeto += Time.deltaTime;

		if (_timeto > _timer)
		{
			_timeto=0;
			_timer=Random.Range(1,5);
			_acction=(int)Random.Range(0,3);
		}
		
		if(_acction==0)
				transform.RotateAround (new Vector3(0,-2.15f,25), Vector3.forward, 40 * Time.deltaTime);
		
		if(_acction==1)
				transform.RotateAround (new Vector3(0,-2.15f,25), Vector3.forward, -40 * Time.deltaTime);		
	}
}
