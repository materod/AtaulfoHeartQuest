using UnityEngine;
using System.Collections;

public class ObstacleClass : MonoBehaviour {
	
	private static float ZPosToDestroy = -15.0f;
	public AtaulfoClass Ataulfo;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		float fSpeed = Ataulfo.Speed;
		transform.Translate( new Vector3(0f, 0f, -fSpeed*Time.deltaTime) );
		if (transform.position.z < ZPosToDestroy) {
			
			Destroy(this.gameObject);
		}
	
	}
	
	void OnTriggerEnter(Collider obj) {
	if (obj.gameObject.name == "Ataulfo") {
			ActionCollide();
		}
	}
	
	protected virtual void ActionCollide()
	{
	}
	
	protected virtual void BulletCollide()
	{
	}
}
