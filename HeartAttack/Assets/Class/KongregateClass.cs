using UnityEngine;
using System.Collections;

public class KongregateClass : MonoBehaviour {
	
    static KongregateClass instance;
	
	private static bool IsKongregate = false;
	private static int UserId = 0;
	private static string UserName = "Guest";
	private static string GameAuthToken = "";

	void Awake () 
	{	
		if(instance == null)
		{	
			Application.ExternalEval("if(typeof(kongregateUnitySupport) != 'undefined'){" +
	  			" kongregateUnitySupport.initAPI('KongregateObject', 'OnKongregateAPILoaded');" +
	  			"};");
		
			Application.ExternalEval(
	    		"kongregate.services.addEventListener('login', function(){" +
	    		"   var services = kongregate.services;" +
	    		"   var params=[services.getUserId(), services.getUsername(), services.getGameAuthToken()].join('|');" +
	    		"   kongregateUnitySupport.getUnityObject().SendMessage('KongregateObject', 'OnKongregateUserSignedIn', params);" +
	    		"});");
			
			instance = this;
		}
		
		DontDestroyOnLoad(transform.gameObject);
	}
	
	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	private void OnKongregateAPILoaded(string pUserInfoString)
	{
		IsKongregate = true;
		string[] paramArray = pUserInfoString.Split('|');
		UserId = int.Parse(paramArray[0]);
		UserName = paramArray[1];
		GameAuthToken = paramArray[2];
	}
	
	private void OnKongregateUserSignedIn(string pUserInfoString)
	{
		string[] paramArray = pUserInfoString.Split('|');
		UserId = int.Parse(paramArray[0]);
		UserName = paramArray[1];
		GameAuthToken = paramArray[2];
	}
	
	public static void SubmitStatistic(string stat, int val)
    {
        if(IsKongregate)
		{
			Application.ExternalCall("kongregate.stats.submit",stat,val);
		}
    }
}
