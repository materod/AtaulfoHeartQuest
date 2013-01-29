using UnityEngine;
using System.Collections;

public class VeinClass : MonoBehaviour {
	
	public Font scoreFont;
	
	public AtaulfoClass Ataulfo;
	
	public GameObject[] collisionObjects;
	
	private float nextObstacle = 0.0f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
		// Update score
		AtaulfoClass.Score += Time.deltaTime * 10.0f;
		
		// Displace texture 
		float offset = Ataulfo.Speed * Time.time * 0.1f;
    	this.gameObject.renderer.material.SetTextureOffset ("_MainTex", new Vector2(0.0f, -offset));
		this.gameObject.renderer.material.SetTextureOffset ("_BumpMap", new Vector2(0.0f, -offset));
		
		// Creating fucking obstacles
		if (Time.time > nextObstacle) {
			// Compute next obstacle time
        	nextObstacle = Time.time + (Random.Range(OptionsClass.ObstacleRateMin, OptionsClass.ObstacleRateMax)/Ataulfo.Speed);
  
			// Instanciate object
			GameObject obstacle = (GameObject)Instantiate(collisionObjects[Random.Range(0, collisionObjects.Length)]);
			obstacle.transform.RotateAround (new Vector3(0,-2.1f,0), Vector3.forward, Random.Range(-OptionsClass.ObstacleAngleMax, OptionsClass.ObstacleAngleMax));
			
			// Set ataulfo
			ObstacleClass obstacleClass = (ObstacleClass) obstacle.GetComponent("ObstacleClass");
			obstacleClass.Ataulfo = Ataulfo;
		}
		
		// Update speed
		Ataulfo.Speed += Time.deltaTime * OptionsClass.AtaulfoAcceleration;
	}
	
	// Update GUI
	void OnGUI() {
		GUIStyle style = new GUIStyle();
		style.font = scoreFont;
		style.fontSize = 32;
		style.normal.textColor = Color.white;
		style.alignment = TextAnchor.UpperRight;
		GUI.Label(new Rect(Screen.width-110,10,100,20), ((int)AtaulfoClass.Score).ToString(), style);	
	}
}
