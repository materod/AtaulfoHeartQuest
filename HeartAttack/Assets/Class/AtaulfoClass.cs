using UnityEngine;
using System.Collections;

public class AtaulfoClass : MonoBehaviour {
	
	public enum AtaulfoStates
	{
		Ok = 0,
		Slimed,
		Confused,
		PumkinGodMode,
		Dead
	}
	
	private float _TimerState = 0;
	
	public static float Score = 0;
	public static string PlayerName = "Ataulfo";
	private int LateralSpeed;
	
	private float _Speed = 10;
	private int _Oxygen = 10;
	private int _Lateral = 0;
	private float _TimeToNextExpire=0;
	private AtaulfoStates _State = AtaulfoStates.Ok;
	public AtaulfoStates State
	{
		get{
			return _State;
		}
		set{
			_State = value;
			_TimerState = 0;
			switch(_State)
			{
			case AtaulfoStates.Ok:
				LateralSpeed = OptionsClass.AtaulfoLateralSpeed;
				break;
			case AtaulfoStates.PumkinGodMode:
				break;
			case AtaulfoStates.Slimed:
				LateralSpeed = OptionsClass.AtaulfoLateralSpeedSlow;
				break;
			case AtaulfoStates.Confused:
				break;
			case AtaulfoStates.Dead:
				// Fin de partida
				EndGame();
				break;
			}
		}
	}
	
	public float Speed{get{ return _Speed; } set{ _Speed=value; }}
	public int Oxygen
	{
		get{ return _Oxygen; } 
		set
		{ 
			_Oxygen=value; 
			if(_Oxygen<=0)
			{ 
				State = AtaulfoStates.Dead;
			}
			else if (_Oxygen>OptionsClass.AtaulfoInitialOxygen)
				_Oxygen=OptionsClass.AtaulfoInitialOxygen;
		}
	}

	// Use this for initialization
	void Start () {
		LateralSpeed = OptionsClass.AtaulfoLateralSpeed;
	}
	
	// Update is called once per frame
	void Update () {
		// Move Ataulfo
		
		bool bMoveRight = (State!= AtaulfoStates.Confused)?Input.GetKey(KeyCode.RightArrow):Input.GetKey(KeyCode.LeftArrow);
		bool bMoveLeft = (State!= AtaulfoStates.Confused)?Input.GetKey(KeyCode.LeftArrow):Input.GetKey(KeyCode.RightArrow);
		
		
		if (bMoveRight && transform.position.x<1.8f) 
		{
			_Lateral= LateralSpeed;
			transform.RotateAround (new Vector3(0,-2.1f,0), Vector3.forward, _Lateral * Time.deltaTime);
		}
		if (bMoveLeft && transform.position.x>-1.8f) 
		{
			_Lateral= -LateralSpeed;
			transform.RotateAround (new Vector3(0,-2.1f,0), Vector3.forward, _Lateral * Time.deltaTime);
		}
		
		
		// Reset states
		if(State != AtaulfoStates.Ok && State !=  AtaulfoStates.Dead)
		{
			_TimerState += Time.deltaTime;
			if(_TimerState > OptionsClass.TimeToResetState)
				State = AtaulfoStates.Ok;
		}
		
		// Ataulfo oxygen
		_TimeToNextExpire += Time.deltaTime;
		
		if (_TimeToNextExpire > OptionsClass.AtaulfoOxygenExpireTime)
		{
			_TimeToNextExpire-= OptionsClass.AtaulfoOxygenExpireTime;
			Oxygen--;
		}
	}
	
	private void EndGame()
	{
		Speed = 1;
		State = AtaulfoStates.Ok;
		Oxygen = OptionsClass.AtaulfoInitialOxygen;
		Application.LoadLevel("Ranking");
	}
}
