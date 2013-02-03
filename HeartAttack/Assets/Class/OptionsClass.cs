using UnityEngine;
using System.Collections;

public class OptionsClass : MonoBehaviour {
	
	// Parameters of the game

	public static float PedalSpeedFactor = 15.0f; 	// Trycicle pedal animation speed
	public static float AtaulfoAcceleration = 0.1f;	// Ataulfo acceleration along the game
	public static int AtaulfoLateralSpeed = 50;		// Moving speed of Ataulfo with keyboard
	public static int AtaulfoLateralSpeedSlow = 30;	// Moving speed of Ataulfo with a powerdown
	public static int AtaulfoInitialOxygen = 9;		// Life of Ataulfo
	public static int AtaulfoOxygenExpireTime=5;    // Ataulfo loses oxygen in this time
	public static float ObstacleAngleMax = 67.0f;	// Changes the maximum angle of obstacles in veins
	public static float ObstacleRateMin = 3.0f;		// Obstacle min rate spawning
	public static float ObstacleRateMax = 6.0f;		// Obstacle min rate spawning
	public static float TimeToResetState = 1.0f;		// Time to reset a powerup or powerdown
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
