using UnityEngine;
using System.Collections;

public class StartGameClass : MonoBehaviour {
	
	public Font scoreFont;
	
	// Use this for initialization
	void Start () {
		AtaulfoClass.Score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.anyKeyDown){
			Application.LoadLevel("Game");
		}
	}
	
	// Update GUI
	void OnGUI() {
		// Game name
		GUIStyle startStyle = new GUIStyle();
		startStyle.font = scoreFont;
		startStyle.fontSize = 68;
		startStyle.normal.textColor = Color.black;
		startStyle.alignment = TextAnchor.UpperCenter;
		
		GUI.Label(new Rect((float)Screen.width/2.0f - 50,10,100,20), "ATAULFO HEARTQUEST", startStyle);
	
		// Press any key
		startStyle.fontSize = 48;
		
		GUI.Label(new Rect((float)Screen.width/2.0f - 50,Screen.height-Random.Range(100, 102),100,20), "* PRESS ANY KEY *", startStyle);
	
		// Graphics
		startStyle.fontSize = 20;
		startStyle.alignment = TextAnchor.UpperRight;
		GUI.Label(new Rect(Screen.width-120,Screen.height-200,100,20), "* Baboon Painters *", startStyle);
		GUI.Label(new Rect(Screen.width-120,Screen.height-180,100,20), "lesswanted", startStyle);
		GUI.Label(new Rect(Screen.width-120,Screen.height-160,100,20), "pikolop", startStyle);
		
		GUI.Label(new Rect(Screen.width-120,Screen.height-120,100,20), "* Music Gorilla *", startStyle);
		GUI.Label(new Rect(Screen.width-120,Screen.height-100,100,20), "maulo", startStyle);
		//GUI.Label(new Rect(Screen.width-120,Screen.height-140,100,20), "Ataulfo", startStyle);
		
		// Graphics
		startStyle.fontSize = 20;
		startStyle.alignment = TextAnchor.UpperLeft;
		GUI.Label(new Rect(20,Screen.height-200,100,20), "* Code Monkeys *", startStyle);
		GUI.Label(new Rect(20,Screen.height-180,100,20), "octal0", startStyle);
		GUI.Label(new Rect(20,Screen.height-160,100,20), "leosamu", startStyle);
		GUI.Label(new Rect(20,Screen.height-140,100,20), "materod", startStyle);
	}
	
	
}
