using UnityEngine;
using System.Collections;

public class ObstacleClass : MonoBehaviour {
	
	private static float ZPosToDestroy = -15.0f;
	public AtaulfoClass Ataulfo;
	public AudioClip sound;
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
			if (sound)								//in case the obstacle has an audio play it when collide with ataulfo
			{
				audio.clip=sound;
				audio.Play();
			}
		}
	}
	
	protected virtual void ActionCollide()
	{
	}
	
	protected virtual void BulletCollide()
	{
	}
}
