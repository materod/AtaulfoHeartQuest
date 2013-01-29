using UnityEngine;
using System.Collections;

public class RankingClass : MonoBehaviour {
	
	public Font scoreFont;
	
	private string[] ScoreNames = {"Ataulfo", "Ataulfo", "Ataulfo", "Ataulfo", "Ataulfo", "Ataulfo"};
	private int[] HighScores = {999, 500, 400, 300, 200, 100};
	
	private float startTime = 0;

	// Update highscores
	void Start () {
		int score = (int) AtaulfoClass.Score;
		Application.ExternalCall("kongregate.stats.submit","Score", score);
		
		/*for(int i=0; i<HighScores.Length; i++)
		{
			if(AtaulfoClass.Score > HighScores[i])
			{
				ScoreNames[i] = AtaulfoClass.PlayerName;
				HighScores[i] = (int)AtaulfoClass.Score;
				break;
			}
		}*/
		
		startTime = Time.time;
		
		StartCoroutine(Sleep(2.0f));
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.anyKeyDown){
			Application.LoadLevel("GameStart");
		}
	}
	
	// Wait 1 second
	private IEnumerator Sleep(float delay)
	{
   		yield return new WaitForSeconds(delay);
	}
	
	// Update GUI
	void OnGUI() {
		
		// Ranking label
		GUIStyle rankingStyle = new GUIStyle();
		rankingStyle.font = scoreFont;
		rankingStyle.fontSize = 48;
		rankingStyle.normal.textColor = Color.white;
		rankingStyle.alignment = TextAnchor.UpperRight;
		
		GUI.Label(new Rect((float)Screen.width-120,Random.Range(10, 12),100,20), "ATAULFO HEARTBREAKERS", rankingStyle);		
		GUI.Label(new Rect((float)Screen.width-220,Random.Range(70, 72),100,20), "* CLUB BAND *", rankingStyle);
		
		GUI.Label(new Rect((float)Screen.width-220,Screen.height-380,100,20), "Score: "+(int)AtaulfoClass.Score, rankingStyle);
		
		// Score labels left
		/*GUIStyle scoreStyleLeft = new GUIStyle();
		scoreStyleLeft.font = scoreFont;
		scoreStyleLeft.fontSize = 48;
		scoreStyleLeft.normal.textColor = Color.white;
		scoreStyleLeft.alignment = TextAnchor.UpperRight;
		
		int iniPos = Screen.height-380;
		
		for(int i=0; i < ScoreNames.Length; i++)
		{
			GUI.Label(new Rect(Screen.width-120, iniPos + (i * 60),100,20), (i+1)+". "+ScoreNames[i]+".............................."+HighScores[i], scoreStyleLeft);
		}*/
	}
}
